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
    public partial class formClass : Form
    {
        public formClass()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        int x;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNdelete_Click(object sender, EventArgs e)
        {
            x = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(x);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BTNsave_Click(object sender, EventArgs e)
        {
            DateTime date = dateP01.Value.Date;


            dt.Rows.Add(IDclass.Text, Class.Text, TextSub.Text, TextTeacher.Text, dateP01.MinDate.ToString(),
                dateP02.MinDate.ToString(), TextPrice.Text);
            dataGridView1.DataSource = dt;
            //When click buton Add clear all Text
            IDclass.Clear();
            Class.Clear();
            TextSub.Clear();
            TextTeacher.Clear();
            TextPrice.Clear();
            IDclass.Focus();


        }

        private void formClass_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("លេខកូដថ្នាក់", typeof(string));
            dt.Columns.Add("ថ្នាក់", typeof(string));
            dt.Columns.Add("មុខវិជ្ជា", typeof(string)); 
            dt.Columns.Add("គ្រូបង្រៀន", typeof(string));
            dt.Columns.Add("ថ្ងៃចាប់ផ្តើម", typeof(DateTime));
            dt.Columns.Add("ថ្ងៃបញ្ចប់", typeof(DateTime));
            dt.Columns.Add("ថ្លៃសិក្សា", typeof(string));
            dataGridView1.DataSource = dt;
 

        }

        private void BTNEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow n = dataGridView1.Rows[x];
            n.Cells[0].Value = IDclass.Text;
            n.Cells[1].Value = Class.Text;
            n.Cells[2].Value = TextSub.Text;
            n.Cells[3].Value = TextTeacher.Text;
            n.Cells[4].Value = dateP01.Text.ToString();     
            n.Cells[5].Value = dateP02.Text.ToString();
            n.Cells[6].Value = TextPrice.Text;
          
        }
    }
}
