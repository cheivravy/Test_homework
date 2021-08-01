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
    public partial class formRigistor : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="C:\Users\RVC\Desktop\New folder (2)\SchoolMenagerment\SchoolMenagerment\Rstu.mdb"");

          public void ViewsData()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tbstu";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewDential.DataSource = dt;
            con.Close();
        }
        public void AddData()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = " insert into stu values ('" + TextID.Text + "','" + TextFirsName.Text + "','" + textLastName.Text + "','" + comboBoxSex.Text + "','" + dateTimePickerDOB.Text + "','"+textPlaceOfBird.Text+"','" + textClass.Text + "','" + textPrice.Text + "','" + dateTimePickerStart.Text + "','" + dateTimePickerEnd.Text +"','"+textAddress.Text+"','"+textPearent.Text+"','"+textPAddress.Text+"','"+textHomePhone.Text+")";
            cmd.ExecuteNonQuery();
            con.Close();
            ViewsData();

        }

        public void DeletData()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from stu where ID = '" + textID.Text + "';";
            cmd.ExecuteNonQuery();
            con.Close();
            ViewsData();
            MessageBox.Show("Delete ....");
        }



        public formRigistor()
        {
            InitializeComponent();
        }
        /*DataTable dt = new DataTable();
        int x;

        */


        private void formRigistor_Load(object sender, EventArgs e)
        {
           /* dt.Columns.Add("អត្ថលេខ", typeof(string));
            dt.Columns.Add("នាមត្រកូល", typeof(string));
            dt.Columns.Add("នាមខ្លួន", typeof(string));
            dt.Columns.Add("ភេទ", typeof(string));
            dt.Columns.Add("ថ្ងៃខែឆ្នាំកំណើត", typeof(DateTime));
            dt.Columns.Add("ទីកន្លែងកំណើត", typeof(string));
            dt.Columns.Add("ថ្នាក់", typeof(string));
            dt.Columns.Add("ថ្លៃសិក្សា", typeof(string));
            dt.Columns.Add("ថ្ងៃចូលរៀន", typeof(DateTime));
            dt.Columns.Add("ថ្ងៃបញ្ចប់", typeof(DateTime));
            dt.Columns.Add("អាសយដ្ឋាន", typeof(string));
            dt.Columns.Add("អណាព្យាលបាល", typeof(string));
            dt.Columns.Add("អាសយដដ្ឋាន", typeof(string));
            dt.Columns.Add("លេខទំនាក់ទំនង", typeof(string));
            dataGridViewDential.DataSource = dt;
            */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
            ViewsData();
            
            
            
            /*DateTime date = dateTimePickerDOB.Value.Date;
           

            dt.Rows.Add(TextID.Text, TextFirsName.Text, textLastName.Text, TextGender.Text, dateTimePickerDOB.MinDate.ToString(),
               textPlaceOfBird.Text, textClass.Text, textPrice.Text, dateTimePickerStart.MinDate.ToString(), dateTimePickerEnd.MinDate.ToString(), textAddress.Text, textPearent.Text, textPAddress.Text,
               textHomePhone.Text);

            dataGridViewDential.DataSource = dt;
            //When click buton Add clear all Text
            TextID.Clear();
            TextFirsName.Clear();
            textLastName.Clear();
            TextGender.Clear();
            textPlaceOfBird.Clear();
            textClass.Clear();
            textPrice.Clear();
            textAddress.Clear();
            textPearent.Clear();
            textPAddress.Clear();
            textHomePhone.Clear();
            TextID.Focus();
            */







        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewDential_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          /*  x = e.RowIndex;
            DataGridViewRow R = dataGridViewDential.Rows[x];
            TextID.Text = R.Cells[0].Value.ToString();
            TextFirsName.Text = R.Cells[1].Value.ToString();
            textLastName.Text = R.Cells[2].Value.ToString();
            TextGender.Text = R.Cells[3].Value.ToString();
            dateTimePickerDOB.Text = R.Cells[4].Value.ToString();
            textPlaceOfBird.Text = R.Cells[5].Value.ToString();
            textClass.Text = R.Cells[6].Value.ToString();
            textPrice.Text = R.Cells[7].Value.ToString();
            dateTimePickerStart.Text = R.Cells[8].Value.ToString();
            dateTimePickerEnd.Text = R.Cells[9].Value.ToString();
            textAddress.Text = R.Cells[10].Value.ToString();
            textPearent.Text = R.Cells[11].Value.ToString();
            textPAddress.Text = R.Cells[12].Value.ToString();
            textHomePhone.Text = R.Cells[13].Value.ToString();
           */
        }

        private void btnEdite_Click(object sender, EventArgs e)
        {
           /* DataGridViewRow n = dataGridViewDential.Rows[x];
            n.Cells[0].Value = TextID.Text;
            n.Cells[1].Value = TextFirsName.Text;
            n.Cells[2].Value = textLastName.Text;
            n.Cells[3].Value = TextGender.Text;
            n.Cells[4].Value = dateTimePickerDOB.Text.ToString();
            n.Cells[5].Value = textPlaceOfBird.Text;
            n.Cells[6].Value = textClass.Text;
            n.Cells[7].Value = textPrice.Text;
            n.Cells[8].Value = dateTimePickerStart.Text.ToString();
            n.Cells[9].Value = dateTimePickerEnd.Text.ToString();
            n.Cells[10].Value = textAddress.Text;
            n.Cells[11].Value = textPearent.Text;
            n.Cells[12].Value = textPAddress.Text;
            n.Cells[13].Value = textHomePhone.Text;
*/

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           /* x = dataGridViewDential.CurrentCell.RowIndex;
            dataGridViewDential.Rows.RemoveAt(x);
            */
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
           /* TextID.Text = string.Empty;
            TextFirsName.Text = string.Empty;
            textLastName.Text = string.Empty;
            TextGender.Text = string.Empty;
            dateTimePickerDOB.Text = string.Empty;
            textPlaceOfBird.Text = string.Empty;
            textClass.Text = string.Empty;
            textPrice.Text = string.Empty;
            dateTimePickerStart.Text = string.Empty;
            dateTimePickerEnd.Text = string.Empty;
            textAddress.Text = string.Empty;
            textPearent.Text = string.Empty;
            textPAddress.Text = string.Empty;
            textHomePhone.Text = string.Empty;
            */
        }

        private void TextGender_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
