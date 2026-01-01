using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace c_AccountingCashFlowSystem.Forms
{
    public partial class addExpenses : Form
    {
        public addExpenses()
        {
            InitializeComponent();
        }
        private bool validateForm()
        {
            bool operationalValidate = operationalPanel.Controls.OfType<NumericUpDown>()
                .All(n => n.Value > 0);
            bool regulatoryValidae = regulatoryPanel.Controls.OfType<NumericUpDown>()
                .All (n => n.Value > 0);

            return (operationalValidate && regulatoryValidae) ? true : false;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {

            }
            else
            {
                MessageBox.Show("No Data Input, Fill out atleast one or two expensess", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
