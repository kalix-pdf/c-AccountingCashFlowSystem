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

                clientName.Text = clientInfo.FullName;
                downPayment.Text = $"₱{clientInfo.DownPayment:N0}";
                startDate.Text = clientInfo.StartDate.ToShortDateString();
                endDate.Text = clientInfo.EndDate.ToShortDateString();

                if (clientInfo.FullPayment == 1)
                {
                    totalAmount.Text = $"₱{clientInfo.TotalAmount:N0} (PAID IN FULL)";
                }
                else
                {
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
    }
}
