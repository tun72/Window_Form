using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentRecordForm
{
    public partial class StudentRecord : Form
    {
        public StudentRecord()
        {
            InitializeComponent();
        }

        private void StudentRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
               Application.Exit();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
        
            if (txtName. Text != "" && txtEmail. Text != "" && txtMajor.Text != "" &&
            txtState.Text != "") 
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\User\OneDrive - University of Computer Studies (Maubin)
                                                      \Desktop\New folder (2)\StudentRecordForm\StudentRecordForm\Student.mdf;Integrated Security=True;");
                con.Open();

                try {
            }
        }



       
    }
}
