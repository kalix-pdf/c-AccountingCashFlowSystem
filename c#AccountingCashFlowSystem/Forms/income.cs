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
        private int currentYear = DateTime.Now.Year;
        private string currentMonth = DateTime.Now.ToString("MMM");
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
                else
                {
                    percentIncrease.Text = revenue.percentageChange.ToString("N0") + "% decrease";
                }
            }

        }
        private void load_data()
        {
            decimal currentTotalRevenue = db.getCurrentTotalRevenue(currentYear);

            currentRevenue.Text = "P" + currentTotalRevenue.ToString();
            asOfTotalRev.Text = "As of " + currentMonth + " " + currentYear;
        }
        private void load_summary_incomes()
        {
            decimal[] columnTotals = new decimal[12];
            var monthlyIncome = db.getIncomeSummaryMonthly(currentYear);
            var monthNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;

            for (int monthIndex = 1; monthIndex <= 12; monthIndex++)
            {
                string monthName = monthNames[monthIndex - 1];
                if (string.IsNullOrEmpty(monthName)) continue;

                ListViewItem item = new ListViewItem(monthName);
                listViewIncome.Items.Add(item);

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

            title.Text = "Income Summary - " + currentYear;

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
