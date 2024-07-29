using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
            {
                MessageBox.Show("Login Successfull");
                txtUsername.Clear();
                txtPassword.Clear();

            }
            else
            {
                MessageBox.Show("Please check username and password");
                txtUsername.Clear();
                txtPassword.Clear();
            }



                
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Clear();
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Clear();
            //txtPassword.PasswordChar = "*";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
