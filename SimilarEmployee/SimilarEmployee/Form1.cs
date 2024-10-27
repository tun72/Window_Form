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

namespace SimilarEmployee
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        

        private void btnInsert_Click(object sender, EventArgs e)
        {
           

            Regex rex = new Regex(@"[a-zA-Z]+@[a-zA-Z]+.com$");
            Regex rex1 = new Regex(@"^(09)[0-9]{9}$");
            bool isValid = rex.IsMatch(txtEmail.Text);
            bool isValid1 = rex1.IsMatch(txtPhno.Text);

            
            if (!(isValid))
            {
                MessageBox.Show("Email is invalid");
            }

            if (!(isValid1))
            {
                MessageBox.Show("Phone is invalid");
            }

            if (isValid && isValid1  && txtName.Text != "" && txtAddress.Text !="" && txtDepartment.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\SimilarEmployee\SimilarEmployee\Employee.mdf';Integrated Security=True;Connect Timeout=30");
                con.Open();
                try {
                    string str = @"Insert into Employee (name, email, department, address, phno) values ('" + txtName.Text + "', '" + txtEmail.Text  + "', '" + txtDepartment.Text  + "', '" + txtAddress.Text + "', '" + txtPhno.Text +"' ) ";
                    SqlCommand cmd = new SqlCommand(str, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insert Sucessfully");
                        Show();
                        txtName.Text = "";
                        txtEmail.Text = "";
                        txtDepartment.Text = "";
                        txtPhno.Text = "";
                        txtAddress.Text = "";
                        Show();
                }
                catch(SqlException error ) {
                         MessageBox.Show(error.Message);
                }
                catch(Exception error){
                    MessageBox.Show(error.Message);
                } finally {
                    con.Close();
                }

            } else {
                MessageBox.Show("Please check your data");
            }


        }

         public void Show()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\SimilarEmployee\SimilarEmployee\Employee.mdf';Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void txtPhno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtPhno.Text = txtPhno.Text.Remove(txtPhno.Text.Length - 1);
            }
            if (txtPhno.Text.Length > 11)
            {
                MessageBox.Show("no more than 11 numbers");
                txtPhno.Text = txtPhno.Text.Remove(txtPhno.Text.Length - 1); ;
                txtPhno.Focus();
            }
        }

       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MessageBox.Show("Alert");
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    dataGridView1.CurrentRow.Selected = true;
                    txtEmpId.Text = dataGridView1.Rows[e.RowIndex].Cells["emp_Id"].Value.ToString();
                    txtName.Text = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["email"].Value.ToString();
                    txtDepartment.Text = dataGridView1.Rows[e.RowIndex].Cells["department"].Value.ToString();
                    txtPhno.Text = dataGridView1.Rows[e.RowIndex].Cells["phno"].Value.ToString();
                    txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["address"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtEmpId.Text == "")
            {
                MessageBox.Show("Invalid Employee_Id");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\SimilarEmployee\SimilarEmployee\Employee.mdf';Integrated Security=True;Connect Timeout=30");

                con.Open();
                try
                {
                    String upd = "update Employee set name = '" + txtName.Text + "',email = '" + txtEmail.Text + "',department = '" + txtDepartment.Text + "' ,phno = '" + txtPhno.Text + "',address = '" + txtAddress.Text + "' where emp_Id='" + txtEmpId.Text + "'";
                    SqlCommand cmd = new SqlCommand(upd, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Sucessfully");
                    txtEmpId.Text = "";
                    txtName.Text = "";
                    txtEmail.Text = "";
                    txtDepartment.Text = "";
                    txtPhno.Text = "";
                    txtAddress.Text = "";
                    Show();
                }


                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }

        }

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {


        }  

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
            btnUpdate.Visible = true;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\SimilarEmployee\SimilarEmployee\Employee.mdf';Integrated Security=True;Connect Timeout=30");
            
           
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "Select * from Employee where emp_Id='" + txtEmpId.Text + "'";

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtName.Text = (dr["name"].ToString());
                txtEmail.Text = (dr["email"].ToString());
                txtDepartment.Text = (dr["department"].ToString());
                txtPhno.Text = (dr["phno"].ToString());
                txtAddress.Text = (dr["address"]).ToString();
            }
            else
            {
                txtName.Text = "";
                txtEmail.Text = "";
                txtDepartment.Text = "";
                txtPhno.Text = "";
                txtAddress.Text = "";
                MessageBox.Show("Invalid Employee Id!");
                txtEmpId.Text = "";
            }
            con.Close();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            Show();
        }

        private void txtEmpId_TextChanged_1(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Text = "";
            txtDepartment.Text = "";
            txtPhno.Text = "";
            btnDelete.Visible = false;
            btnUpdate.Visible = false;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if ((txtEmpId.Text != ""))
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\SimilarEmployee\SimilarEmployee\Employee.mdf';Integrated Security=True;Connect Timeout=30");

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
            Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
