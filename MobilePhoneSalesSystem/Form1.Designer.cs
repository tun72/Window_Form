namespace MobilePhoneSalesSystem
{
    partial class MobileSalesEntry
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboBrandName = new ComboBox();
            cboModel = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnUpdateAndDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // cboBrandName
            // 
            cboBrandName.FormattingEnabled = true;
            cboBrandName.Items.AddRange(new object[] { "Apple", "Samsung", "Huawei" });
            cboBrandName.Location = new Point(172, 50);
            cboBrandName.Name = "cboBrandName";
            cboBrandName.Size = new Size(181, 23);
            cboBrandName.TabIndex = 0;
            cboBrandName.SelectedIndexChanged += cboBrandName_SelectedIndexChanged;
            // 
            // cboModel
            // 
            cboModel.FormattingEnabled = true;
            cboModel.Location = new Point(172, 115);
            cboModel.Name = "cboModel";
            cboModel.Size = new Size(181, 23);
            cboModel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 52);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 2;
            label1.Text = "Brand Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(44, 117);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 3;
            label2.Text = "Model";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(172, 181);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(181, 23);
            txtPrice.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(172, 251);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(181, 23);
            txtQuantity.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 183);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 6;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 253);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = "Quantity";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(154, 327);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 36);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdateAndDelete
            // 
            btnUpdateAndDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateAndDelete.Location = new Point(507, 106);
            btnUpdateAndDelete.Name = "btnUpdateAndDelete";
            btnUpdateAndDelete.Size = new Size(177, 35);
            btnUpdateAndDelete.TabIndex = 9;
            btnUpdateAndDelete.Text = "Update And Delete";
            btnUpdateAndDelete.UseVisualStyleBackColor = true;
            btnUpdateAndDelete.Click += btnUpdateAndDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(507, 176);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(177, 35);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // MobileSalesEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnUpdateAndDelete);
            Controls.Add(btnSave);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboModel);
            Controls.Add(cboBrandName);
            Name = "MobileSalesEntry";
            Text = "Mobile Sales Entry";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboBrandName;
        private ComboBox cboModel;
        private Label label1;
        private Label label2;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnUpdateAndDelete;
        private Button btnExit;
    }
}
