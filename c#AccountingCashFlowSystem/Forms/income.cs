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
    public partial class income : Form
    {
        IEModel db = new IEModel();
        public income()
        {
            InitializeComponent();
        }
        public void ApplyTheme(Color themeColor)
        {
            weekIncomePanel.BackColor = themeColor;
            monthIncomePanel.BackColor = themeColor;
            yearIncomePanel.BackColor = themeColor;
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
        private void getIncome()
        {
            int todayIncome = db.getIncomeToday();
            int weeklyIncome = db.getIncomeWeekly();
            int monthlyIncome = db.getIncomeMonthly();
            int yearlyIncome = db.getIncomeYearly();

            weekIncomeData.Text = "P" + weeklyIncome.ToString("N0");
            todayIncomeData.Text = "P" + todayIncome.ToString("N0");
            monthIncomeData.Text = "P" + monthlyIncome.ToString("N0");
            yearIncomeData.Text = "P" + yearlyIncome.ToString("N0");
        }
        private void load_incomes()
        {
            listViewIncome.Items.Clear();
            List<Income> incomes = db.getIncome();

            foreach (Income income in incomes)
            {
                ListViewItem item = new ListViewItem(income.CreatedAt.ToShortDateString());
                item.Font = new Font("Segoe UI Semibold", 10, FontStyle.Regular);

                //item.SubItems.Add(income.CreatedAt.ToShortDateString());
                item.SubItems.Add("P" + income.Amount.ToString("N0"));
                item.SubItems.Add(income.IncomeType);
                item.SubItems.Add(income.referenceNumber);

                listViewIncome.Items.Add(item);
            }
        }
        private void income_Load(object sender, EventArgs e)
        {
            listViewIncome.View = View.Details;
            listViewIncome.FullRowSelect = true;
            listViewIncome.GridLines = true;

            listViewIncome.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            listViewIncome.Columns.Add("Date");
            listViewIncome.Columns.Add("Amount");
            listViewIncome.Columns.Add("Income Type");
            listViewIncome.Columns.Add("Reference Number");

            AutoSizeListViewColumns(listViewIncome);
            getIncome();
            load_incomes();
        }
    }
}
