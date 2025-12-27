namespace c_AccountingCashFlowSystem
{
    partial class Form1
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
            this.reports = new System.Windows.Forms.Button();
            this.expenses = new System.Windows.Forms.Button();
            this.income = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.TitleBar = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.childFormPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.TitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.reports);
            this.panel1.Controls.Add(this.expenses);
            this.panel1.Controls.Add(this.income);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 514);
            this.panel1.TabIndex = 0;
            // 
            // reports
            // 
            this.reports.Dock = System.Windows.Forms.DockStyle.Top;
            this.reports.FlatAppearance.BorderSize = 0;
            this.reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reports.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.reports.Image = global::c_AccountingCashFlowSystem.Properties.Resources.exchange;
            this.reports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports.Location = new System.Drawing.Point(0, 219);
            this.reports.Name = "reports";
            this.reports.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.reports.Size = new System.Drawing.Size(215, 48);
            this.reports.TabIndex = 5;
            this.reports.Text = "   Reports";
            this.reports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.reports.UseVisualStyleBackColor = true;
            this.reports.Click += new System.EventHandler(this.reports_Click);
            // 
            // expenses
            // 
            this.expenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.expenses.FlatAppearance.BorderSize = 0;
            this.expenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.expenses.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenses.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.expenses.Image = global::c_AccountingCashFlowSystem.Properties.Resources.cost;
            this.expenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses.Location = new System.Drawing.Point(0, 171);
            this.expenses.Name = "expenses";
            this.expenses.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.expenses.Size = new System.Drawing.Size(215, 48);
            this.expenses.TabIndex = 4;
            this.expenses.Text = "   Expenses";
            this.expenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.expenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.expenses.UseVisualStyleBackColor = true;
            this.expenses.Click += new System.EventHandler(this.expenses_Click);
            // 
            // income
            // 
            this.income.Dock = System.Windows.Forms.DockStyle.Top;
            this.income.FlatAppearance.BorderSize = 0;
            this.income.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.income.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.income.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.income.Image = global::c_AccountingCashFlowSystem.Properties.Resources.increase;
            this.income.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income.Location = new System.Drawing.Point(0, 123);
            this.income.Name = "income";
            this.income.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.income.Size = new System.Drawing.Size(215, 48);
            this.income.TabIndex = 3;
            this.income.Text = "   Income";
            this.income.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.income.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.income.UseVisualStyleBackColor = true;
            this.income.Click += new System.EventHandler(this.income_Click);
            // 
            // dashboard
            // 
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard.FlatAppearance.BorderSize = 0;
            this.dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboard.Image = global::c_AccountingCashFlowSystem.Properties.Resources.exchange;
            this.dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.Location = new System.Drawing.Point(0, 75);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.dashboard.Size = new System.Drawing.Size(215, 48);
            this.dashboard.TabIndex = 2;
            this.dashboard.Text = "   Dashboard";
            this.dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Teal;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 7);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(215, 75);
            this.panelLogo.TabIndex = 1;
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.LightSeaGreen;
            this.TitleBar.Controls.Add(this.title);
            this.TitleBar.Controls.Add(this.header);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(215, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(790, 75);
            this.TitleBar.TabIndex = 1;
            // 
            // title
            // 
            this.title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(341, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(103, 20);
            this.title.TabIndex = 1;
            this.title.Text = "DASHBOARD";
            this.title.Click += new System.EventHandler(this.label1_Click);
            // 
            // header
            // 
            this.header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(222, 11);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(361, 28);
            this.header.TabIndex = 0;
            this.header.Text = "BEBE\'S RESORT ACCOUNTING SYSTEM";
            // 
            // childFormPanel
            // 
            this.childFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.childFormPanel.Location = new System.Drawing.Point(215, 75);
            this.childFormPanel.Name = "childFormPanel";
            this.childFormPanel.Size = new System.Drawing.Size(790, 439);
            this.childFormPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 514);
            this.Controls.Add(this.childFormPanel);
            this.Controls.Add(this.TitleBar);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button expenses;
        private System.Windows.Forms.Button income;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel childFormPanel;
        private System.Windows.Forms.Button reports;
        private System.Windows.Forms.Label title;
    }
}

