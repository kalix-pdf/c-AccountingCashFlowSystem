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
            List<RevenueTotal> monthlyRevenues = db.getMonthlyRevenue();

            foreach (RevenueTotal revenue in monthlyRevenues)
            {
                monthlyRevenue.Text = "P" + revenue.currentMonthTotal.ToString("N0");
                if (revenue.percentageChange > 0)
                {
                    percentIncrease.Text = "+" + revenue.percentageChange.ToString("N0") + "% increase";
                }
                else if (revenue.percentageChange < 0)
                {
                    percentIncrease.Text = revenue.percentageChange.ToString("N0") + "% decrease";
                }
                else
                {
                    percentIncrease.Text = "0% Changes";
                }
            }

        }
        private void load_data()
        {
            decimal currentTotalRevenue = db.getCurrentTotalRevenueAndExpenses();
            decimal curretnTotalNetIncome = db.getCurrentNetIncome();
            decimal totalNetIncome = db.getTotalNetIncome();

            //total current revenue
            currentRevenue.Text = "P" + currentTotalRevenue.ToString();
            asOfTotalRev.Text = "As of " + db.currentMonth + " " + db.currentYear;

            //total current net income
            totalSalesData.Text = "P" + curretnTotalNetIncome.ToString();
            asOfLabel.Text = "As of " + db.currentMonth + " " + db.currentYear;
            yearLabel.Text = "(" + db.currentYear + ")";

            //total net income
            TotalNetIncome.Text = "P" + totalNetIncome.ToString();
        }
        private void load_summary_incomes()
        {
            var monthlyIncome = db.getIncomeAndExpensesSummaryMonthly();
            var monthNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;

            decimal grandTotal = 0;

            for (int month = 1; month <= 12; month++)
            {
                string monthName = monthNames[month - 1];
                if (string.IsNullOrEmpty(monthName)) continue;

                monthlyIncome.TryGetValue(month, out decimal value);

                ListViewItem item = new ListViewItem(monthName);
                item.SubItems.Add("P" + value.ToString("N0"));

                listViewIncome.Items.Add(item);

                grandTotal += value;
            }

            ListViewItem totalItem = new ListViewItem("Total");
            totalItem.SubItems.Add("P" + grandTotal.ToString("N0"));

            listViewIncome.Items.Add(totalItem);

        }
        private void income_Load(object sender, EventArgs e)
        {
            listViewIncome.View = View.Details;
            listViewIncome.FullRowSelect = true;
            listViewIncome.GridLines = true;
            listViewIncome.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            listViewIncome.Columns.Add("Month");
            listViewIncome.Columns.Add("Amount (P)");

            title.Text = "Income Summary - " + db.currentYear;

            AutoSizeListViewColumns(listViewIncome);
            getmonthlyIncome();
            load_summary_incomes();
            load_data();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
