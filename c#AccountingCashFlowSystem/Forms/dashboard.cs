using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace c_AccountingCashFlowSystem.Forms
{
    public partial class dashboard : Form
    {
        private ClientDatabase db = new ClientDatabase();
        private IEModel model = new IEModel();
        public dashboard()
        {
            InitializeComponent();
            LoadEvents();
        }
        //load events here
        public void LoadEvents()
        {
            listViewEvents.Items.Clear();
            List<Client> clients = db.GetCurrentEvents();

            int totalEvents = db.GetCurrentEvents().Count;
            activeEventsData.Text = totalEvents.ToString();

            foreach (Client c in clients)
            {
                ListViewItem item = new ListViewItem(c.ReferenceNo.ToString());
                item.Font = new Font("Segoe UI Semibold", 10, FontStyle.Regular);

                item.Tag = c.ClientId;
                item.SubItems.Add(c.StartDate.ToShortDateString());
                item.SubItems.Add(c.FullName);
                item.SubItems.Add(" P" + c.TotalAmount.ToString());
                item.SubItems.Add(c.EndDate.ToShortDateString());
                item.SubItems.Add("View Info");

                listViewEvents.Items.Add(item);
            }
        }
        private void load_data()
        {
            decimal totalExpenses = model.getTotalExpenses();
            expenseLabelData.Text = "P" + totalExpenses.ToString("N0");

            decimal totalIncome = model.getTotalNetIncome();
            incomeLabelData.Text = "P" + totalIncome.ToString("N0");
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            listViewEvents.View = View.Details;
            listViewEvents.FullRowSelect = true;
            listViewEvents.GridLines = true;

            listViewEvents.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            listViewEvents.Columns.Add("Refence No.");
            listViewEvents.Columns.Add("Start Date");
            listViewEvents.Columns.Add("Client Name");
            listViewEvents.Columns.Add("Total Amount");
            listViewEvents.Columns.Add("End Date");
            listViewEvents.Columns.Add("Action");

            AutoSizeListViewColumns(listViewEvents);

            LoadEvents();
            load_data();
        }
        private void dashboard_Resize(object sender, EventArgs e)
        {
            AutoSizeListViewColumns(listViewEvents);

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
        private void addClientBtn_Click(object sender, EventArgs e)
        {
            using (var form = new Forms.addclientbtn())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadEvents();
                }
            }
        }

        private void listViewEvents_MouseClick(object sender, MouseEventArgs e)
        {
            if (listViewEvents.SelectedItems.Count == 0) return;

            ListViewItem item = listViewEvents.SelectedItems[0];

            int actionColumnIndex = 5;

            Rectangle subItemRect = item.SubItems[actionColumnIndex].Bounds;

            if (subItemRect.Contains(e.Location))
            {
                int clientId = int.Parse(item.Tag.ToString());
                using (var form = new Forms.viewinfo(clientId))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadEvents();
                        load_data();
                    }
                }
            }
        }
    }
}
