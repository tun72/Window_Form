using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Employee
{
    public partial class Delete_Employee : Form
    {
        public Delete_Employee()
        {
            InitializeComponent();
        }

        private void Delete_Employee_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtEmpId.Text != ""))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\Employee\Employee\EmployeeDB.mdf';Integrated Security=True");   
                string str = "Delete from Employee where Emp_Id='" + this.txtEmpId.Text + "'";
                SqlCommand cmd = new SqlCommand(str, con);
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Delete Sucessfully");
                txtEmpId.Text = "";
                con.Close();
            }
            else
            {
                MessageBox.Show("Enter The Valid Emp_Id");
            }
            show();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert insert = new Insert();
            insert.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
        public void show()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\Employee\Employee\EmployeeDB.mdf';Integrated Security=True");   
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
