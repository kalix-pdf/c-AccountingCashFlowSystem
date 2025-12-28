using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_AccountingCashFlowSystem.Forms
{
    public partial class expenses : Form
    {
        IEModel db = new IEModel();
        private int _expensetag1;
        private int _expensetag2;
        private int _expensetag3;
        private int _expensetag4;
        public expenses()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            bool allSuccess = true;

            var expenses = new List<(int Tag, decimal Value)>
            {
                (_expensetag1, expense1.Value),
                (_expensetag2, expense2.Value),
                (_expensetag3, expense3.Value),
                (_expensetag4, expense4.Value),
            }
            .Where(a => a.Tag > 0 && a.Value > 0)
            .ToList();

            if (!expenses.Any())
            {
                MessageBox.Show("Please enter at least one expense.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = expenses.Sum(a => a.Value);
            string referenceNumber = ClientDatabase.GenerateReferenceNumber();

            int TransactionID = db.addNewTransaction(totalAmount, 0, referenceNumber);

            if (TransactionID > 0)
            {
                foreach (var expense in expenses)
                {
                    if (!db.addExpense(expense.Tag, expense.Value, TransactionID))
                    {
                        allSuccess = false;
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Something went wrong :( please contact the developer",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if (allSuccess)
            {
                MessageBox.Show(
                    allSuccess ? "Expenses added successfully." : "Failed to add expenses.",
                    allSuccess ? "Success" : "Error",
                    MessageBoxButtons.OK,
                    allSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error
                );
                expense1.Value = 0;
                expense2.Value = 0;
                expense3.Value = 0;
                expense4.Value = 0;
            }

        }
        private void BindExpenseCategory(Dictionary<string, int> lookup, string categoryName, Label label, Control expenseControl, out int categoryId)
        {
            label.Text = categoryName;

            if (!lookup.TryGetValue(categoryName, out categoryId))
            {
                throw new Exception($"Expense category '{categoryName}' not found in database.");
            }

            expenseControl.Tag = categoryId;
        }

        private void categoriesExpenseLoad()
        {
            List<ExpenseCategory> expenseCategories = db.getExpenseCategories();
            var categoryLookup = expenseCategories.ToDictionary(c => c.CategoryName, c => c.categoryID);

            BindExpenseCategory(categoryLookup, "Salaries", salaryLabel, expense1, out _expensetag1);
            BindExpenseCategory(categoryLookup, "Maintenance", maintenanceLabel, expense2, out _expensetag2);
            BindExpenseCategory(categoryLookup, "Utilities", utilityLabel, expense3, out _expensetag3);
            BindExpenseCategory(categoryLookup, "Other", otherLabel, expense4, out _expensetag4);
        }
        private void expenses_Load(object sender, EventArgs e)
        {
            categoriesExpenseLoad();
        }
    }
}
