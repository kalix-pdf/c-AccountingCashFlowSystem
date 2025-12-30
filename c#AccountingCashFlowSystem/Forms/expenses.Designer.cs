namespace c_AccountingCashFlowSystem.Forms
{
    partial class expenses
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
            this.panel15 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.roundedPanel4 = new RoundedPanel();
            this.totalExpenseData = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPanel5 = new RoundedPanel();
            this.roundedPanel2 = new RoundedPanel();
            this.yearlyExpenseData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roundedPanel3 = new RoundedPanel();
            this.totalIncomePanel = new RoundedPanel();
            this.monthExpenseData = new System.Windows.Forms.Label();
            this.totalIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel1 = new RoundedPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.expense4 = new System.Windows.Forms.NumericUpDown();
            this.panel11 = new System.Windows.Forms.Panel();
            this.expense3 = new System.Windows.Forms.NumericUpDown();
            this.panel8 = new System.Windows.Forms.Panel();
            this.expense2 = new System.Windows.Forms.NumericUpDown();
            this.panel9 = new System.Windows.Forms.Panel();
            this.expense1 = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel14.SuspendLayout();
            this.roundedPanel4.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.totalIncomePanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense4)).BeginInit();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense3)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense2)).BeginInit();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expense1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(21);
            this.panel1.Size = new System.Drawing.Size(806, 416);
            this.panel1.TabIndex = 10;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.panel15.Controls.Add(this.button1);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(21, 288);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(764, 55);
            this.panel15.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(764, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Expense";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel14);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(21, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 267);
            this.panel3.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel14.Controls.Add(this.roundedPanel4);
            this.panel14.Controls.Add(this.roundedPanel5);
            this.panel14.Controls.Add(this.roundedPanel2);
            this.panel14.Controls.Add(this.roundedPanel3);
            this.panel14.Controls.Add(this.totalIncomePanel);
            this.panel14.Controls.Add(this.roundedPanel1);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(379, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(385, 267);
            this.panel14.TabIndex = 10;
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.Teal;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Controls.Add(this.totalExpenseData);
            this.roundedPanel4.Controls.Add(this.label9);
            this.roundedPanel4.Location = new System.Drawing.Point(38, 183);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(305, 63);
            this.roundedPanel4.TabIndex = 9;
            // 
            // totalExpenseData
            // 
            this.totalExpenseData.AutoSize = true;
            this.totalExpenseData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalExpenseData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalExpenseData.Location = new System.Drawing.Point(160, 19);
            this.totalExpenseData.Name = "totalExpenseData";
            this.totalExpenseData.Size = new System.Drawing.Size(29, 21);
            this.totalExpenseData.TabIndex = 1;
            this.totalExpenseData.Text = "₱0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(12, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Expenses";
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.Location = new System.Drawing.Point(47, 190);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(305, 63);
            this.roundedPanel5.TabIndex = 8;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.Teal;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Controls.Add(this.yearlyExpenseData);
            this.roundedPanel2.Controls.Add(this.label7);
            this.roundedPanel2.Location = new System.Drawing.Point(38, 100);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(305, 63);
            this.roundedPanel2.TabIndex = 7;
            // 
            // yearlyExpenseData
            // 
            this.yearlyExpenseData.AutoSize = true;
            this.yearlyExpenseData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearlyExpenseData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.yearlyExpenseData.Location = new System.Drawing.Point(160, 19);
            this.yearlyExpenseData.Name = "yearlyExpenseData";
            this.yearlyExpenseData.Size = new System.Drawing.Size(29, 21);
            this.yearlyExpenseData.TabIndex = 1;
            this.yearlyExpenseData.Text = "₱0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(12, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yearly Expenses";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.Location = new System.Drawing.Point(47, 107);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(305, 63);
            this.roundedPanel3.TabIndex = 6;
            // 
            // totalIncomePanel
            // 
            this.totalIncomePanel.BackColor = System.Drawing.Color.Teal;
            this.totalIncomePanel.BorderRadius = 20;
            this.totalIncomePanel.Controls.Add(this.monthExpenseData);
            this.totalIncomePanel.Controls.Add(this.totalIncomeLabel);
            this.totalIncomePanel.Location = new System.Drawing.Point(38, 17);
            this.totalIncomePanel.Name = "totalIncomePanel";
            this.totalIncomePanel.Size = new System.Drawing.Size(305, 63);
            this.totalIncomePanel.TabIndex = 5;
            // 
            // monthExpenseData
            // 
            this.monthExpenseData.AutoSize = true;
            this.monthExpenseData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthExpenseData.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.monthExpenseData.Location = new System.Drawing.Point(160, 19);
            this.monthExpenseData.Name = "monthExpenseData";
            this.monthExpenseData.Size = new System.Drawing.Size(29, 21);
            this.monthExpenseData.TabIndex = 1;
            this.monthExpenseData.Text = "₱0";
            // 
            // totalIncomeLabel
            // 
            this.totalIncomeLabel.AutoSize = true;
            this.totalIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.totalIncomeLabel.Location = new System.Drawing.Point(12, 19);
            this.totalIncomeLabel.Name = "totalIncomeLabel";
            this.totalIncomeLabel.Size = new System.Drawing.Size(142, 21);
            this.totalIncomeLabel.TabIndex = 0;
            this.totalIncomeLabel.Text = "Monthly Expenses";
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Location = new System.Drawing.Point(47, 24);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(305, 63);
            this.roundedPanel1.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.Controls.Add(this.panel13);
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(189, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(190, 267);
            this.panel6.TabIndex = 9;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Teal;
            this.panel13.Controls.Add(this.expense4);
            this.panel13.Location = new System.Drawing.Point(0, 199);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(189, 57);
            this.panel13.TabIndex = 6;
            // 
            // expense4
            // 
            this.expense4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.expense4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expense4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense4.ForeColor = System.Drawing.Color.Black;
            this.expense4.Location = new System.Drawing.Point(25, 15);
            this.expense4.Name = "expense4";
            this.expense4.Size = new System.Drawing.Size(120, 29);
            this.expense4.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Teal;
            this.panel11.Controls.Add(this.expense3);
            this.panel11.Location = new System.Drawing.Point(0, 136);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(189, 57);
            this.panel11.TabIndex = 5;
            // 
            // expense3
            // 
            this.expense3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.expense3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expense3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense3.ForeColor = System.Drawing.Color.Black;
            this.expense3.Location = new System.Drawing.Point(25, 15);
            this.expense3.Name = "expense3";
            this.expense3.Size = new System.Drawing.Size(120, 29);
            this.expense3.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Teal;
            this.panel8.Controls.Add(this.expense2);
            this.panel8.Location = new System.Drawing.Point(0, 73);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(189, 57);
            this.panel8.TabIndex = 4;
            // 
            // expense2
            // 
            this.expense2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.expense2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expense2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense2.ForeColor = System.Drawing.Color.Black;
            this.expense2.Location = new System.Drawing.Point(24, 15);
            this.expense2.Name = "expense2";
            this.expense2.Size = new System.Drawing.Size(120, 29);
            this.expense2.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Teal;
            this.panel9.Controls.Add(this.expense1);
            this.panel9.Location = new System.Drawing.Point(0, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(190, 57);
            this.panel9.TabIndex = 4;
            // 
            // expense1
            // 
            this.expense1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.expense1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.expense1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expense1.ForeColor = System.Drawing.Color.Black;
            this.expense1.Location = new System.Drawing.Point(25, 15);
            this.expense1.Name = "expense1";
            this.expense1.Size = new System.Drawing.Size(120, 29);
            this.expense1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(189, 267);
            this.panel4.TabIndex = 0;
            // 
            // expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 428);
            this.Controls.Add(this.panel1);
            this.Name = "expenses";
            this.Text = "expenses";
            this.Load += new System.EventHandler(this.expenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.roundedPanel4.ResumeLayout(false);
            this.roundedPanel4.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.totalIncomePanel.ResumeLayout(false);
            this.totalIncomePanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expense4)).EndInit();
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expense3)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expense2)).EndInit();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expense1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundedPanel totalIncomePanel;
        private System.Windows.Forms.Label monthExpenseData;
        private System.Windows.Forms.Label totalIncomeLabel;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.NumericUpDown expense1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.NumericUpDown expense4;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.NumericUpDown expense3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.NumericUpDown expense2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button button1;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Label yearlyExpenseData;
        private System.Windows.Forms.Label label7;
        private RoundedPanel roundedPanel3;
        private RoundedPanel roundedPanel4;
        private System.Windows.Forms.Label totalExpenseData;
        private System.Windows.Forms.Label label9;
        private RoundedPanel roundedPanel5;
    }
}