namespace c_AccountingCashFlowSystem.Forms
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listViewEvents = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.activeEventsData = new System.Windows.Forms.Label();
            this.currentEventsLabel = new System.Windows.Forms.Label();
            this.moneyonHandPanel = new RoundedPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.moneyonHandLabel = new System.Windows.Forms.Label();
            this.roundedPanel4 = new RoundedPanel();
            this.totalExpensePanel = new RoundedPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.totalExpenseLabel = new System.Windows.Forms.Label();
            this.roundedPanel8 = new RoundedPanel();
            this.totalIncomePanel = new RoundedPanel();
            this.incomeLabelData = new System.Windows.Forms.Label();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.moneyonHandPanel.SuspendLayout();
            this.totalExpensePanel.SuspendLayout();
            this.totalIncomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(21, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 271);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 271);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listViewEvents);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(14);
            this.panel4.Size = new System.Drawing.Size(750, 220);
            this.panel4.TabIndex = 3;
            // 
            // listViewEvents
            // 
            this.listViewEvents.BackColor = System.Drawing.Color.LightCyan;
            this.listViewEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEvents.FullRowSelect = true;
            this.listViewEvents.GridLines = true;
            this.listViewEvents.HideSelection = false;
            this.listViewEvents.Location = new System.Drawing.Point(14, 14);
            this.listViewEvents.Name = "listViewEvents";
            this.listViewEvents.Size = new System.Drawing.Size(722, 192);
            this.listViewEvents.TabIndex = 1;
            this.listViewEvents.UseCompatibleStateImageBehavior = false;
            this.listViewEvents.View = System.Windows.Forms.View.Details;
            this.listViewEvents.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewEvents_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addClientBtn);
            this.panel3.Controls.Add(this.activeEventsData);
            this.panel3.Controls.Add(this.currentEventsLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 51);
            this.panel3.TabIndex = 0;
            // 
            // addClientBtn
            // 
            this.addClientBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addClientBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addClientBtn.FlatAppearance.BorderSize = 0;
            this.addClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addClientBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClientBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addClientBtn.Location = new System.Drawing.Point(587, 0);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(163, 51);
            this.addClientBtn.TabIndex = 3;
            this.addClientBtn.Text = "Add Events or Clients";
            this.addClientBtn.UseVisualStyleBackColor = false;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // activeEventsData
            // 
            this.activeEventsData.AutoSize = true;
            this.activeEventsData.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activeEventsData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.activeEventsData.Location = new System.Drawing.Point(229, 13);
            this.activeEventsData.Name = "activeEventsData";
            this.activeEventsData.Size = new System.Drawing.Size(22, 25);
            this.activeEventsData.TabIndex = 2;
            this.activeEventsData.Text = "0";
            // 
            // currentEventsLabel
            // 
            this.currentEventsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.currentEventsLabel.AutoSize = true;
            this.currentEventsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentEventsLabel.Location = new System.Drawing.Point(12, 13);
            this.currentEventsLabel.Name = "currentEventsLabel";
            this.currentEventsLabel.Size = new System.Drawing.Size(200, 25);
            this.currentEventsLabel.TabIndex = 0;
            this.currentEventsLabel.Text = "Current Active Events: ";
            // 
            // moneyonHandPanel
            // 
            this.moneyonHandPanel.BackColor = System.Drawing.Color.Indigo;
            this.moneyonHandPanel.BorderRadius = 20;
            this.moneyonHandPanel.Controls.Add(this.label3);
            this.moneyonHandPanel.Controls.Add(this.moneyonHandLabel);
            this.moneyonHandPanel.Location = new System.Drawing.Point(532, 18);
            this.moneyonHandPanel.Name = "moneyonHandPanel";
            this.moneyonHandPanel.Size = new System.Drawing.Size(230, 130);
            this.moneyonHandPanel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "₱0";
            // 
            // moneyonHandLabel
            // 
            this.moneyonHandLabel.AutoSize = true;
            this.moneyonHandLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyonHandLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.moneyonHandLabel.Location = new System.Drawing.Point(12, 19);
            this.moneyonHandLabel.Name = "moneyonHandLabel";
            this.moneyonHandLabel.Size = new System.Drawing.Size(127, 21);
            this.moneyonHandLabel.TabIndex = 2;
            this.moneyonHandLabel.Text = "Money on Hand";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Location = new System.Drawing.Point(541, 25);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(230, 130);
            this.roundedPanel4.TabIndex = 2;
            // 
            // totalExpensePanel
            // 
            this.totalExpensePanel.BackColor = System.Drawing.Color.DarkMagenta;
            this.totalExpensePanel.BorderRadius = 20;
            this.totalExpensePanel.Controls.Add(this.label2);
            this.totalExpensePanel.Controls.Add(this.totalExpenseLabel);
            this.totalExpensePanel.Location = new System.Drawing.Point(276, 18);
            this.totalExpensePanel.Name = "totalExpensePanel";
            this.totalExpensePanel.Size = new System.Drawing.Size(230, 130);
            this.totalExpensePanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "₱0";
            // 
            // totalExpenseLabel
            // 
            this.totalExpenseLabel.AutoSize = true;
            this.totalExpenseLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpenseLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalExpenseLabel.Location = new System.Drawing.Point(12, 19);
            this.totalExpenseLabel.Name = "totalExpenseLabel";
            this.totalExpenseLabel.Size = new System.Drawing.Size(116, 21);
            this.totalExpenseLabel.TabIndex = 1;
            this.totalExpenseLabel.Text = "Total Expenses";
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel8.BorderRadius = 20;
            this.roundedPanel8.Location = new System.Drawing.Point(285, 25);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(230, 130);
            this.roundedPanel8.TabIndex = 2;
            // 
            // totalIncomePanel
            // 
            this.totalIncomePanel.BackColor = System.Drawing.Color.MediumVioletRed;
            this.totalIncomePanel.BorderRadius = 20;
            this.totalIncomePanel.Controls.Add(this.incomeLabelData);
            this.totalIncomePanel.Controls.Add(this.totalIncomeLabel);
            this.totalIncomePanel.Location = new System.Drawing.Point(21, 18);
            this.totalIncomePanel.Name = "totalIncomePanel";
            this.totalIncomePanel.Size = new System.Drawing.Size(230, 130);
            this.totalIncomePanel.TabIndex = 1;
            // 
            // incomeLabelData
            // 
            this.incomeLabelData.AutoSize = true;
            this.incomeLabelData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLabelData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.incomeLabelData.Location = new System.Drawing.Point(12, 74);
            this.incomeLabelData.Name = "incomeLabelData";
            this.incomeLabelData.Size = new System.Drawing.Size(29, 21);
            this.incomeLabelData.TabIndex = 1;
            this.incomeLabelData.Text = "₱0";
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalIncomeLabel.Location = new System.Drawing.Point(12, 19);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(104, 21);
            this.totalIncomeLabel.TabIndex = 0;
            this.totalIncomeLabel.Text = "Total Income";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(30, 25);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(230, 130);
            this.roundedPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Location = new System.Drawing.Point(31, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 271);
            this.panel5.TabIndex = 5;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.moneyonHandPanel);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.totalExpensePanel);
            this.Controls.Add(this.roundedPanel8);
            this.Controls.Add(this.totalIncomePanel);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "dashboard";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "dashboard";
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.Resize += new System.EventHandler(this.dashboard_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.moneyonHandPanel.ResumeLayout(false);
            this.moneyonHandPanel.PerformLayout();
            this.totalExpensePanel.ResumeLayout(false);
            this.totalExpensePanel.PerformLayout();
            this.totalIncomePanel.ResumeLayout(false);
            this.totalIncomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel roundedPanel1;
        private RoundedPanel totalIncomePanel;
        private RoundedPanel totalExpensePanel;
        private RoundedPanel roundedPanel8;
        private RoundedPanel moneyonHandPanel;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label moneyonHandLabel;
        private System.Windows.Forms.Label totalExpenseLabel;
        private System.Windows.Forms.Label totalIncomeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label incomeLabelData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listViewEvents;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Label activeEventsData;
        private System.Windows.Forms.Label currentEventsLabel;
        private System.Windows.Forms.Panel panel5;
    }
}