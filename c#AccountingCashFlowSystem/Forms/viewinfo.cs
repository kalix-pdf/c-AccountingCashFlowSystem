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
    public partial class viewinfo : Form
    {
        private readonly int _clientId;
        private Client clientInfo;
        public viewinfo(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadClients();
        }
        public void loadClients()
        {
            clientInfo = new ClientDatabase().GetClient(_clientId);

            if (clientInfo == null)
            {
                MessageBox.Show("Client not found.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            } 
            else
            {
                clientName.Text = clientInfo.FullName;
                if (clientInfo.FullPayment == 1)
                {
                    totalAmount.Text = $"₱{clientInfo.TotalAmount:N0} (PAID IN FULL)";
                }
                else
                {
                    totalAmount.Text = $"₱{clientInfo.TotalAmount:N0}";
                }
                downPayment.Text = $"₱{clientInfo.DownPayment:N0}";
                startDate.Text = clientInfo.StartDate.ToShortDateString();
                endDate.Text = clientInfo.EndDate.ToShortDateString();
                amenities.Text = clientInfo.Amenities;
            }
        }
    }
}
