namespace MobilePhoneSalesSystem
{
    partial class UpdateAndDelete
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
            btnBack = new Button();
            txtSaleID = new TextBox();
            txtBrandName = new TextBox();
            txtModel = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 33);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtSaleID
            // 
            txtSaleID.Location = new Point(341, 65);
            txtSaleID.Name = "txtSaleID";
            txtSaleID.Size = new Size(205, 23);
            txtSaleID.TabIndex = 1;
            // 
            // txtBrandName
            // 
            txtBrandName.Location = new Point(341, 124);
            txtBrandName.Name = "txtBrandName";
            txtBrandName.Size = new Size(205, 23);
            txtBrandName.TabIndex = 2;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(341, 185);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(205, 23);
            txtModel.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(341, 246);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(205, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(341, 307);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(205, 23);
            txtQuantity.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(212, 67);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 6;
            label1.Text = "Sale ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(212, 126);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 7;
            label2.Text = "Brand Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(212, 187);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 8;
            label3.Text = "Model";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(212, 248);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 9;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(212, 309);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 10;
            label5.Text = "Quantity";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(214, 382);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 35);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(471, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 35);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // UpdateAndDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtModel);
            Controls.Add(txtBrandName);
            Controls.Add(txtSaleID);
            Controls.Add(btnBack);
            Name = "UpdateAndDelete";
            Text = "Update And Delete";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private TextBox txtSaleID;
        private TextBox txtBrandName;
        private TextBox txtModel;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnUpdate;
        private Button btnDelete;
    }
}