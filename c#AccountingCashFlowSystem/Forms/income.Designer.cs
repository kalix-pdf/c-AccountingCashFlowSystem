namespace c_AccountingCashFlowSystem.Forms
{
    partial class income
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
            this.listViewIncome = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addIncomeBtn = new System.Windows.Forms.Button();
            this.todayIncomeData = new System.Windows.Forms.Label();
            this.todayIncomeLabel = new System.Windows.Forms.Label();
            this.yearIncomePanel = new RoundedPanel();
            this.yearIncomeData = new System.Windows.Forms.Label();
            this.yearIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel4 = new RoundedPanel();
            this.monthIncomePanel = new RoundedPanel();
            this.monthIncomeData = new System.Windows.Forms.Label();
            this.monthIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel8 = new RoundedPanel();
            this.weekIncomePanel = new RoundedPanel();
            this.weekIncomeData = new System.Windows.Forms.Label();
            this.weekIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.yearIncomePanel.SuspendLayout();
            this.monthIncomePanel.SuspendLayout();
            this.weekIncomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(21, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 271);
            this.panel1.TabIndex = 11;
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
            this.panel4.Controls.Add(this.listViewIncome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 51);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(14);
            this.panel4.Size = new System.Drawing.Size(750, 220);
            this.panel4.TabIndex = 3;
            // 
            // listViewIncome
            // 
            this.listViewIncome.BackColor = System.Drawing.Color.LightCyan;
            this.listViewIncome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewIncome.FullRowSelect = true;
            this.listViewIncome.GridLines = true;
            this.listViewIncome.HideSelection = false;
            this.listViewIncome.Location = new System.Drawing.Point(14, 14);
            this.listViewIncome.Name = "listViewIncome";
            this.listViewIncome.Size = new System.Drawing.Size(722, 192);
            this.listViewIncome.TabIndex = 1;
            this.listViewIncome.UseCompatibleStateImageBehavior = false;
            this.listViewIncome.View = System.Windows.Forms.View.Details;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.addIncomeBtn);
            this.panel3.Controls.Add(this.todayIncomeData);
            this.panel3.Controls.Add(this.todayIncomeLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 51);
            this.panel3.TabIndex = 0;
            // 
            // addIncomeBtn
            // 
            this.addIncomeBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.addIncomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addIncomeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.addIncomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addIncomeBtn.FlatAppearance.BorderSize = 0;
            this.addIncomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addIncomeBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addIncomeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addIncomeBtn.Location = new System.Drawing.Point(587, 0);
            this.addIncomeBtn.Name = "addIncomeBtn";
            this.addIncomeBtn.Size = new System.Drawing.Size(163, 51);
            this.addIncomeBtn.TabIndex = 3;
            this.addIncomeBtn.Text = "Add Income";
            this.addIncomeBtn.UseVisualStyleBackColor = false;
            // 
            // todayIncomeData
            // 
            this.todayIncomeData.AutoSize = true;
            this.todayIncomeData.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayIncomeData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.todayIncomeData.Location = new System.Drawing.Point(162, 13);
            this.todayIncomeData.Name = "todayIncomeData";
            this.todayIncomeData.Size = new System.Drawing.Size(22, 25);
            this.todayIncomeData.TabIndex = 2;
            this.todayIncomeData.Text = "0";
            // 
            // todayIncomeLabel
            // 
            this.todayIncomeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.todayIncomeLabel.AutoSize = true;
            this.todayIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayIncomeLabel.Location = new System.Drawing.Point(12, 13);
            this.todayIncomeLabel.Name = "todayIncomeLabel";
            this.todayIncomeLabel.Size = new System.Drawing.Size(147, 25);
            this.todayIncomeLabel.TabIndex = 0;
            this.todayIncomeLabel.Text = "Today\'s Income: ";
            // 
            // yearIncomePanel
            // 
            this.yearIncomePanel.BackColor = System.Drawing.Color.LightCyan;
            this.yearIncomePanel.BorderRadius = 20;
            this.yearIncomePanel.Controls.Add(this.yearIncomeData);
            this.yearIncomePanel.Controls.Add(this.yearIncomeLabel);
            this.yearIncomePanel.Location = new System.Drawing.Point(532, 18);
            this.yearIncomePanel.Name = "yearIncomePanel";
            this.yearIncomePanel.Size = new System.Drawing.Size(230, 130);
            this.yearIncomePanel.TabIndex = 9;
            // 
            // yearIncomeData
            // 
            this.yearIncomeData.AutoSize = true;
            this.yearIncomeData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearIncomeData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yearIncomeData.Location = new System.Drawing.Point(12, 74);
            this.yearIncomeData.Name = "yearIncomeData";
            this.yearIncomeData.Size = new System.Drawing.Size(29, 21);
            this.yearIncomeData.TabIndex = 3;
            this.yearIncomeData.Text = "₱0";
            // 
            // yearIncomeLabel
            // 
            this.yearIncomeLabel.AutoSize = true;
            this.yearIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yearIncomeLabel.Location = new System.Drawing.Point(12, 19);
            this.yearIncomeLabel.Name = "yearIncomeLabel";
            this.yearIncomeLabel.Size = new System.Drawing.Size(100, 21);
            this.yearIncomeLabel.TabIndex = 2;
            this.yearIncomeLabel.Text = "Year Income";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Location = new System.Drawing.Point(541, 25);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(230, 130);
            this.roundedPanel4.TabIndex = 7;
            // 
            // monthIncomePanel
            // 
            this.monthIncomePanel.BackColor = System.Drawing.Color.LightCyan;
            this.monthIncomePanel.BorderRadius = 20;
            this.monthIncomePanel.Controls.Add(this.monthIncomeData);
            this.monthIncomePanel.Controls.Add(this.monthIncomeLabel);
            this.monthIncomePanel.Location = new System.Drawing.Point(276, 18);
            this.monthIncomePanel.Name = "monthIncomePanel";
            this.monthIncomePanel.Size = new System.Drawing.Size(230, 130);
            this.monthIncomePanel.TabIndex = 10;
            // 
            // monthIncomeData
            // 
            this.monthIncomeData.AutoSize = true;
            this.monthIncomeData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthIncomeData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.monthIncomeData.Location = new System.Drawing.Point(12, 74);
            this.monthIncomeData.Name = "monthIncomeData";
            this.monthIncomeData.Size = new System.Drawing.Size(29, 21);
            this.monthIncomeData.TabIndex = 2;
            this.monthIncomeData.Text = "₱0";
            // 
            // monthIncomeLabel
            // 
            this.monthIncomeLabel.AutoSize = true;
            this.monthIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.monthIncomeLabel.Location = new System.Drawing.Point(12, 19);
            this.monthIncomeLabel.Name = "monthIncomeLabel";
            this.monthIncomeLabel.Size = new System.Drawing.Size(161, 21);
            this.monthIncomeLabel.TabIndex = 1;
            this.monthIncomeLabel.Text = "This Month\'s Income";
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel8.BorderRadius = 20;
            this.roundedPanel8.Location = new System.Drawing.Point(285, 25);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(230, 130);
            this.roundedPanel8.TabIndex = 8;
            // 
            // weekIncomePanel
            // 
            this.weekIncomePanel.BackColor = System.Drawing.Color.LightCyan;
            this.weekIncomePanel.BorderRadius = 20;
            this.weekIncomePanel.Controls.Add(this.weekIncomeData);
            this.weekIncomePanel.Controls.Add(this.weekIncomeLabel);
            this.weekIncomePanel.Location = new System.Drawing.Point(21, 18);
            this.weekIncomePanel.Name = "weekIncomePanel";
            this.weekIncomePanel.Size = new System.Drawing.Size(230, 130);
            this.weekIncomePanel.TabIndex = 6;
            // 
            // weekIncomeData
            // 
            this.weekIncomeData.AutoSize = true;
            this.weekIncomeData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekIncomeData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.weekIncomeData.Location = new System.Drawing.Point(12, 74);
            this.weekIncomeData.Name = "weekIncomeData";
            this.weekIncomeData.Size = new System.Drawing.Size(29, 21);
            this.weekIncomeData.TabIndex = 1;
            this.weekIncomeData.Text = "₱0";
            // 
            // weekIncomeLabel
            // 
            this.weekIncomeLabel.AutoSize = true;
            this.weekIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.weekIncomeLabel.Location = new System.Drawing.Point(12, 19);
            this.weekIncomeLabel.Name = "weekIncomeLabel";
            this.weekIncomeLabel.Size = new System.Drawing.Size(153, 21);
            this.weekIncomeLabel.TabIndex = 0;
            this.weekIncomeLabel.Text = "This Week\'s Income";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(30, 25);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(230, 130);
            this.roundedPanel1.TabIndex = 5;
            // 
            // income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yearIncomePanel);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.monthIncomePanel);
            this.Controls.Add(this.roundedPanel8);
            this.Controls.Add(this.weekIncomePanel);
            this.Controls.Add(this.roundedPanel1);
            this.Name = "income";
            this.Padding = new System.Windows.Forms.Padding(15);
            this.Text = "income";
            this.Load += new System.EventHandler(this.income_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.yearIncomePanel.ResumeLayout(false);
            this.yearIncomePanel.PerformLayout();
            this.monthIncomePanel.ResumeLayout(false);
            this.monthIncomePanel.PerformLayout();
            this.weekIncomePanel.ResumeLayout(false);
            this.weekIncomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listViewIncome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addIncomeBtn;
        private System.Windows.Forms.Label todayIncomeData;
        private System.Windows.Forms.Label todayIncomeLabel;
        private RoundedPanel yearIncomePanel;
        private System.Windows.Forms.Label yearIncomeData;
        private System.Windows.Forms.Label yearIncomeLabel;
        private RoundedPanel roundedPanel4;
        private RoundedPanel monthIncomePanel;
        private System.Windows.Forms.Label monthIncomeData;
        private System.Windows.Forms.Label monthIncomeLabel;
        private RoundedPanel roundedPanel8;
        private RoundedPanel weekIncomePanel;
        private System.Windows.Forms.Label weekIncomeData;
        private System.Windows.Forms.Label weekIncomeLabel;
        private RoundedPanel roundedPanel1;
    }
}