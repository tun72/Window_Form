using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilePhoneSalesSystem
{
    public partial class UpdateAndDelete : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\MobilePhoneSales.mdf;Integrated Security=True;Connect Timeout=30";
        public UpdateAndDelete()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MobileSalesEntry mobileSalesEntryForm = new MobileSalesEntry();
            mobileSalesEntryForm.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE SalesInfo SET BrandName = '" + txtBrandName.Text + "', Model = '" + txtModel.Text + "', Price = '" + Convert.ToDecimal(txtPrice.Text) + "', Quantity = '" + Convert.ToInt32(txtQuantity.Text) + "' WHERE SaleID = '" + Convert.ToInt32(txtSaleID.Text) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM SalesInfo WHERE SaleID = '" + Convert.ToInt32(txtSaleID.Text) + "'";
                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Deleted Successfully");
            }
        }
    }
}
