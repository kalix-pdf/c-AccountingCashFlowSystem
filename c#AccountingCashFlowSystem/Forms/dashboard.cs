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
    public partial class dashboard : Form
    {
        private ClientDatabase db = new ClientDatabase();
        public dashboard()
        {
            InitializeComponent();
            LoadEvents();
        }
        //load events here
        public void LoadEvents()
        {
            listViewEvents.Items.Clear();
            int index = 1;
            List<Client> clients = db.GetCurrentEvents();

            foreach (Client c in clients)
            {
                ListViewItem item = new ListViewItem(index.ToString());
                item.Tag = c.ClientId;
                item.SubItems.Add(c.StartDate.ToShortDateString());
                item.SubItems.Add(c.FullName);
                item.SubItems.Add(c.DownPayment.ToString());
                item.SubItems.Add(c.EndDate.ToShortDateString());
                item.SubItems.Add("View Info");

                listViewEvents.Items.Add(item);
                index++;
            }
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
            listViewEvents.View = View.Details;
            listViewEvents.FullRowSelect = true;
            listViewEvents.GridLines = true;

            listViewEvents.Columns.Add("#");
            listViewEvents.Columns.Add("Start Date");
            listViewEvents.Columns.Add("Client Name");
            listViewEvents.Columns.Add("Paid Amount");
            listViewEvents.Columns.Add("End Date");
            listViewEvents.Columns.Add("Action");

            AutoSizeListViewColumns(listViewEvents);
            LoadEvents();
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
                    form.ShowDialog();
                }
            }
        }
    }
}
