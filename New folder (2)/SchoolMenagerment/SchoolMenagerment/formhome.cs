using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SchoolMenagerment
{
    public partial class formhome : Form
    {
        OleDbConnection con = new OleDbConnection(@"");
        public formhome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formClass frmC = new formClass();
            frmC.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnregistor_Click(object sender, EventArgs e)
        {
            formRigistor frmRi = new formRigistor();
            frmRi.Show();
            
        }

        private void btnteacher_Click(object sender, EventArgs e)
        {
            formTeacher frmT = new formTeacher();
            frmT.Show();
        }

        private void btnstudent_Click(object sender, EventArgs e)
        {

        }
    }
}
