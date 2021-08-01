using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolMenagerment
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;
            if (username == "" && password == "")
            {
                lblMessage.Text = "សូមបញ្ចូលឈ្មោះ និង លេខសម្ងាត់";
            }
            else
            {
                if (txtusername.Text == "Ravy" && txtpassword.Text == "123")
                {
                    formhome frmFpsw = new formhome();
                    frmFpsw.Show();
                    this.Hide();
                }
                else
                {
                    lblMessage.Text = "ឈ្មោះ និង លេខសម្ងាត់មិនត្រឹមត្រូវ";
                }
            }



        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
