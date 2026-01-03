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
            this.panel4 = new System.Windows.Forms.Panel();
            this.listViewOperational = new System.Windows.Forms.ListView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.monthLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewExpensesSumarry = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.expenseSummary = new System.Windows.Forms.Label();
            this.roundedPanel3 = new RoundedPanel();
            this.addExpensesBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.roundedPanel5 = new RoundedPanel();
            this.roundedPanel1 = new RoundedPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.roundedPanel2 = new RoundedPanel();
            this.yearIncomePanel = new RoundedPanel();
            this.asOfNowTotalExpense = new System.Windows.Forms.Label();
            this.annualExpenses = new System.Windows.Forms.Label();
            this.yearIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel4 = new RoundedPanel();
            this.monthIncomePanel = new RoundedPanel();
            this.roundedPanel6 = new RoundedPanel();
            this.yearLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.expenseCheck = new System.Windows.Forms.Label();
            this.monthlyExpenses = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.monthIncomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel8 = new RoundedPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            this.roundedPanel1.SuspendLayout();
            this.yearIncomePanel.SuspendLayout();
            this.monthIncomePanel.SuspendLayout();
            this.roundedPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 352);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.listViewOperational);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(246, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(15);
            this.panel4.Size = new System.Drawing.Size(272, 352);
            this.panel4.TabIndex = 19;
            // 
            // listViewOperational
            // 
            this.listViewOperational.Dock = System.Windows.Forms.DockStyle.Top;
            this.listViewOperational.HideSelection = false;
            this.listViewOperational.Location = new System.Drawing.Point(15, 57);
            this.listViewOperational.Name = "listViewOperational";
            this.listViewOperational.Size = new System.Drawing.Size(242, 277);
            this.listViewOperational.TabIndex = 1;
            this.listViewOperational.UseCompatibleStateImageBehavior = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.monthLabel);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(15, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 42);
            this.panel5.TabIndex = 0;
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.monthLabel.Location = new System.Drawing.Point(136, 11);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(68, 20);
            this.monthLabel.TabIndex = 7;
            this.monthLabel.Text = "- January";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monthly Expenses";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCyan;
            this.panel2.Controls.Add(this.listViewExpensesSumarry);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(246, 352);
            this.panel2.TabIndex = 18;
            // 
            // listViewExpensesSumarry
            // 
            this.listViewExpensesSumarry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewExpensesSumarry.HideSelection = false;
            this.listViewExpensesSumarry.Location = new System.Drawing.Point(15, 57);
            this.listViewExpensesSumarry.Name = "listViewExpensesSumarry";
            this.listViewExpensesSumarry.Size = new System.Drawing.Size(216, 280);
            this.listViewExpensesSumarry.TabIndex = 20;
            this.listViewExpensesSumarry.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.expenseSummary);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(15, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 42);
            this.panel3.TabIndex = 19;
            // 
            // expenseSummary
            // 
            this.expenseSummary.AutoSize = true;
            this.expenseSummary.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseSummary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.expenseSummary.Location = new System.Drawing.Point(18, 11);
            this.expenseSummary.Name = "expenseSummary";
            this.expenseSummary.Size = new System.Drawing.Size(181, 20);
            this.expenseSummary.TabIndex = 5;
            this.expenseSummary.Text = "Expenses Summary - 2026";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.Teal;
            this.roundedPanel3.BorderRadius = 20;
            this.roundedPanel3.Controls.Add(this.addExpensesBtn);
            this.roundedPanel3.Controls.Add(this.label9);
            this.roundedPanel3.Location = new System.Drawing.Point(536, 365);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(237, 58);
            this.roundedPanel3.TabIndex = 16;
            // 
            // addExpensesBtn
            // 
            this.addExpensesBtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.addExpensesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addExpensesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addExpensesBtn.FlatAppearance.BorderSize = 0;
            this.addExpensesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addExpensesBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addExpensesBtn.ForeColor = System.Drawing.Color.Black;
            this.addExpensesBtn.Location = new System.Drawing.Point(0, 0);
            this.addExpensesBtn.Name = "addExpensesBtn";
            this.addExpensesBtn.Size = new System.Drawing.Size(237, 58);
            this.addExpensesBtn.TabIndex = 5;
            this.addExpensesBtn.Text = "Add Expenses";
            this.addExpensesBtn.UseVisualStyleBackColor = false;
            this.addExpensesBtn.Click += new System.EventHandler(this.addExpensesBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Image = global::c_AccountingCashFlowSystem.Properties.Resources.increase;
            this.label9.Location = new System.Drawing.Point(61, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 21);
            this.label9.TabIndex = 4;
            // 
            // roundedPanel5
            // 
            this.roundedPanel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel5.BorderRadius = 20;
            this.roundedPanel5.Location = new System.Drawing.Point(545, 372);
            this.roundedPanel5.Name = "roundedPanel5";
            this.roundedPanel5.Size = new System.Drawing.Size(237, 58);
            this.roundedPanel5.TabIndex = 15;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.roundedPanel1.BorderRadius = 20;
            this.roundedPanel1.Controls.Add(this.label1);
            this.roundedPanel1.Controls.Add(this.label2);
            this.roundedPanel1.Controls.Add(this.label7);
            this.roundedPanel1.Location = new System.Drawing.Point(264, 12);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(251, 61);
            this.roundedPanel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(118, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = " - Overall";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "₱100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(16, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total Expenses";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel2.BorderRadius = 20;
            this.roundedPanel2.Location = new System.Drawing.Point(273, 19);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(251, 61);
            this.roundedPanel2.TabIndex = 14;
            // 
            // yearIncomePanel
            // 
            this.yearIncomePanel.BackColor = System.Drawing.Color.PaleTurquoise;
            this.yearIncomePanel.BorderRadius = 20;
            this.yearIncomePanel.Controls.Add(this.asOfNowTotalExpense);
            this.yearIncomePanel.Controls.Add(this.annualExpenses);
            this.yearIncomePanel.Controls.Add(this.yearIncomeLabel);
            this.yearIncomePanel.Location = new System.Drawing.Point(12, 12);
            this.yearIncomePanel.Name = "yearIncomePanel";
            this.yearIncomePanel.Size = new System.Drawing.Size(237, 61);
            this.yearIncomePanel.TabIndex = 13;
            // 
            // asOfNowTotalExpense
            // 
            this.asOfNowTotalExpense.AutoSize = true;
            this.asOfNowTotalExpense.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asOfNowTotalExpense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.asOfNowTotalExpense.Location = new System.Drawing.Point(12, 32);
            this.asOfNowTotalExpense.Name = "asOfNowTotalExpense";
            this.asOfNowTotalExpense.Size = new System.Drawing.Size(112, 19);
            this.asOfNowTotalExpense.TabIndex = 4;
            this.asOfNowTotalExpense.Text = "As of Jan. (2026)";
            // 
            // annualExpenses
            // 
            this.annualExpenses.AutoSize = true;
            this.annualExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annualExpenses.ForeColor = System.Drawing.SystemColors.ControlText;
            this.annualExpenses.Location = new System.Drawing.Point(134, 11);
            this.annualExpenses.Name = "annualExpenses";
            this.annualExpenses.Size = new System.Drawing.Size(47, 21);
            this.annualExpenses.TabIndex = 3;
            this.annualExpenses.Text = "₱100";
            // 
            // yearIncomeLabel
            // 
            this.yearIncomeLabel.AutoSize = true;
            this.yearIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearIncomeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.yearIncomeLabel.Location = new System.Drawing.Point(12, 11);
            this.yearIncomeLabel.Name = "yearIncomeLabel";
            this.yearIncomeLabel.Size = new System.Drawing.Size(116, 21);
            this.yearIncomeLabel.TabIndex = 2;
            this.yearIncomeLabel.Text = "Total Expenses";
            // 
            // roundedPanel4
            // 
            this.roundedPanel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel4.BorderRadius = 20;
            this.roundedPanel4.Location = new System.Drawing.Point(21, 19);
            this.roundedPanel4.Name = "roundedPanel4";
            this.roundedPanel4.Size = new System.Drawing.Size(237, 61);
            this.roundedPanel4.TabIndex = 11;
            // 
            // monthIncomePanel
            // 
            this.monthIncomePanel.BackColor = System.Drawing.Color.Teal;
            this.monthIncomePanel.BorderRadius = 20;
            this.monthIncomePanel.Controls.Add(this.roundedPanel6);
            this.monthIncomePanel.Controls.Add(this.label10);
            this.monthIncomePanel.Controls.Add(this.label4);
            this.monthIncomePanel.Controls.Add(this.monthIncomeLabel);
            this.monthIncomePanel.Location = new System.Drawing.Point(536, 12);
            this.monthIncomePanel.Name = "monthIncomePanel";
            this.monthIncomePanel.Size = new System.Drawing.Size(237, 153);
            this.monthIncomePanel.TabIndex = 14;
            // 
            // roundedPanel6
            // 
            this.roundedPanel6.BackColor = System.Drawing.Color.Teal;
            this.roundedPanel6.BorderRadius = 20;
            this.roundedPanel6.Controls.Add(this.yearLabel);
            this.roundedPanel6.Controls.Add(this.label11);
            this.roundedPanel6.Controls.Add(this.label12);
            this.roundedPanel6.Controls.Add(this.expenseCheck);
            this.roundedPanel6.Controls.Add(this.monthlyExpenses);
            this.roundedPanel6.Controls.Add(this.label15);
            this.roundedPanel6.Location = new System.Drawing.Point(8, 8);
            this.roundedPanel6.Name = "roundedPanel6";
            this.roundedPanel6.Size = new System.Drawing.Size(237, 148);
            this.roundedPanel6.TabIndex = 15;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.ForeColor = System.Drawing.Color.Yellow;
            this.yearLabel.Location = new System.Drawing.Point(126, 108);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(33, 19);
            this.yearLabel.TabIndex = 6;
            this.yearLabel.Text = "Jan.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(15, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 19);
            this.label11.TabIndex = 5;
            this.label11.Text = "for this month of ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Image = global::c_AccountingCashFlowSystem.Properties.Resources.increase;
            this.label12.Location = new System.Drawing.Point(61, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 21);
            this.label12.TabIndex = 4;
            // 
            // expenseCheck
            // 
            this.expenseCheck.AutoSize = true;
            this.expenseCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expenseCheck.ForeColor = System.Drawing.Color.Yellow;
            this.expenseCheck.Location = new System.Drawing.Point(15, 89);
            this.expenseCheck.Name = "expenseCheck";
            this.expenseCheck.Size = new System.Drawing.Size(195, 19);
            this.expenseCheck.TabIndex = 3;
            this.expenseCheck.Text = "Expenses are not currently set";
            // 
            // monthlyExpenses
            // 
            this.monthlyExpenses.AutoSize = true;
            this.monthlyExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyExpenses.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.monthlyExpenses.Location = new System.Drawing.Point(15, 40);
            this.monthlyExpenses.Name = "monthlyExpenses";
            this.monthlyExpenses.Size = new System.Drawing.Size(75, 21);
            this.monthlyExpenses.TabIndex = 2;
            this.monthlyExpenses.Text = "₱0 (Jan.)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label15.Location = new System.Drawing.Point(12, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "Monthly Expenses";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(15, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 19);
            this.label10.TabIndex = 5;
            this.label10.Text = "for this month of ";
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
            // monthIncomeLabel
            // 
            this.monthIncomeLabel.AutoSize = true;
            this.monthIncomeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthIncomeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.monthIncomeLabel.Location = new System.Drawing.Point(12, 15);
            this.monthIncomeLabel.Name = "monthIncomeLabel";
            this.monthIncomeLabel.Size = new System.Drawing.Size(163, 25);
            this.monthIncomeLabel.TabIndex = 1;
            this.monthIncomeLabel.Text = "Monthly Expenses";
            // 
            // roundedPanel8
            // 
            this.roundedPanel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.roundedPanel8.BorderRadius = 20;
            this.roundedPanel8.Location = new System.Drawing.Point(545, 19);
            this.roundedPanel8.Name = "roundedPanel8";
            this.roundedPanel8.Size = new System.Drawing.Size(237, 153);
            this.roundedPanel8.TabIndex = 12;
            // 
            // expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.yearIncomePanel);
            this.Controls.Add(this.roundedPanel4);
            this.Controls.Add(this.monthIncomePanel);
            this.Controls.Add(this.roundedPanel8);
            this.Name = "expenses";
            this.Text = "expenses";
            this.Load += new System.EventHandler(this.expenses_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            this.roundedPanel3.PerformLayout();
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.yearIncomePanel.ResumeLayout(false);
            this.yearIncomePanel.PerformLayout();
            this.monthIncomePanel.ResumeLayout(false);
            this.monthIncomePanel.PerformLayout();
            this.roundedPanel6.ResumeLayout(false);
            this.roundedPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedPanel yearIncomePanel;
        private System.Windows.Forms.Label asOfNowTotalExpense;
        private System.Windows.Forms.Label annualExpenses;
        private System.Windows.Forms.Label yearIncomeLabel;
        private RoundedPanel roundedPanel4;
        private RoundedPanel monthIncomePanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label monthIncomeLabel;
        private RoundedPanel roundedPanel8;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private RoundedPanel roundedPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView listViewExpensesSumarry;
        private System.Windows.Forms.Label expenseSummary;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listViewOperational;
        private System.Windows.Forms.Label monthLabel;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Button addExpensesBtn;
        private System.Windows.Forms.Label label9;
        private RoundedPanel roundedPanel5;
        private System.Windows.Forms.Label label10;
        private RoundedPanel roundedPanel6;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label expenseCheck;
        private System.Windows.Forms.Label monthlyExpenses;
        private System.Windows.Forms.Label label15;
    }
}