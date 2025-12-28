using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

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
    public class IEModel
    {
        private string connectionString = new Client().Connection();
        private string _TType;

        public int getIncomeToday()
        {
            int todayIncome = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string Query = "SELECT " +
                        "CAST(CreatedAt AS DATE) AS IncomeDate, " +
                        "SUM(Amount) AS DailyIncome " +
                        "FROM Transactions " +
                        "WHERE TransactionType = 'Income' GROUP BY CAST(CreatedAt AS DATE) " +
                        "ORDER BY IncomeDate DESC; ";
                    SqlCommand cmd = new SqlCommand(Query, conn);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime incomeDate = reader.GetDateTime(0);

                            if (incomeDate.Date == DateTime.Now.Date)
                            {
                                object val = reader.GetValue(1);
                                todayIncome = (val == DBNull.Value) ? 0 : Convert.ToInt32(val);
                            }
                        }
                    }
                    return todayIncome;
                } 
                catch 
                {
                    throw;
                }
            }
        }
        public int getIncomeWeekly()
        {
            int weeklyIncome = 0;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "SELECT DATEPART(YEAR, CreatedAt) AS Year, " +
                        "DATEPART(WEEK, CreatedAt) AS Week, SUM(Amount) AS WeeklyIncome " +
                        "FROM Transactions WHERE TransactionType = 'Income' GROUP BY " +
                        "DATEPART(YEAR, CreatedAt), DATEPART(WEEK, CreatedAt) ORDER BY Year DESC, Week DESC";
                    SqlCommand cmd = new SqlCommand(Query, conn);

                    object result = cmd.ExecuteScalar();
                    weeklyIncome = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);

                    return weeklyIncome;
                }
                catch
                {
                    throw;
                }
            }
        }
        public int getIncomeMonthly()
        {
            int monthlyIncome = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "SELECT YEAR(CreatedAt) AS Year, MONTH(CreatedAt) AS Month, " +
                        "SUM(Amount) AS MonthlyIncome FROM Transactions WHERE TransactionType = 'Income' " +
                        "GROUP BY YEAR(CreatedAt), MONTH(CreatedAt) ORDER BY Year DESC, Month DESC";

                    SqlCommand cmd = new SqlCommand(Query, conn);

                    object result = cmd.ExecuteScalar();
                    monthlyIncome = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                    return monthlyIncome;
                }
                catch
                {
                    throw;
                }
            }
        }
        public int getIncomeYearly()
        {
            int yearlyIncome = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "SELECT YEAR(CreatedAt) AS Year, " +
                        "SUM(Amount) AS YearlyIncome FROM Transactions WHERE TransactionType = 'Income' " +
                        "GROUP BY YEAR(CreatedAt) ORDER BY Year DESC";
                    SqlCommand cmd = new SqlCommand(Query, conn);

                    object result = cmd.ExecuteScalar();
                    yearlyIncome = (result == DBNull.Value) ? 0 : Convert.ToInt32(result);
                    return yearlyIncome;
                }
                catch
                {
                    throw;
                }
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
            List <ExpenseCategory> expenseCategories = new List <ExpenseCategory>();

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

        public int addNewTransaction (decimal amount, int paymentmethod, string referenceNumber, int transactionType = 0)
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
    }
}
