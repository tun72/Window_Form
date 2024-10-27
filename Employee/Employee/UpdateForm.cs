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
    public partial class Update_Employee : Form
    {
        public Update_Employee()
        {
            InitializeComponent();
        }

        private void Update_Employee_Load(object sender, EventArgs e)
        {
            show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\Employee\Employee\EmployeeDB.mdf';Integrated Security=True");            
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Employee where emp_Id='" + txtId.Text + "'";

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtname.Text = (dr["name"].ToString());
                txtemail.Text = (dr["email"].ToString());
                txtdepartment.Text = (dr["department"].ToString());
                txtphno.Text = (dr["phno"].ToString());
                txtaddress.Text = (dr["address"]).ToString();
            }
            else
            {
                txtname.Text = "";
                txtemail.Text = "";
                txtdepartment.Text = "";
                txtphno.Text = "";
                txtaddress.Text = "";
                MessageBox.Show("Invalid Employee Id!");
                txtId.Text = "";
            }
            con.Close();
        }

        public void show()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\Employee\Employee\EmployeeDB.mdf';Integrated Security=True");   
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Invalid Employee_Id");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\Employee\Employee\EmployeeDB.mdf';Integrated Security=True");   
                con.Open();
                try
                {
                    String upd = "update Employee set name = '" + txtname.Text + "',email = '" + txtemail.Text + "',department = '" + txtdepartment.Text + "' ,phno = '" + txtphno.Text + "',address = '" + txtaddress.Text + "' where emp_Id='" + txtId.Text + "'";
                    SqlCommand cmd = new SqlCommand(upd, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Sucessfully");
                    txtId.Text = "";
                    txtname.Text = "";
                    txtemail.Text = "";
                    txtdepartment.Text = "";
                    txtphno.Text = "";
                    txtaddress.Text = "";
                    show();
                }


                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            txtname.Clear();
            txtemail.Clear();
            txtaddress.Text = "";
            txtdepartment.Text = "";
            txtphno.Text = "";     
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dataGridView.CurrentRow.Selected = true;
                    txtId.Text = dataGridView.Rows[e.RowIndex].Cells["emp_Id"].Value.ToString();
                    txtname.Text = dataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    txtemail.Text = dataGridView.Rows[e.RowIndex].Cells["email"].Value.ToString();
                    txtdepartment.Text = dataGridView.Rows[e.RowIndex].Cells["department"].Value.ToString();
                    txtphno.Text = dataGridView.Rows[e.RowIndex].Cells["phno"].Value.ToString();
                    txtaddress.Text = dataGridView.Rows[e.RowIndex].Cells["address"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Insert insert = new Insert();
            insert.Show();
        }

        private void txtphno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtphno.Text, "[^0-9]"))
            {

                MessageBox.Show("Please enter only numbers.");
                txtphno.Text = txtphno.Text.Remove(txtphno.Text.Length - 1);
            }
            if (txtphno.Text.Length > 11)
            {
                MessageBox.Show("no more than 11 numbers");
                txtphno.Text = txtphno.Text.Remove(txtphno.Text.Length - 1); ;
                txtphno.Focus();
            }
        }
    }
}
