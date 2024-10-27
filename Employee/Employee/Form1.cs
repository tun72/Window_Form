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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Regex rex = new Regex(@"[a-zA-Z]+@[a-zA-Z]+.com$");
            Regex rex1 = new Regex(@"^(09)[0-9]{9}$");
            bool isValid = rex.IsMatch(txtEmail.Text);
            bool isValid1 = rex1.IsMatch(txtPhno.Text);
            if (!(isValid))
            {
                MessageBox.Show("Please Check Email Address");
            }
            else if (!(isValid1))
            {
                MessageBox.Show("Please Check Phone Number");
            }
            else
            {

                if (txtName.Text != "" && txtEmail.Text != "" && txtDepartment.Text != "" && txtPhno.Text != "" && txtAddress.Text != "")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\Employee\Employee\EmployeeDB.mdf';Integrated Security=True");   
                    con.Open();
                    try
                    {
                        String str = @"Insert into Employee(name,email,department,phno,address) values ('" + txtName.Text + "','" + txtEmail.Text + "','" + txtDepartment.Text + "','" + txtPhno.Text + "','" + txtAddress.Text + "')";

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
                    catch (SqlException exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                    con.Close();


                    /*  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ASUS\Desktop\C#Lecture\Window Form Application\Employee\Employee\Employee\Employee.mdf;Integrated Security=True;");
                      con.Open();
                      string query = "select * from Employee";
                      SqlDataAdapter da = new SqlDataAdapter(query, con);
                      SqlCommandBuilder b = new SqlCommandBuilder(da);
                      DataSet ds = new DataSet();
                      da.Fill(ds, "Employee");
                      DataTable dt = new DataTable();
                      dt = ds.Tables["Employee"];
                      DataRow row = dt.NewRow();
                      row["name"]=txtname.Text;
                      row["email"] =txtemail.Text; ;
                      row["department"]=txtdepartment.Text;
                      row["phno"] =txtphno.Text;
                      row["address"]=txtaddress.Text;
                      dt.Rows.Add(row);
                      da.Update(ds, "Employee");
                      MessageBox.Show("Insert Sucessfully");
                      Show();
                      con.Close();*/
                }

                else
                {
                    MessageBox.Show("Please check your data!");
                }
            }






        }

        public void Show()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\New folder (2)\Employee\Employee\EmployeeDB.mdf';Integrated Security=True");   
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Employee", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit ?", "Confoirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Insert_Load(object sender, EventArgs e)
        {
            Show();
        }

        private void txtphno_TextChanged(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Update_Employee ue = new Update_Employee();
            ue.Show();
            
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Employee de = new Delete_Employee();
            de.Show();
          
        }
    }
}
