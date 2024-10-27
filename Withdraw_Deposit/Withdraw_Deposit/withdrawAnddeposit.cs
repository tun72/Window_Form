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
    public partial class withdrawAnddeposit : Form
    {
        int accountnumber_forUpdate;
        public withdrawAnddeposit(double b, int ac)
        {
            InitializeComponent();
            txtWithdrawlBalance.Text = b.ToString();
            txtBalanceDeposit.Text = b.ToString();
            accountnumber_forUpdate = ac;
        }

        private void withdrawAnddeposit_Load(object sender, EventArgs e)
        {

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\Withdraw_Deposit\Withdraw_Deposit\Account.mdf"";Integrated Security=True;Connect Timeout=30");

            con.Open();


            double wAmt = double.Parse(txtWithdrawlAmt.Text);
            double wBalance = double.Parse(txtWithdrawlBalance.Text);
            if (wBalance >= wAmt)
            {
                double totalbalance = wBalance - wAmt;

                string update = @"update Account set Balance='" + totalbalance + "' where Account_No='" + accountnumber_forUpdate + "'";
                SqlCommand cmd = new SqlCommand(update, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Withdrawl success");
                txtWithdrawlBalance.Text = totalbalance.ToString();
                txtBalanceDeposit.Text = totalbalance.ToString();
                con.Close();
                txtWithdrawlAmt.Clear();
            }
            else
            {
                MessageBox.Show("Withdrawl unavailable");
                txtWithdrawlAmt.Clear();
            }

        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=""C:\Users\User\OneDrive - University of Computer Studies (Maubin)\Desktop\Withdraw_Deposit\Withdraw_Deposit\Account.mdf"";Integrated Security=True;Connect Timeout=30");

            con.Open();
            double wAmt = double.Parse(txtDepositAmt.Text);
            double wBalance = double.Parse(txtBalanceDeposit.Text);
            double totalbalance = wBalance + wAmt;
            string update = @"update Account set Balance='" + totalbalance + "' where Account_No='" + accountnumber_forUpdate + "'";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deposit success");
            txtWithdrawlBalance.Text = totalbalance.ToString();
            txtBalanceDeposit.Text = totalbalance.ToString();
            con.Close();
            txtDepositAmt.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
