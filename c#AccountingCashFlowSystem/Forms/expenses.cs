using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_AccountingCashFlowSystem.Forms
{
    public partial class expenses : Form
    {
        IEModel db = new IEModel();
        private int currentYear = DateTime.Now.Year;
        private string currentMonth = DateTime.Now.ToString("MMM");
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
        private void load_summary_expenses_listView()
        {
            decimal[] columnTotals = new decimal[12];
            var monthlyIncome = db.getExpensesSumarryMonth(currentYear);
            var monthNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;

            for (int monthIndex = 1; monthIndex <= 12; monthIndex++)
            {
                string monthName = monthNames[monthIndex - 1];
                if (string.IsNullOrEmpty(monthName)) continue;

                ListViewItem item = new ListViewItem(monthName);
                listViewExpensesSumarry.Items.Add(item);

                for (int i = 1; i <= 12; i++)
                {
                    monthlyIncome.TryGetValue(i, out decimal value);
                    columnTotals[i - 1] += value;
                    item.SubItems.Add("P" + value.ToString("N0"));
                }
            }

            ListViewItem totalItem = new ListViewItem("Total");

            decimal grandTotal = 0;

            for (int i = 0; i < 12; i++)
            {
                grandTotal += columnTotals[i];
                totalItem.SubItems.Add("P" + columnTotals[i].ToString("N0"));
            }

            listViewExpensesSumarry.Items.Add(totalItem);
        }
        private void expenses_Load(object sender, EventArgs e)
        {
            listViewExpensesSumarry.View = View.Details;
            listViewExpensesSumarry.FullRowSelect = true;
            listViewExpensesSumarry.GridLines = true;
            listViewExpensesSumarry.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            listViewExpensesSumarry.Columns.Add("Month");
            listViewExpensesSumarry.Columns.Add("Amount (P)");

            listViewOperational.View = View.Details;
            listViewOperational.FullRowSelect = true;
            listViewOperational.GridLines = true;
            listViewOperational.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            listViewOperational.Columns.Add("Expenses");
            listViewOperational.Columns.Add("Amount (P)");

            //List<string> expenses = new List<string> {"Marketing", "License and Permit", "Food and Beverages",
            //                    "Repairs and Maintenance", "Utilities", "Salaries", "Internet/POS", "Transportation Cost",
            //                    "Legal Fees", "Miscellaneous", "Office Supplies", "Taxes", "Bank Charges", "Loan Interest"};



            AutoSizeListViewColumns(listViewOperational);
            AutoSizeListViewColumns(listViewExpensesSumarry);

            //load_summary_expenses_listView();
        }

        private void addExpensesBtn_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.addExpenses())
            {
                form.ShowDialog();
            }
        }
    }
}
