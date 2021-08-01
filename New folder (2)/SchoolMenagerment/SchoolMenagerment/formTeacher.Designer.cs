namespace SchoolMenagerment
{
    partial class formTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formTeacher));
            this.Rgirl = new System.Windows.Forms.GroupBox();
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textSex = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TextAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextFname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Rgirl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Rgirl
            // 
            this.Rgirl.BackColor = System.Drawing.Color.RosyBrown;
            this.Rgirl.Controls.Add(this.DOB);
            this.Rgirl.Controls.Add(this.dataGridView1);
            this.Rgirl.Controls.Add(this.textSex);
            this.Rgirl.Controls.Add(this.BtnDelete);
            this.Rgirl.Controls.Add(this.BtnEdit);
            this.Rgirl.Controls.Add(this.BtnSave);
            this.Rgirl.Controls.Add(this.TextAddress);
            this.Rgirl.Controls.Add(this.label8);
            this.Rgirl.Controls.Add(this.TextPhone);
            this.Rgirl.Controls.Add(this.label7);
            this.Rgirl.Controls.Add(this.label6);
            this.Rgirl.Controls.Add(this.TextEmail);
            this.Rgirl.Controls.Add(this.label5);
            this.Rgirl.Controls.Add(this.label4);
            this.Rgirl.Controls.Add(this.TextLname);
            this.Rgirl.Controls.Add(this.label3);
            this.Rgirl.Controls.Add(this.TextFname);
            this.Rgirl.Controls.Add(this.label2);
            this.Rgirl.Controls.Add(this.TextID);
            this.Rgirl.Controls.Add(this.label1);
            this.Rgirl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rgirl.Location = new System.Drawing.Point(0, 0);
            this.Rgirl.Name = "Rgirl";
            this.Rgirl.Size = new System.Drawing.Size(853, 464);
            this.Rgirl.TabIndex = 0;
            this.Rgirl.TabStop = false;
            this.Rgirl.Enter += new System.EventHandler(this.Rgirl_Enter);
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(548, 42);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(246, 20);
            this.DOB.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 204);
            this.dataGridView1.TabIndex = 21;
            // 
            // textSex
            // 
            this.textSex.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSex.Location = new System.Drawing.Point(136, 154);
            this.textSex.Name = "textSex";
            this.textSex.Size = new System.Drawing.Size(248, 36);
            this.textSex.TabIndex = 4;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnDelete.Font = new System.Drawing.Font("Khmer OS Bokor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnDelete.Location = new System.Drawing.Point(362, 213);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(114, 38);
            this.BtnDelete.TabIndex = 19;
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEdit.BackgroundImage")));
            this.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEdit.Font = new System.Drawing.Font("Khmer OS Bokor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnEdit.Location = new System.Drawing.Point(246, 213);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(110, 38);
            this.BtnEdit.TabIndex = 18;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSave.BackgroundImage")));
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSave.Font = new System.Drawing.Font("Khmer OS Bokor", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.BtnSave.Location = new System.Drawing.Point(136, 213);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(104, 38);
            this.BtnSave.TabIndex = 17;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TextAddress
            // 
            this.TextAddress.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextAddress.Location = new System.Drawing.Point(547, 161);
            this.TextAddress.Name = "TextAddress";
            this.TextAddress.Size = new System.Drawing.Size(248, 36);
            this.TextAddress.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(443, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 27);
            this.label8.TabIndex = 15;
            this.label8.Text = "អាសយដ្ឋាន";
            // 
            // TextPhone
            // 
            this.TextPhone.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPhone.Location = new System.Drawing.Point(547, 119);
            this.TextPhone.Name = "TextPhone";
            this.TextPhone.Size = new System.Drawing.Size(248, 36);
            this.TextPhone.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(443, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 27);
            this.label7.TabIndex = 13;
            this.label7.Text = "លេខទូរស័ព្ទ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "ភេទ";
            // 
            // TextEmail
            // 
            this.TextEmail.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEmail.Location = new System.Drawing.Point(547, 77);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Size = new System.Drawing.Size(248, 36);
            this.TextEmail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(443, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "អ៊ីម៉ែល";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 6;
            this.label4.Text = "ថ្ងៃខែឆ្នាំកំណើត";
            // 
            // TextLname
            // 
            this.TextLname.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLname.Location = new System.Drawing.Point(136, 111);
            this.TextLname.Name = "TextLname";
            this.TextLname.Size = new System.Drawing.Size(248, 36);
            this.TextLname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "នាមខ្លួន";
            // 
            // TextFname
            // 
            this.TextFname.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFname.Location = new System.Drawing.Point(136, 71);
            this.TextFname.Name = "TextFname";
            this.TextFname.Size = new System.Drawing.Size(248, 36);
            this.TextFname.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "នាមត្រកូល";
            // 
            // TextID
            // 
            this.TextID.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextID.Location = new System.Drawing.Point(136, 31);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(248, 36);
            this.TextID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Battambang", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "អត្ថលេខគ្រូ";
            // 
            // formTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 464);
            this.Controls.Add(this.Rgirl);
            this.Name = "formTeacher";
            this.Text = "ព័ត៌មានគ្រូ";
            this.Load += new System.EventHandler(this.formTeacher_Load);
            this.Rgirl.ResumeLayout(false);
            this.Rgirl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Rgirl;
        private System.Windows.Forms.TextBox TextID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TextBox TextAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TextPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextFname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textSex;
        private System.Windows.Forms.DateTimePicker DOB;
    }
}