using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExanResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt1.Text != "" && txt2.Text != "" && txt3.Text != "") {
                    Int64 mark1 = Int64.Parse(txt1.Text);
                    Int64 mark2 = Int64.Parse(txt2.Text);
                    Int64 mark3 = Int64.Parse(txt3.Text);

                    if (mark1 >= 50 && mark2 >= 50 && mark3 >= 50)
                    {
                        MessageBox.Show("Result is" + "\n" + "\n" + "Pass");
                    }
                    else {
                        MessageBox.Show("Result is" + "\n" + "\n" + "Fail");
                    }
                    txt1.Clear();
                    txt2.Clear();
                    txt3.Clear();

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
