namespace windowFormCheckBox
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
            this.cbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btnCombo = new System.Windows.Forms.Button();
            this.btnListBox = new System.Windows.Forms.Button();
            this.btnCheckListBox = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(44, 114);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(196, 24);
            this.cbo.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 15;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(44, 48);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(196, 22);
            this.txt.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnCheckListBox);
            this.panel1.Controls.Add(this.btnListBox);
            this.panel1.Controls.Add(this.btnCombo);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.checkedListBox);
            this.panel1.Controls.Add(this.listBox);
            this.panel1.Controls.Add(this.cbo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt);
            this.panel1.Location = new System.Drawing.Point(94, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 530);
            this.panel1.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(44, 370);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(196, 84);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Location = new System.Drawing.Point(44, 261);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(196, 89);
            this.checkedListBox.TabIndex = 27;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(44, 164);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(196, 84);
            this.listBox.TabIndex = 26;
            // 
            // btnCombo
            // 
            this.btnCombo.Location = new System.Drawing.Point(393, 108);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(184, 30);
            this.btnCombo.TabIndex = 32;
            this.btnCombo.Text = "Insert To ComboBox";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // btnListBox
            // 
            this.btnListBox.Location = new System.Drawing.Point(393, 218);
            this.btnListBox.Name = "btnListBox";
            this.btnListBox.Size = new System.Drawing.Size(184, 30);
            this.btnListBox.TabIndex = 33;
            this.btnListBox.Text = "Insert To List Box";
            this.btnListBox.UseVisualStyleBackColor = true;
            this.btnListBox.Click += new System.EventHandler(this.btnListBox_Click);
            // 
            // btnCheckListBox
            // 
            this.btnCheckListBox.Location = new System.Drawing.Point(393, 320);
            this.btnCheckListBox.Name = "btnCheckListBox";
            this.btnCheckListBox.Size = new System.Drawing.Size(184, 30);
            this.btnCheckListBox.TabIndex = 34;
            this.btnCheckListBox.Text = "Insert To check List Box";
            this.btnCheckListBox.UseVisualStyleBackColor = true;
            this.btnCheckListBox.Click += new System.EventHandler(this.btnCheckListBox_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(393, 424);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(184, 30);
            this.btnView.TabIndex = 35;
            this.btnView.Text = "View your choice";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 562);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnCheckListBox;
        private System.Windows.Forms.Button btnListBox;
        private System.Windows.Forms.Button btnCombo;
    }
}

