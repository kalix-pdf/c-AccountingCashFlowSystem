using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace c_AccountingCashFlowSystem.Forms
{
    public class Income
    {
        public DateTime CreatedAt { get; set; }
        public int Amount { get; set; }
        public string IncomeType { get; set; }
        public string referenceNumber { get; set; }
    }
    public class ExpenseCategory
    {
        public string CategoryName { get; set; }
        public int categoryID { get; set; }
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
        public decimal getIncomeToday()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT ISNULL(SUM(Amount), 0)
                    FROM Transactions
                    WHERE CreatedAt >= CAST(GETDATE() AS DATE)
                      AND CreatedAt < DATEADD(DAY, 1, CAST(GETDATE() AS DATE))", conn))
                    {
                        conn.Open();
                        return Convert.ToDecimal(cmd.ExecuteScalar());
                    }   
        }
        public Dictionary<int, decimal> getIncomeSummaryMonthly(int year)
        {
            var result = new Dictionary<int, decimal>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT MONTH(CreatedAt) AS Month, SUM(Amount) As TotalIncome 
                    FROM Transactions WHERE TransactionType = 'Income' AND YEAR(CreatedAt) = 2025 
                    GROUP BY MONTH(CreatedAt) ORDER BY Month;", conn))
            {
                cmd.Parameters.AddWithValue("@year", year);
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
                @"SELECT SUM(CASE WHEN YEAR(CreatedAt) = YEAR(GETDATE()) 
                AND MONTH(CreatedAt) = MONTH(GETDATE()) THEN Amount ELSE 0 END) AS CurrentMonth, 
                SUM(CASE WHEN YEAR(CreatedAt) = YEAR(DATEADD(MONTH, -1, GETDATE())) 
                AND MONTH(CreatedAt) = MONTH(DATEADD(MONTH, -1, GETDATE())) 
                THEN Amount ELSE 0 END) AS LastMonth FROM Transactions", conn))
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
        public decimal getAnnualIncome()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT TOP 1 SUM(Amount) FROM Transactions GROUP BY YEAR(CreatedAt) 
                ORDER BY YEAR(CreatedAt) DESC", conn))
            {
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
            }
        }
        public List<Income> getIncome()
        {
            List<Income> incomes = new List<Income>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "SELECT CreatedAt, Amount, TransactionType, ReferenceNo " +
                        "FROM Transactions WHERE TransactionType = 'Income' " +
                        "ORDER BY CreatedAt DESC";
                    SqlCommand cmd = new SqlCommand(Query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            incomes.Add(new Income
                            {
                                CreatedAt = reader.GetDateTime(0),
                                Amount = Convert.ToInt32(reader.GetValue(1)),
                                IncomeType = reader.GetString(2),
                                referenceNumber = reader.GetString(3)
                            });
                        }
                    }
                    return incomes;
                }
                catch
                {
                    throw;
                }
            }
        }

        //expenses
        public List<ExpenseCategory> getExpenseCategories()
        {
            List<ExpenseCategory> expenseCategories = new List<ExpenseCategory>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "SELECT categoryID, categoryName FROM expenseCategories";
                    SqlCommand cmd = new SqlCommand(Query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            expenseCategories.Add(new ExpenseCategory
                            {
                                categoryID = Convert.ToInt32(reader.GetValue(0)),
                                CategoryName = reader.GetString(1)
                            });
                        }
                    }
                    return expenseCategories;
                }
                catch
                {
                    throw;
                }
            }
        }

        public int addNewTransaction(decimal amount, int paymentmethod, string referenceNumber, int transactionType = 0)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                int transactionID = 0;

                try
                {
                    _TType = (transactionType == 1) ? "Income" : "Expenses";

                    string TQuery = @"INSERT INTO Transactions (ReferenceNo, Amount, TransactionType, PaymentMethod) " +
                        "VALUES (@refnum, @amount, @transacType, @pymethod);" +
                        "SELECT SCOPE_IDENTITY();";
                    SqlCommand Tcmd = new SqlCommand(TQuery, conn, trans);

                    Tcmd.Parameters.AddWithValue("@refnum", referenceNumber);
                    Tcmd.Parameters.AddWithValue("@amount", amount);
                    Tcmd.Parameters.AddWithValue("@transacType", _TType);
                    Tcmd.Parameters.AddWithValue("@pymethod", paymentmethod);

                    transactionID = Convert.ToInt32(Tcmd.ExecuteScalar());

                    trans.Commit();
                    return transactionID;
                }
                catch
                {
                    trans.Rollback();
                    throw;
                }
            }
        }
        public bool addExpense(int categoryID, decimal amount, int transactionID)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    string EQuery = "INSERT INTO expenses (transactionID, categoryID, expenseDate, amount) " +
                        "VALUES (@transacID, @categID, @expenseDate, @amount)";
                    SqlCommand Ecmd = new SqlCommand(EQuery, conn, trans);

                    Ecmd.Parameters.AddWithValue("@transacID", transactionID);
                    Ecmd.Parameters.AddWithValue("@categID", categoryID);
                    Ecmd.Parameters.AddWithValue("@expenseDate", DateTime.Now);
                    Ecmd.Parameters.AddWithValue("@amount", amount);
                    Ecmd.ExecuteNonQuery();

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
        public decimal getMonthlyExpenses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT TOP 1 SUM(Amount) FROM Expenses GROUP BY MONTH(ExpenseDate) 
                ORDER BY MONTH(ExpenseDate) DESC", conn))
            {
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
            }
        }
        public decimal getYearlyExpenses()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT TOP 1 SUM(Amount) FROM Expenses GROUP BY YEAR(ExpenseDate) 
                ORDER BY YEAR(ExpenseDate) DESC", conn))
                  {
                      conn.Open();
                    return Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
                  }
        }
    }
}
