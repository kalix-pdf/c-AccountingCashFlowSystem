using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace c_AccountingCashFlowSystem.Forms
{
    public partial class expenses : Form
    {
        IEModel db = new IEModel();
        public expenses()
        {
            InitializeComponent();
        }
        private void AutoSizeListViewColumns(ListView lv)
        {
            if (lv.Columns.Count == 0) return;

            int totalWidth = lv.ClientSize.Width;
            int columnWidth = totalWidth / lv.Columns.Count;

            foreach (ColumnHeader column in lv.Columns)
            {
                column.Width = columnWidth;
            }
        }
        private void load_data()
        {
            decimal currentTotalExpenses = db.getCurrentTotalRevenueAndExpenses("Expenses");
            decimal isCheckMonthlyExpenses = db.isCheckMonthlyExpense();

            annualExpenses.Text = (currentTotalExpenses > 0) ? "₱" + currentTotalExpenses.ToString() : "₱0";
            asOfNowTotalExpense.Text = "As of " + db.currentMonth + " " + db.currentYear;

            expenseSummary.Text = "Expense Summary - " + db.currentYear;
            monthLabel.Text = " - " + db.currentMonth;

            if (isCheckMonthlyExpenses > 0)
            {
                expenseCheck.Text = "₱" + isCheckMonthlyExpenses.ToString() + " expenses";
                monthlyExpenses.Text = "₱" + isCheckMonthlyExpenses.ToString() + " - " + db.currentMonth;
                yearLabel.Text = db.currentMonth;
            }
            
        }
        private void load_listView_data()
        {
            listViewExpensesSumarry.BeginUpdate();
            listViewOperational.BeginUpdate();

            try
            {
                listViewOperational.Items.Clear();
                listViewExpensesSumarry.Items.Clear();

                List<ExpenseCategory> expenses = db.getExpenses();

                foreach (var expense in expenses)
                {
                    ListViewItem item = new ListViewItem(expense.CategoryName.ToString());
                    item.SubItems.Add("P" + expense.amount.ToString());

                    listViewOperational.Items.Add(item);
                }

                var monthlyExpenses = db.getIncomeAndExpensesSummaryMonthly("Expenses");
                var monthNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;

                decimal grandTotal = 0;

                for (int month = 1; month <= 12; month++)
                {
                    string monthName = monthNames[month - 1];
                    if (string.IsNullOrEmpty(monthName)) continue;

                    monthlyExpenses.TryGetValue(month, out decimal value);

                    ListViewItem item = new ListViewItem(monthName);
                    item.SubItems.Add("P" + value.ToString("N0"));

                    listViewExpensesSumarry.Items.Add(item);

                    grandTotal += value;
                }

                ListViewItem totalItem = new ListViewItem("Total");
                totalItem.SubItems.Add("P" + grandTotal.ToString("N0"));

                listViewExpensesSumarry.Items.Add(totalItem);
            }
            finally
            {
                listViewOperational.EndUpdate();
                listViewExpensesSumarry.EndUpdate();
            }
            
        }
        private void expenses_Load(object sender, EventArgs e)
        {
            Font font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);

            listViewExpensesSumarry.View = View.Details;
            listViewExpensesSumarry.FullRowSelect = true;
            listViewExpensesSumarry.GridLines = true;
            listViewExpensesSumarry.Font = font;
            listViewExpensesSumarry.Columns.Add("Month");
            listViewExpensesSumarry.Columns.Add("Amount (P)");

            listViewOperational.View = View.Details;
            listViewOperational.FullRowSelect = true;
            listViewOperational.GridLines = true;
            listViewOperational.Font = font;
            listViewOperational.Columns.Add("Expenses");
            listViewOperational.Columns.Add("Amount (P)");

            AutoSizeListViewColumns(listViewOperational);
            AutoSizeListViewColumns(listViewExpensesSumarry);

            load_listView_data();
            load_data();
        }

        private void addExpensesBtn_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.addExpenses())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    load_data();
                    load_listView_data();
                }
            }
        }
    }
}
