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

        //income

        public Dictionary<int, decimal> getIncomeSummaryMonthly(int year)
        {
            var result = new Dictionary<int, decimal>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT MONTH(CreatedAt) AS Month, SUM(Amount) As TotalIncome 
                    FROM Transactions WHERE TransactionType = 'Income' AND YEAR(CreatedAt) = @year
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
                @"DECLARE @year INT = YEAR(GETDATE());
                DECLARE @currentMonth INT = MONTH(GETDATE());
                SELECT SUM(CASE WHEN YEAR(CreatedAt) = @year AND MONTH(CreatedAt) = @currentMonth 
                THEN Amount ELSE 0 END) AS CurrentMonth, SUM(CASE WHEN YEAR(CreatedAt) = @year 
                AND MONTH(CreatedAt) = @currentMonth - 1 AND @currentMonth > 1 THEN Amount ELSE 0  
                END) AS LastMonth FROM Transactions;", conn))
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
        public decimal getCurrentTotalRevenue(int year)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                @"SELECT TOP 1 SUM(Amount) FROM Transactions WHERE YEAR(CreatedAt) = @year
                GROUP BY YEAR(CreatedAt) ORDER BY YEAR(CreatedAt) DESC", conn))
            {
                cmd.Parameters.AddWithValue("@year", year);
                conn.Open();
                return Convert.ToDecimal(cmd.ExecuteScalar() ?? 0);
            }
        }

        //expenses

        public Dictionary<int, decimal> getExpensesSumarryMonth(int year)
        {
            var result = new Dictionary<int, decimal>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(@"
                    SELECT MONTH(CreatedAt) AS Month, SUM(Amount) As TotalIncome 
                    FROM Transactions WHERE TransactionType = 'Expenses' AND YEAR(CreatedAt) = @year
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
