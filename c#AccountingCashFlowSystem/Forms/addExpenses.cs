using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace c_AccountingCashFlowSystem.Forms
{
    
    public partial class addExpenses : Form
    {
        IEModel db = new IEModel();
        decimal isCheckMonthlyExpenses;

        public addExpenses()
        {
            InitializeComponent();
            isCheckMonthlyExpenses = db.isCheckMonthlyExpense();
        }
        private List<expenseItem> getExpensesfromForm()
        {
            var expenses = new List<expenseItem>();

            foreach (var nud in operationalPanel.Controls
                .OfType<NumericUpDown>()
                .Concat(regulatoryPanel.Controls.OfType<NumericUpDown>()))
                {
                    if (nud.Value <= 0 || nud.Tag == null)
                        continue;

                    if (!int.TryParse(nud.Tag.ToString(), out int tagId))
                        continue; 

                    expenses.Add(new expenseItem
                    {
                        ExpenseTag = tagId,
                        Amount = nud.Value
                    });
                }

            return expenses;
        }
        private bool validateForm()
        {

            return operationalPanel.Controls.OfType<NumericUpDown>().Any(n => n.Value > 0)
                || regulatoryPanel.Controls.OfType<NumericUpDown>().Any(n => n.Value > 0);
        }
        
        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (!validateForm())
            {
                MessageBox.Show("Please enter at least one Operational and one Regulatory expense.",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var expenses = getExpensesfromForm();
            decimal total = expenses.Sum(a => a.Amount);
            int TransactionID;

            int? existingTransactionId = db.getTransactionID();

            if (existingTransactionId > 0)
            {
                TransactionID = (int)existingTransactionId;
                db.addNewTransaction(total, TransactionID);
            }
            else
            {
                TransactionID = db.addNewTransaction(total);
            }

            bool success = db.addExpense(expenses, TransactionID);

            if (success)
            {
                MessageBox.Show("Expense Added Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void addExpenses_Load(object sender, EventArgs e)
        {
            List<ExpenseCategory> expenses = db.getExpenses();

            if (isCheckMonthlyExpenses > 0)
            {
                MessageBox.Show("You have already added your expenses for this month, You are only allowed to edit the existing expenses",
                    "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (var nud in operationalPanel.Controls.OfType<NumericUpDown>()
                    .Concat(regulatoryPanel.Controls.OfType<NumericUpDown>()))
                {
                    if (!int.TryParse(nud.Tag.ToString(), out int tagId))
                        continue;

                    foreach (var expense in expenses)
                    {
                        if (tagId == expense.categoryId)
                        {
                            nud.Value = expense.amount;
                        }
                    }
                }
            }
        }
    }
}
