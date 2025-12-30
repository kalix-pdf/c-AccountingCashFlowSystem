using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace c_AccountingCashFlowSystem.Forms
{
    public partial class income : Form
    {
        IEModel db = new IEModel();
        public income()
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
        private void getmonthlyIncome()
        {
            List <RevenueTotal> monthlyRevenues = db.getMonthlyRevenue();

            foreach (RevenueTotal revenue in monthlyRevenues)
            {
                monthlyRevenue.Text = "P" + revenue.currentMonthTotal.ToString("N0");
                percentIncrease.Text = "+" + revenue.percentageChange.ToString("N0") + "% increase";
            }
            annualRevenue.Text = "P" + db.getAnnualIncome().ToString("N0");

        }
        private void load_summary_incomes()
        {
            var monthlyIncome = db.getIncomeSummaryMonthly(DateTime.Now.Year);

            var item = new ListViewItem(DateTime.Now.Year.ToString());

            for (int month = 1; month <= 12; month++)
            {
                monthlyIncome.TryGetValue(month, out decimal value);
                item.SubItems.Add("P" + value.ToString("N0"));
            }
            listViewIncome.Items.Add(item);
        }
        private void income_Load(object sender, EventArgs e)
        {
            listViewIncome.View = View.Details;
            listViewIncome.FullRowSelect = true;
            listViewIncome.GridLines = true;
            listViewIncome.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            listViewIncome.Columns.Add("Year");

            title.Text = "Income Summary - " + DateTime.Now.Year.ToString();

            var monthNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;

            foreach (var month in monthNames)
            {
                if (string.IsNullOrEmpty(month)) continue;

                listViewIncome.Columns.Add(month, 90, HorizontalAlignment.Center);
            }

            AutoSizeListViewColumns(listViewIncome);
            getmonthlyIncome();
            load_summary_incomes();
        }
    }
}
