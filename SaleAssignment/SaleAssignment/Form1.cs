using System.Data.SqlClient;

namespace MobilePhoneSalesSystem
{
    public partial class MobileSalesEntry : Form
    {
        public string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\DELL\\Documents\\MobilePhoneSales.mdf;Integrated Security=True;Connect Timeout=30";

        public MobileSalesEntry()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SalesInfo (BrandName, Model, Price, Quantity) VALUES ('" + cboBrandName.Text + "' , '" + cboModel.Text + "' , '" + Convert.ToDecimal(txtPrice.Text) + "' , '" + Convert.ToInt32(txtQuantity.Text) + "')";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Saved Successfully");
                cboBrandName.Text = "";
                cboModel.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
            }
        }

        private void cboBrandName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboModel.Items.Clear();
            string selectedBrand = cboBrandName.SelectedItem.ToString();

            switch (selectedBrand)
            {
                case "Apple":
                    cboModel.Items.Add("iPhone 13");
                    cboModel.Items.Add("iPhone 12");
                    cboModel.Items.Add("iPhone 11");
                    break;
                case "Samsung":
                    cboModel.Items.Add("Galaxy S21");
                    cboModel.Items.Add("Galaxy Note 20");
                    cboModel.Items.Add("Galaxy A52");
                    break;
                case "Huawei":
                    cboModel.Items.Add("P40 Pro");
                    cboModel.Items.Add("Mate 40 Pro");
                    cboModel.Items.Add("Nova 8");
                    break;
                default:
                    break;
            }
        }

        private void btnUpdateAndDelete_Click(object sender, EventArgs e)
        {
            UpdateAndDelete updateAndDeleteForm = new UpdateAndDelete();
            updateAndDeleteForm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
