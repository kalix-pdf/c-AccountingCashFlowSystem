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
        private int _paymentmethod;
        private string _referenceNo;
        private decimal _amount;
        public viewinfo(int clientId)
        {
            InitializeComponent();
            _clientId = clientId;
            this.StartPosition = FormStartPosition.CenterParent;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            loadClients();
        }
        public void loadClients()
        {
            var clientInfo = new ClientDatabase().GetClient(_clientId);

            if (clientInfo != null)
            {
                int startX = 10;
                int startY = 40;
                int columnWidth = 120;
                int rowHeight = 25;

                _amount = clientInfo.TotalAmount;
                _paymentmethod = clientInfo.PaymentMethod;
                _referenceNo = clientInfo.ReferenceNo;

                clientName.Text = clientInfo.FullName;
                downPayment.Text = $"₱{clientInfo.DownPayment:N0}";
                startDate.Text = clientInfo.StartDate.ToShortDateString();
                endDate.Text = clientInfo.EndDate.ToShortDateString();
                pymethod.Text = (clientInfo.PaymentMethod == 1) ? "Cash" : (clientInfo.PaymentMethod == 2) ? "E-wallet"
                            : (clientInfo.PaymentMethod == 3) ? "Banks" : "None";
                refnum.Text = clientInfo.ReferenceNo;

                if (clientInfo.FullPayment == 1)
                {
                    totalAmount.Text = $"₱{clientInfo.TotalAmount:N0} (PAID IN FULL)";
                    fullPaid.Text = "Yes";
                }
                else
                {
                    fullPaid.Text = "No";
                    totalAmount.Text = $"₱{clientInfo.TotalAmount:N0}";
                }

                for (int i = 0; i < clientInfo.ClientAmenities.Count; i++)
                {
                    var amenity = clientInfo.ClientAmenities[i];

                    Label amenityLB = new Label();
                    amenityLB.Text = " - " + amenity.amenitiesName;
                    //amenityLB.Tag = amenity.roomID;
                    amenityLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    amenityLB.AutoSize = true;

                    int column = i % 2;
                    int row = i / 2;
                    amenityLB.Location = new Point(startX + (column * columnWidth), startY + (row * rowHeight));
                    amenitiesPanel.Controls.Add(amenityLB);
                }

                for (int x = 0; x < clientInfo.ClientRooms.Count; x++)
                {
                    var room = clientInfo.ClientRooms[x];

                    Label roomLB = new Label();
                    roomLB.Text = " - " + room.roomName;
                    roomLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    roomLB.AutoSize = true;

                    int column = x % 2;
                    int row = x / 2;
                    roomLB.Location = new Point(startX + (column * columnWidth), startY + (row * rowHeight));
                    roomPanel.Controls.Add(roomLB);
                }
            } 
            else
            {
                MessageBox.Show("Client not found.", "Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void completetransacbtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to complete this transaction?", "Confirm",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                bool transactionCompleted = new ClientDatabase().completeTransac(_clientId);
                int insertNewTransaction = new IEModel().addNewTransaction(_amount, _paymentmethod, _referenceNo, 1);

                if (transactionCompleted && insertNewTransaction > 0)
                {
                    MessageBox.Show("Transaction completed successfully.", "Success",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to complete the transaction.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
            
        }
    }
}
