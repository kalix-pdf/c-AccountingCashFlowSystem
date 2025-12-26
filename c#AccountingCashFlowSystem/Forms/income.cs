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

        private void income_Load(object sender, EventArgs e)
        {
            listViewIncome.View = View.Details;
            listViewIncome.FullRowSelect = true;
            listViewIncome.GridLines = true;

            listViewIncome.Columns.Add("Date");
            listViewIncome.Columns.Add("Amount");
            listViewIncome.Columns.Add("Income Type");
            listViewIncome.Columns.Add("Remarks");

            AutoSizeListViewColumns(listViewIncome);
        }
    }
}
