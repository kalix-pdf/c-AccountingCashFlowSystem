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
            this.yearIncomePanel = new RoundedPanel();
            this.annualRevenue = new System.Windows.Forms.Label();
            this.yearIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel4 = new RoundedPanel();
            this.monthIncomePanel = new RoundedPanel();
            this.monthlyRevenue = new System.Windows.Forms.Label();
            this.monthIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel8 = new RoundedPanel();
            this.weekIncomePanel = new RoundedPanel();
            this.totalSalesData = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.listViewIncome = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.percentIncrease = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new RoundedPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new RoundedPanel();
            this.roundedPanel5 = new RoundedPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.roundedPanel6 = new RoundedPanel();
            this.yearIncomePanel.SuspendLayout();
            this.monthIncomePanel.SuspendLayout();
            this.weekIncomePanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearIncomePanel
            // 
            this.yearIncomePanel.BackColor = System.Drawing.Color.CadetBlue;
            this.yearIncomePanel.BorderRadius = 20;
            this.yearIncomePanel.Controls.Add(this.annualRevenue);
            this.yearIncomePanel.Controls.Add(this.yearIncomeLabel);
            this.yearIncomePanel.Location = new System.Drawing.Point(18, 177);
            this.yearIncomePanel.Name = "yearIncomePanel";
            this.yearIncomePanel.Size = new System.Drawing.Size(230, 61);
            this.yearIncomePanel.TabIndex = 9;
            // 
            // annualRevenue
            // 
            this.annualRevenue.AutoSize = true;
            this.annualRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualRevenue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.annualRevenue.Location = new System.Drawing.Point(145, 19);
            this.annualRevenue.Name = "annualRevenue";
            this.annualRevenue.Size = new System.Drawing.Size(29, 21);
            this.annualRevenue.TabIndex = 3;
            this.annualRevenue.Text = "₱0";
            // 
            // yearIncomeLabel
            // 
            this.yearIncomeLabel.AutoSize = true;
            this.yearIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yearIncomeLabel.Location = new System.Drawing.Point(12, 19);
            this.yearIncomeLabel.Name = "yearIncomeLabel";
            this.yearIncomeLabel.Size = new System.Drawing.Size(127, 21);
            this.yearIncomeLabel.TabIndex = 2;
            this.yearIncomeLabel.Text = "Annual Revenue";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Location = new System.Drawing.Point(27, 184);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(230, 61);
            this.roundedPanel4.TabIndex = 7;
            // 
            // monthIncomePanel
            // 
            this.monthIncomePanel.BackColor = System.Drawing.Color.Teal;
            this.monthIncomePanel.BorderRadius = 20;
            this.monthIncomePanel.Controls.Add(this.label6);
            this.monthIncomePanel.Controls.Add(this.label5);
            this.monthIncomePanel.Controls.Add(this.label4);
            this.monthIncomePanel.Controls.Add(this.label3);
            this.monthIncomePanel.Controls.Add(this.percentIncrease);
            this.monthIncomePanel.Controls.Add(this.monthlyRevenue);
            this.monthIncomePanel.Controls.Add(this.monthIncomeLabel);
            this.monthIncomePanel.Location = new System.Drawing.Point(18, 251);
            this.monthIncomePanel.Name = "monthIncomePanel";
            this.monthIncomePanel.Size = new System.Drawing.Size(230, 181);
            this.monthIncomePanel.TabIndex = 10;
            // 
            // monthlyRevenue
            // 
            this.monthlyRevenue.AutoSize = true;
            this.monthlyRevenue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyRevenue.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.monthlyRevenue.Location = new System.Drawing.Point(12, 44);
            this.monthlyRevenue.Name = "monthlyRevenue";
            this.monthlyRevenue.Size = new System.Drawing.Size(93, 21);
            this.monthlyRevenue.TabIndex = 2;
            this.monthlyRevenue.Text = "₱500 (Jan.)";
            // 
            // monthIncomeLabel
            // 
            this.monthIncomeLabel.AutoSize = true;
            this.monthIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.monthIncomeLabel.Location = new System.Drawing.Point(11, 19);
            this.monthIncomeLabel.Name = "monthIncomeLabel";
            this.monthIncomeLabel.Size = new System.Drawing.Size(159, 25);
            this.monthIncomeLabel.TabIndex = 1;
            this.monthIncomeLabel.Text = "Monthly Revenue";
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel8.BorderRadius = 20;
            this.roundedPanel8.Location = new System.Drawing.Point(27, 258);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(230, 181);
            this.roundedPanel8.TabIndex = 8;
            // 
            // weekIncomePanel
            // 
            this.weekIncomePanel.BackColor = System.Drawing.Color.Teal;
            this.weekIncomePanel.BorderRadius = 20;
            this.weekIncomePanel.Controls.Add(this.label9);
            this.weekIncomePanel.Controls.Add(this.label8);
            this.weekIncomePanel.Controls.Add(this.label7);
            this.weekIncomePanel.Controls.Add(this.totalSalesData);
            this.weekIncomePanel.Location = new System.Drawing.Point(263, 177);
            this.weekIncomePanel.Name = "weekIncomePanel";
            this.weekIncomePanel.Size = new System.Drawing.Size(213, 139);
            this.weekIncomePanel.TabIndex = 6;
            // 
            // totalSalesData
            // 
            this.totalSalesData.AutoSize = true;
            this.totalSalesData.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalSalesData.Location = new System.Drawing.Point(12, 15);
            this.totalSalesData.Name = "totalSalesData";
            this.totalSalesData.Size = new System.Drawing.Size(89, 25);
            this.totalSalesData.TabIndex = 1;
            this.totalSalesData.Text = "₱100,000";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(272, 184);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(213, 139);
            this.roundedPanel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Location = new System.Drawing.Point(28, 29);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(750, 142);
            this.panel5.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(750, 142);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listViewIncome);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 53);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(14);
            this.panel4.Size = new System.Drawing.Size(750, 89);
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
            this.listViewIncome.Size = new System.Drawing.Size(722, 61);
            this.listViewIncome.TabIndex = 1;
            this.listViewIncome.UseCompatibleStateImageBehavior = false;
            this.listViewIncome.View = System.Windows.Forms.View.Details;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(18, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 142);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 53);
            this.panel3.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(281, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(152, 21);
            this.title.TabIndex = 0;
            this.title.Text = "Income Summary - ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "(Per Month)";
            // 
            // percentIncrease
            // 
            this.percentIncrease.AutoSize = true;
            this.percentIncrease.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentIncrease.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.percentIncrease.Location = new System.Drawing.Point(10, 81);
            this.percentIncrease.Name = "percentIncrease";
            this.percentIncrease.Size = new System.Drawing.Size(107, 21);
            this.percentIncrease.TabIndex = 2;
            this.percentIncrease.Text = "+5% increase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Compared to last month";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Image = global::c_AccountingCashFlowSystem.Properties.Resources.increase;
            this.label4.Location = new System.Drawing.Point(61, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(13, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total revenue this month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(13, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "before deduction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(13, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Annual Net Income";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(13, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Annual Revenue";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(13, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Less Annual Expenses";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.CadetBlue;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.label10);
            this.roundedPanel2.Controls.Add(this.label11);
            this.roundedPanel2.Location = new System.Drawing.Point(263, 332);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(213, 100);
            this.roundedPanel2.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(13, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 21);
            this.label10.TabIndex = 3;
            this.label10.Text = "₱0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(12, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(157, 21);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total Gross Revenue";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.Location = new System.Drawing.Point(272, 339);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(213, 100);
            this.roundedPanel3.TabIndex = 10;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.Teal;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.Controls.Add(this.label12);
            this.roundedPanel5.Controls.Add(this.label13);
            this.roundedPanel5.Location = new System.Drawing.Point(491, 177);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(277, 255);
            this.roundedPanel5.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(153, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 21);
            this.label12.TabIndex = 3;
            this.label12.Text = "₱0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(12, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 21);
            this.label13.TabIndex = 2;
            this.label13.Text = "Total Net Income";
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel6.BorderRadius = 20;
            this.roundedPanel6.Location = new System.Drawing.Point(500, 184);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(277, 255);
            this.roundedPanel6.TabIndex = 12;
            // 
            // income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.roundedPanel6);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
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
            this.yearIncomePanel.ResumeLayout(false);
            this.yearIncomePanel.PerformLayout();
            this.monthIncomePanel.ResumeLayout(false);
            this.monthIncomePanel.PerformLayout();
            this.weekIncomePanel.ResumeLayout(false);
            this.weekIncomePanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel5.ResumeLayout(false);
            this.roundedPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel yearIncomePanel;
        private System.Windows.Forms.Label annualRevenue;
        private System.Windows.Forms.Label yearIncomeLabel;
        private RoundedPanel roundedPanel4;
        private RoundedPanel monthIncomePanel;
        private System.Windows.Forms.Label monthlyRevenue;
        private System.Windows.Forms.Label monthIncomeLabel;
        private RoundedPanel roundedPanel8;
        private RoundedPanel weekIncomePanel;
        private System.Windows.Forms.Label totalSalesData;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListView listViewIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label percentIncrease;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private RoundedPanel roundedPanel6;
    }
}