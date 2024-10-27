using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }


      

       
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void Registration_Load(object sender, EventArgs e)
        {
            cboYear.Items.Add("First Year");
            cboYear.Items.Add("Second Year");
            cboYear.Items.Add("Third Year");
            cboYear.Items.Add("Fourth Year");
            cboYear.Items.Add("Final Year");

            dtp1.CustomFormat = "dd-MM-yyyy";
        }

      

        private void btnInsert_Click(object sender, EventArgs e)
        {
            dtp1.Format = DateTimePickerFormat.Custom;
            dtp1.CustomFormat = "MM-dd-yyyy";
            String gender = string.Empty;

            if (rdoMale.Checked)
            {
                gender = "Male";
            }
            else if (rdoFemale.Checked)
            {
                gender = "Female";
            }

            if (txtId.Text != "" && txtName.Text != "" && cboYear.Text != "" && dtp1.Text != "" && txtAddress.Text != "")
            {
                MessageBox.Show("Id=" + txtId.Text + "\n" + "Name=" + txtName.Text + "\n" + "Gender=" + gender + "\n" + "Year=" + cboYear.Text + "\n" + "DOB=" + dtp1.Text + "\n" + "Address=" + txtAddress.Text + "\n");

            }
            else
            {
                MessageBox.Show("Please Enter Data Completely");

            }

            txtName.Clear();
            txtId.Clear();
            txtAddress.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
