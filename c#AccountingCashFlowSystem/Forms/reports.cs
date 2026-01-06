using Microsoft.Office.Interop.Excel;
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
    public partial class reports : Form
    {
        private IEModel db = new IEModel();
        public reports()
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

        private void load_months()
        {
            var monthNames = CultureInfo.CurrentCulture.DateTimeFormat.AbbreviatedMonthNames;

            for (int month = 1; month <= 12; month++)
            {
                string monthName = monthNames[month - 1];
                if (string.IsNullOrEmpty(monthName)) continue;

                ListViewItem item = new ListViewItem(monthName);
                listViewData.Items.Add(item);
            }
        }
        private void reports_Load(object sender, EventArgs e)
        {
            var years = db.getTransactionYear();
            selectYear.DataSource = years;
            selectYear.SelectedItem = DateTime.Now.Year;

            listViewData.View = View.Details;
            listViewData.FullRowSelect = true;
            listViewData.GridLines = true;
            listViewData.Font = new System.Drawing.Font("Segoe UI Semibold", 11, FontStyle.Bold);
            listViewData.Columns.Add("Month");
            listViewData.Columns.Add("Expenses (P)");
            listViewData.Columns.Add("Revenue (P)");
            listViewData.Columns.Add("Net Income");

            AutoSizeListViewColumns(listViewData);
            load_months();
        }

        private void listViewData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
