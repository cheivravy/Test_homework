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
    public partial class formTeacher : Form
    {
        public formTeacher()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int x;

        private void Rgirl_Enter(object sender, EventArgs e)
        {

        }

        private void formTeacher_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("TextID", typeof(string));
            dt.Columns.Add("TextFname", typeof(string));
            dt.Columns.Add("TextLname", typeof(string));
            dt.Columns.Add("textSex", typeof(string));
            dt.Columns.Add("DOB", typeof(DateTime));
            dt.Columns.Add("TextEmail", typeof(string));
            dt.Columns.Add("TextPhone", typeof(string));
            dt.Columns.Add("TextAddress", typeof(string));
            dataGridView1.DataSource = dt;
            
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            DateTime date = DOB.Value.Date;


            dt.Rows.Add(TextID.Text, TextFname.Text, TextLname.Text, textSex.Text, DOB.MinDate.ToString(),
               TextEmail.Text,TextPhone.Text,TextAddress.Text);
            dataGridView1.DataSource = dt;
            //When click buton Add clear all Text
            TextID.Clear();
            TextFname.Clear();
            TextLname.Clear();
            textSex.Clear();
           TextEmail.Clear();
            TextPhone.Clear();
            TextAddress.Clear();
            TextID.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow n = dataGridView1.Rows[x];
                n.Cells[0].Value = TextID.Text;
                n.Cells[1].Value = TextFname.Text;
                n.Cells[2].Value = TextLname.Text;
                n.Cells[3].Value = textSex.Text;
                n.Cells[4].Value = DOB.Text.ToString();
                n.Cells[5].Value = TextEmail.Text;
                n.Cells[6].Value = TextPhone.Text;
                n.Cells[7].Value = TextAddress.Text;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            x = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(x);
        }
    }
}
