using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace c_AccountingCashFlowSystem.Forms
{
    public partial class addclientbtn : Form
    {
        private ClientDatabase db = new ClientDatabase();
        public addclientbtn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        private void UpdateCheckBoxColor(CheckBox chk)
        {
            if (chk.Checked)
            {
                chk.BackColor = Color.DarkSlateGray;
                chk.ForeColor = Color.White;
            }
            else
            {
                chk.BackColor = Color.DarkCyan;
                chk.ForeColor = Color.White;
            }
        }

        private void room6chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxColor(sender as CheckBox);
        }

        private void room5chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxColor(sender as CheckBox);
        }

        private void room4chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxColor(sender as CheckBox);
        }

        private void room3chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxColor(sender as CheckBox);
        }

        private void room2chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxColor(sender as CheckBox);
        }

        private void room1chk_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCheckBoxColor(sender as CheckBox);
        }
        private void HighlightControl(Control ctrl)
        {
            ctrl.BackColor = Color.MistyRose; 
            ctrl.Focus();
        }

        private void ResetControlHighlight(Control ctrl)
        {
            ctrl.BackColor = SystemColors.Window; 
        }
        private bool ValidateForm()
        {
            bool isValid = true;

            ResetControlHighlight(inputClientName);
            ResetControlHighlight(totalAmountInput);
            ResetControlHighlight(downPaymentInput);
            ResetControlHighlight(endDate);

            if (string.IsNullOrWhiteSpace(inputClientName.Text))
            {
                HighlightControl(inputClientName);
                MessageBox.Show("Client name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (totalAmountInput.Value <= 0)
            {
                HighlightControl(totalAmountInput);
                MessageBox.Show("Total amount must be greater than zero.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (downPaymentInput.Value > totalAmountInput.Value)
            {
                HighlightControl(downPaymentInput);
                MessageBox.Show("Down Payment must not be greater than total amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (fullPaymentchk.Checked && downPaymentInput.Value > 0)
            {
                HighlightControl(downPaymentInput);
                MessageBox.Show("Down Payment must be zero if Full Payment is checked.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (endDate.Value.Date <= DateTime.Today)
            {
                HighlightControl(endDate);
                MessageBox.Show("End date must be after today.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var amenityCheckboxes = amenitiesPanel.Controls.OfType<CheckBox>().Where(cb => cb.Name.StartsWith("chkAmenity_"));

            bool anyCheckedAmenity = amenityCheckboxes.Any(cb => cb.Checked);

            if (!anyCheckedAmenity)
            {
                MessageBox.Show("Please select at least one amenity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var roomCheckboxes = roomsPanel.Controls.OfType<CheckBox>().Where(cb => cb.Name.StartsWith("roomchk_"));

            bool anyCheckedRoom = roomCheckboxes.Any(cb => cb.Checked);

            if (!anyCheckedRoom)
            {
                MessageBox.Show("Please select at least one room.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cashrdbtn.Checked == false && ewalletrdbtn.Checked == false && banksrdbtn.Checked == false)
            {
                MessageBox.Show("Please select a payment method.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return isValid;
        }
        private void createEventBtn_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ClientDatabase db = new ClientDatabase();

                List<int> selectedAmenities = new List<int>();
                List<int> selectedRooms = new List<int>();

                int totalAmount = (int)totalAmountInput.Value;
                var fullPayment = fullPaymentchk.Checked ? 1 : 0;
                int downPayment = (fullPayment == 1) ? 0 : (int)downPaymentInput.Value;

                int paymentMethod = cashrdbtn.Checked ? 1 : (ewalletrdbtn.Checked ? 2 : 3);

                DateTime startdate = startDate.Value;
                DateTime enddate = endDate.Value;

                foreach (Control ctrl in amenitiesPanel.Controls)
                {
                    if (ctrl is CheckBox cb && cb.Checked)
                    {
                        selectedAmenities.Add((int)cb.Tag);
                    }
                }

                foreach (CheckBox chk in roomsPanel.Controls.OfType<CheckBox>())
                {
                    if (chk.Checked && chk.Tag != null)
                    {
                        selectedRooms.Add(Convert.ToInt32(chk.Tag));
                    }
                }

                int success = db.InsertNewClient(inputClientName.Text, totalAmount, downPayment, startdate, enddate, selectedAmenities, selectedRooms, fullPayment, paymentMethod);
            
                if (success > 0)
                {
                    MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again later :)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void addclientbtn_Load(object sender, EventArgs e)
        {
            loadAmenties();
            loadRooms();
        }
        private void loadAmenties()
        {
            //amenitiesPanel.Controls.Clear();
            var amenities = db.getAmenties();
            int startX = 6;
            int startY = 40;
            int columnWidth = 160; 
            int rowHeight = 25;

            for (int i = 0; i < amenities.Count; i++)
            {
                var amenity = amenities[i];
                CheckBox cb = new CheckBox();

                cb.Name = "chkAmenity_" + amenity.amenitiesID;
                cb.Text = amenity.amenitiesName;
                cb.Tag = amenity.amenitiesID; 
                cb.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cb.AutoSize = true;
                
                int column = i % 2;
                int row = i / 2;

                cb.Location = new Point(startX + (column * columnWidth), startY + (row * rowHeight));
                amenitiesPanel.Controls.Add(cb);
            }
        }
        private void loadRooms()
        {
            //roomsPanel.Controls.Clear();
            var rooms = db.getRooms();
            int startX = 6;
            int startY = 40;
            int columnWidth = 160; 
            int rowHeight = 25;

            for (int i = 0; i < rooms.Count; i++)
            {
                var room = rooms[i];
                CheckBox cb = new CheckBox();
                cb.Name = "roomchk_" + room.roomID;
                cb.Text = room.roomName;
                cb.Tag = room.roomID; 
                cb.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                cb.AutoSize = true;
                
                int column = i % 2;
                int row = i / 2;
                cb.Location = new Point(startX + (column * columnWidth), startY + (row * rowHeight));
                roomsPanel.Controls.Add(cb);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
