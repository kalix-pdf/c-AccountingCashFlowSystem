using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace c_AccountingCashFlowSystem.Forms
{
    public class monthlyExpenses
    {
        public int TransactionId { get; set;  }
        public decimal amount { get; set; }
    }
    public class expenseItem
    {
        public int ExpenseTag { get; set; }
        public decimal Amount { get; set; }
    }
    public class ExpenseCategory
    {
        public string CategoryName { get; set; }
        public int amount { get; set; }
        public int categoryId { get; set; }
    }
    public class RevenueTotal
    {
        public decimal currentMonthTotal { get; set; }
        public decimal percentageChange { get; set; }
    }
    public class IEModel
    {
        private string connectionString = new Client().Connection();
        private string _TType;
        public int currentYear => DateTime.Now.Year;
        public string currentMonth => DateTime.Now.ToString("MMM");

        public int addNewTransaction(decimal amount, int TransactionID = 0, string referenceNumber = null, int paymentmethod = 0, int transactionType = 0)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                
                _TType = (transactionType == 1) ? "Income" : "Expenses";

                if (string.IsNullOrEmpty(referenceNumber))
                {
                    referenceNumber = ClientDatabase.GenerateReferenceNumber();
                }

                try
                {
                    if (TransactionID > 0)
                    {
                        string Query = @"UPDATE Transactions SET Amount = @amount WHERE TransactionId = @transacID";
                        SqlCommand cmd = new SqlCommand(Query, conn, trans);

                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@transacID", TransactionID);

                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        string TQuery = @"INSERT INTO Transactions (ReferenceNo, Amount, TransactionType, PaymentMethod) " +
                            "VALUES (@refnum, @amount, @transacType, @pymethod);" +
                            "SELECT SCOPE_IDENTITY();";
                        SqlCommand Tcmd = new SqlCommand(TQuery, conn, trans);

                        Tcmd.Parameters.AddWithValue("@refnum", referenceNumber);
                        Tcmd.Parameters.AddWithValue("@amount", amount);
                        Tcmd.Parameters.AddWithValue("@transacType", _TType);
                        Tcmd.Parameters.AddWithValue("@pymethod", paymentmethod);

                        TransactionID = Convert.ToInt32(Tcmd.ExecuteScalar());
                    }

                    trans.Commit();
                    return TransactionID;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }

        //income

        public Dictionary<int, decimal> getIncomeAndExpensesSummaryMonthly(string type = "Income")
        {
            var result = new Dictionary<int, decimal>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT MONTH(CreatedAt) AS Month, SUM(Amount) As TotalIncome 
                    FROM Transactions WHERE TransactionType = @type AND YEAR(CreatedAt) = @year
                    GROUP BY MONTH(CreatedAt) ORDER BY Month;", conn))
            {
                cmd.Parameters.AddWithValue("@year", currentYear);
                cmd.Parameters.AddWithValue("@type", type);
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int month = reader.GetInt32(0);
                        decimal total = reader.GetDecimal(1);

                        result[month] = total; 
                    }
                }
            }

            return result;
        }

        public List<RevenueTotal> getMonthlyRevenue()
        {
            List<RevenueTotal> revenueTotals = new List<RevenueTotal>();
            decimal currentTotal = 0;
            decimal lastMonthTotal = 0;
            decimal percentage = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"DECLARE @year INT = YEAR(GETDATE());
                DECLARE @currentMonth INT = MONTH(GETDATE());
                SELECT SUM(CASE WHEN YEAR(CreatedAt) = @year AND MONTH(CreatedAt) = @currentMonth 
                THEN Amount ELSE 0 END) AS CurrentMonth, SUM(CASE WHEN YEAR(CreatedAt) = @year 
                AND MONTH(CreatedAt) = @currentMonth - 1 AND @currentMonth > 1 THEN Amount ELSE 0  
                END) AS LastMonth FROM Transactions WHERE TransactionType = 'Income';", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currentTotal = reader.GetDecimal(0);
                        lastMonthTotal = reader.GetDecimal(1);
                    }
                }
                if (lastMonthTotal > 0)
                {
                    percentage = ((currentTotal / lastMonthTotal) - 1) * 100;
                }
                revenueTotals.Add(new RevenueTotal
                {
                    currentMonthTotal = currentTotal,
                    percentageChange = percentage
                });

                return revenueTotals;
            }
        }
        public decimal getCurrentTotalRevenueAndExpenses(string type = "Income")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT ISNULL(SUM(Amount), 0) FROM Transactions WHERE YEAR(CreatedAt) = @year 
                AND TransactionType = @type", conn))
            {
                cmd.Parameters.AddWithValue("@year", currentYear);
                cmd.Parameters.AddWithValue("@type", type);
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
        }

        public decimal getCurrentNetIncome()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                decimal income = 0;
                decimal expenses = 0;
                try
                {
                    using (SqlCommand cmd = new SqlCommand(
                        @"SELECT SUM(CASE WHEN TransactionType = 'Income' THEN Amount ELSE 0 END) AS totalIncome, 
                        SUM(CASE WHEN TransactionType = 'Expenses' THEN Amount ELSE 0 END) AS totalExpenses
                        FROM Transactions WHERE YEAR(CreatedAt) = @year", conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@year", currentYear);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                income = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                                expenses = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                             
                            }
                        }
                    }
                    return (income - expenses);

                }
                catch
                {
                    throw;
                }
            }
        }
        public decimal getTotalNetIncome()
        {
            decimal income = 0;
            decimal expenses = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT SUM(CASE WHEN TransactionType = 'Income' THEN Amount ELSE 0 END) AS totalIncome, 
                SUM(CASE WHEN TransactionType = 'Expenses' THEN Amount ELSE 0 END) FROM Transactions", conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        income = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        expenses = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                    }
                }
            }

            return (income - expenses);
        }
        //expenses
        public List<monthlyExpenses> checkExpenseThisMonth()
        {
            List<monthlyExpenses> monthlyExpenses = new List<monthlyExpenses>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT TransactionId, Amount FROM Transactions WHERE YEAR(CreatedAt) = @year 
                AND TransactionType = 'Expenses' AND MONTH(CreatedAt) = MONTH(GETDATE());", conn))
            {
                conn.Open();
                cmd.Parameters.AddWithValue("@year", currentYear);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        monthlyExpenses.Add(new monthlyExpenses
                        {
                            TransactionId = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                            amount = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1)
                        });
                    }
                }
            }
            return monthlyExpenses;
        }
        public int getTransactionID()
        {
            List<monthlyExpenses> monthlyExpenses = checkExpenseThisMonth();

            foreach (var monthExpenses in monthlyExpenses)
            {
                if (monthExpenses.TransactionId > 0)
                {
                    return monthExpenses.TransactionId;
                }
            }
            return 0;
        }
        public decimal isCheckMonthlyExpense()
        {
            List<monthlyExpenses> monthlyExpenses = checkExpenseThisMonth();

            foreach (var monthExpenses in monthlyExpenses)
            {
                if (monthExpenses.amount > 0)
                {
                     return monthExpenses.amount;
                }
            }
            return 0;
        }

        public bool addExpense(List<expenseItem> expenses, int transactionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string EQuery = @"IF EXISTS (SELECT 1 FROM expenses WHERE transactionID 
                        = @transacID AND categoryID = @categID) BEGIN UPDATE expenses SET Amount = @amount, expenseDate = 
                        @expenseDate WHERE transactionID = @transacID AND categoryID = @categID END ELSE BEGIN INSERT INTO 
                        expenses(transactionID, categoryID, expenseDate, amount) VALUES (@transacID, @categID, @expenseDate, @amount) END";
                    
                    foreach (var expense in expenses)
                    {
                        SqlCommand Ecmd = new SqlCommand(EQuery, conn, trans);

                        Ecmd.Parameters.AddWithValue("@transacID", SqlDbType.Int).Value = transactionID;
                        Ecmd.Parameters.AddWithValue("@categID", SqlDbType.Int).Value = expense.ExpenseTag;
                        Ecmd.Parameters.AddWithValue("@expenseDate", SqlDbType.DateTime).Value = DateTime.Now;
                        Ecmd.Parameters.AddWithValue("@amount", SqlDbType.Decimal).Value = expense.Amount;
                        Ecmd.ExecuteNonQuery();
                    }

                    trans.Commit();
                    return true;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
        public List<ExpenseCategory> getExpenses()
        {
            List<ExpenseCategory> expenses = new List<ExpenseCategory>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    string Query = @"DECLARE @currentMonth INT = MONTH(GETDATE());
                        SELECT e.amount, ec.categoryName, ec.categoryID FROM expenses AS e 
                        LEFT JOIN expenseCategories AS ec ON e.categoryID = ec.categoryID WHERE MONTH(expenseDate) = @currentMonth";
                    using (SqlCommand cmd = new SqlCommand(Query, conn))
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                expenses.Add(new ExpenseCategory
                                {
                                    amount = Convert.ToInt32(reader["amount"]),
                                    CategoryName = reader["categoryName"].ToString(),
                                    categoryId = Convert.ToInt32(reader["categoryID"])
                                });
                            }
                        }
                    }
                    return expenses;
                }
                catch
                {
                    throw;
                }
            }
        }

        public decimal getTotalExpenses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string Query = "SELECT ISNULL(SUM(Amount), 0) FROM Transactions WHERE TransactionType = " +
                    "'Expenses'";
                using (SqlCommand cmd = new SqlCommand(Query, conn))
                {
                    conn.Open();
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
            }
        }
        
    }
}
