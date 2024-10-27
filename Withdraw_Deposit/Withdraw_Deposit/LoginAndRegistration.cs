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

namespace Withdraw_Deposit
{
    public partial class LoginAndRegistration : Form
    {
        public LoginAndRegistration()
        {
            InitializeComponent();
        }

        private void LoginAndRegistration_Load(object sender, EventArgs e)
        {
            int id = 1;
            txtAcountNo1.Text = id.ToString();
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\Withdraw_Deposit\Withdraw_Deposit\Account.mdf"";Integrated Security=True;Connect Timeout=30");
            con1.Open();
            string str1 = @"select * from Account";
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                id = Convert.ToInt32(dr1[0]);
                id += 1;
                txtAcountNo1.Text = id.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccountNo.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\Withdraw_Deposit\Withdraw_Deposit\Account.mdf"";Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    string select = @"select Account_No,UserName,Password,Balance from Account where Account_No='" + txtAccountNo.Text + "' AND UserName='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'";
                    SqlCommand cmd = new SqlCommand(select, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() == true)
                    {
                        MessageBox.Show("Login Successful");
                        txtAccountNo.Text = "";
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        double balance = double.Parse(reader["Balance"].ToString());
                        int accno = int.Parse(reader["Account_No"].ToString());
                        withdrawAnddeposit wd = new withdrawAnddeposit(balance, accno);
                        this.Hide();
                        wd.Show();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed!!Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAcountNo1.Text = "";
                        txtUsername.Text = "";
                        txtPassword.Text = "";

                    }

                    con.Close();
                }

                else
                {
                    MessageBox.Show("Please check Your Data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            int id = 1;
            txtAccountNo.Text = id.ToString();
            SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\Withdraw_Deposit\Withdraw_Deposit\Account.mdf"";Integrated Security=True;Connect Timeout=30");

            con1.Open();
            string str1 = @"select * from Account";
            SqlCommand cmd1 = new SqlCommand(str1, con1);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                id = Convert.ToInt32(dr1[0]);
                id += 1;
                txtAccountNo.Text = id.ToString();
            }
            if (txtUN.Text != "" && txtPwd.Text != "" && txtCPwd.Text != "" && txtBalance.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\Withdraw_Deposit\Withdraw_Deposit\Account.mdf"";Integrated Security=True;Connect Timeout=30");
                con.Open();
                try
                {
                    String str = @"Insert into Account(Account_No,Username,Password,Confirm_Password,Balance) values ('" + txtAccountNo.Text + "','" + txtUN.Text + "','" + txtPwd.Text + "','" + txtCPwd.Text + "','" + txtBalance.Text + "')";
                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account_No: " + txtAccountNo.Text + "\nPassword: " + txtPwd.Text);
                    txtAccountNo.Text = "";
                    txtUN.Text = "";
                    txtPwd.Text = "";
                    txtCPwd.Text = "";
                    txtBalance.Text = "";
                    id += 1;
                    txtAcountNo1.Text = id.ToString();
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message);
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please check your data!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}



