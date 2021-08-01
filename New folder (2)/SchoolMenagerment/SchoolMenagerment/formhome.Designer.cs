namespace SchoolMenagerment
{
    partial class formhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formhome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnclass = new System.Windows.Forms.Button();
            this.btnteacher = new System.Windows.Forms.Button();
            this.btnregistor = new System.Windows.Forms.Button();
            this.btnstudent = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 47);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(1309, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::SchoolMenagerment.Properties.Resources.a_education_Icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer M1", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "ប្រព័ន្ធគ្រប់គ្រងសាលារៀន";
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdmin.Location = new System.Drawing.Point(1112, 53);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(228, 52);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "cheivravy92@gmail.com";
            this.btnAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnclass
            // 
            this.btnclass.BackColor = System.Drawing.Color.LightCoral;
            this.btnclass.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclass.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnclass.Image = ((System.Drawing.Image)(resources.GetObject("btnclass.Image")));
            this.btnclass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclass.Location = new System.Drawing.Point(12, 111);
            this.btnclass.Name = "btnclass";
            this.btnclass.Size = new System.Drawing.Size(147, 58);
            this.btnclass.TabIndex = 1;
            this.btnclass.Text = "ថ្នាក់រៀន";
            this.btnclass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclass.UseVisualStyleBackColor = false;
            this.btnclass.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnteacher
            // 
            this.btnteacher.BackColor = System.Drawing.Color.LightCoral;
            this.btnteacher.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnteacher.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnteacher.Image = ((System.Drawing.Image)(resources.GetObject("btnteacher.Image")));
            this.btnteacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnteacher.Location = new System.Drawing.Point(12, 170);
            this.btnteacher.Name = "btnteacher";
            this.btnteacher.Size = new System.Drawing.Size(147, 58);
            this.btnteacher.TabIndex = 2;
            this.btnteacher.Text = "គ្រូបង្រៀន";
            this.btnteacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnteacher.UseVisualStyleBackColor = false;
            this.btnteacher.Click += new System.EventHandler(this.btnteacher_Click);
            // 
            // btnregistor
            // 
            this.btnregistor.BackColor = System.Drawing.Color.LightCoral;
            this.btnregistor.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistor.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnregistor.Image = ((System.Drawing.Image)(resources.GetObject("btnregistor.Image")));
            this.btnregistor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistor.Location = new System.Drawing.Point(12, 53);
            this.btnregistor.Name = "btnregistor";
            this.btnregistor.Size = new System.Drawing.Size(147, 58);
            this.btnregistor.TabIndex = 0;
            this.btnregistor.Text = "ចុះឈ្មោះសិស្ស";
            this.btnregistor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistor.UseVisualStyleBackColor = false;
            this.btnregistor.Click += new System.EventHandler(this.btnregistor_Click);
            // 
            // btnstudent
            // 
            this.btnstudent.BackColor = System.Drawing.Color.LightCoral;
            this.btnstudent.Font = new System.Drawing.Font("Khmer OS Battambang", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudent.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnstudent.Image = ((System.Drawing.Image)(resources.GetObject("btnstudent.Image")));
            this.btnstudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnstudent.Location = new System.Drawing.Point(12, 230);
            this.btnstudent.Name = "btnstudent";
            this.btnstudent.Size = new System.Drawing.Size(147, 58);
            this.btnstudent.TabIndex = 4;
            this.btnstudent.Text = "ព័ត៌មានសិស្ស";
            this.btnstudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnstudent.UseVisualStyleBackColor = false;
            this.btnstudent.Click += new System.EventHandler(this.btnstudent_Click);
            // 
            // formhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1340, 581);
            this.Controls.Add(this.btnstudent);
            this.Controls.Add(this.btnregistor);
            this.Controls.Add(this.btnclass);
            this.Controls.Add(this.btnteacher);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formhome";
            this.Text = "formhome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnclass;
        private System.Windows.Forms.Button btnteacher;
        private System.Windows.Forms.Button btnregistor;
        private System.Windows.Forms.Button btnstudent;
    }
}