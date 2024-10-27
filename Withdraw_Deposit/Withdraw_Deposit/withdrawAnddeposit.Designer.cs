namespace Withdraw_Deposit
{
    partial class withdrawAnddeposit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWithdrawl = new System.Windows.Forms.TabPage();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtWithdrawlAmt = new System.Windows.Forms.TextBox();
            this.txtWithdrawlBalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDeposit = new System.Windows.Forms.TabPage();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.txtBalanceDeposit = new System.Windows.Forms.TextBox();
            this.txtDepositAmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tbWithdrawl.SuspendLayout();
            this.tbDeposit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWithdrawl);
            this.tabControl1.Controls.Add(this.tbDeposit);
            this.tabControl1.Location = new System.Drawing.Point(81, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 498);
            this.tabControl1.TabIndex = 10;
            // 
            // tbWithdrawl
            // 
            this.tbWithdrawl.Controls.Add(this.btnWithdraw);
            this.tbWithdrawl.Controls.Add(this.txtWithdrawlAmt);
            this.tbWithdrawl.Controls.Add(this.txtWithdrawlBalance);
            this.tbWithdrawl.Controls.Add(this.label3);
            this.tbWithdrawl.Controls.Add(this.label2);
            this.tbWithdrawl.Controls.Add(this.label1);
            this.tbWithdrawl.Location = new System.Drawing.Point(4, 29);
            this.tbWithdrawl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWithdrawl.Name = "tbWithdrawl";
            this.tbWithdrawl.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWithdrawl.Size = new System.Drawing.Size(578, 465);
            this.tbWithdrawl.TabIndex = 0;
            this.tbWithdrawl.Text = "Withdraw";
            this.tbWithdrawl.UseVisualStyleBackColor = true;
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.Location = new System.Drawing.Point(204, 363);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(112, 35);
            this.btnWithdraw.TabIndex = 6;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtWithdrawlAmt
            // 
            this.txtWithdrawlAmt.Location = new System.Drawing.Point(204, 242);
            this.txtWithdrawlAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWithdrawlAmt.Name = "txtWithdrawlAmt";
            this.txtWithdrawlAmt.Size = new System.Drawing.Size(148, 26);
            this.txtWithdrawlAmt.TabIndex = 5;
            // 
            // txtWithdrawlBalance
            // 
            this.txtWithdrawlBalance.Location = new System.Drawing.Point(204, 145);
            this.txtWithdrawlBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWithdrawlBalance.Name = "txtWithdrawlBalance";
            this.txtWithdrawlBalance.ReadOnly = true;
            this.txtWithdrawlBalance.Size = new System.Drawing.Size(148, 26);
            this.txtWithdrawlBalance.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Withdraw Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Balance:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Withdraw Money";
            // 
            // tbDeposit
            // 
            this.tbDeposit.Controls.Add(this.btnDeposit);
            this.tbDeposit.Controls.Add(this.txtBalanceDeposit);
            this.tbDeposit.Controls.Add(this.txtDepositAmt);
            this.tbDeposit.Controls.Add(this.label6);
            this.tbDeposit.Controls.Add(this.label5);
            this.tbDeposit.Controls.Add(this.label4);
            this.tbDeposit.Location = new System.Drawing.Point(4, 29);
            this.tbDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDeposit.Name = "tbDeposit";
            this.tbDeposit.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDeposit.Size = new System.Drawing.Size(578, 465);
            this.tbDeposit.TabIndex = 1;
            this.tbDeposit.Text = "Deposit";
            this.tbDeposit.UseVisualStyleBackColor = true;
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(218, 354);
            this.btnDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(112, 35);
            this.btnDeposit.TabIndex = 8;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // txtBalanceDeposit
            // 
            this.txtBalanceDeposit.Location = new System.Drawing.Point(218, 143);
            this.txtBalanceDeposit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBalanceDeposit.Name = "txtBalanceDeposit";
            this.txtBalanceDeposit.ReadOnly = true;
            this.txtBalanceDeposit.Size = new System.Drawing.Size(148, 26);
            this.txtBalanceDeposit.TabIndex = 4;
            // 
            // txtDepositAmt
            // 
            this.txtDepositAmt.Location = new System.Drawing.Point(218, 234);
            this.txtDepositAmt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepositAmt.Name = "txtDepositAmt";
            this.txtDepositAmt.Size = new System.Drawing.Size(148, 26);
            this.txtDepositAmt.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Deposit Amount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Balance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(232, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Deposit Money";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 543);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // withdrawAnddeposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 620);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnClose);
            this.Name = "withdrawAnddeposit";
            this.Text = "withdrawAnddeposit";
            this.Load += new System.EventHandler(this.withdrawAnddeposit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbWithdrawl.ResumeLayout(false);
            this.tbWithdrawl.PerformLayout();
            this.tbDeposit.ResumeLayout(false);
            this.tbDeposit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbWithdrawl;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtWithdrawlAmt;
        private System.Windows.Forms.TextBox txtWithdrawlBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbDeposit;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.TextBox txtBalanceDeposit;
        private System.Windows.Forms.TextBox txtDepositAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
    }
}