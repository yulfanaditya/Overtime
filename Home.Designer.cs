namespace OT_Management
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.hsBox = new System.Windows.Forms.PictureBox();
            this.overtimeBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.settingBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(208, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(287, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::OT_Management.Properties.Resources.Kemet_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(8, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // hsBox
            // 
            this.hsBox.Image = ((System.Drawing.Image)(resources.GetObject("hsBox.Image")));
            this.hsBox.Location = new System.Drawing.Point(301, 105);
            this.hsBox.Name = "hsBox";
            this.hsBox.Size = new System.Drawing.Size(272, 147);
            this.hsBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hsBox.TabIndex = 11;
            this.hsBox.TabStop = false;
            this.hsBox.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // overtimeBox
            // 
            this.overtimeBox.Image = ((System.Drawing.Image)(resources.GetObject("overtimeBox.Image")));
            this.overtimeBox.Location = new System.Drawing.Point(8, 105);
            this.overtimeBox.Name = "overtimeBox";
            this.overtimeBox.Size = new System.Drawing.Size(272, 147);
            this.overtimeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.overtimeBox.TabIndex = 7;
            this.overtimeBox.TabStop = false;
            this.overtimeBox.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Position";
            // 
            // settingBox
            // 
            this.settingBox.Enabled = false;
            this.settingBox.Image = ((System.Drawing.Image)(resources.GetObject("settingBox.Image")));
            this.settingBox.Location = new System.Drawing.Point(8, 274);
            this.settingBox.Name = "settingBox";
            this.settingBox.Size = new System.Drawing.Size(272, 147);
            this.settingBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingBox.TabIndex = 13;
            this.settingBox.TabStop = false;
            this.settingBox.Visible = false;
            this.settingBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(585, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.settingBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hsBox);
            this.Controls.Add(this.overtimeBox);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME - PT. KEMET ELECTRONICS INDONESIA";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overtimeBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox hsBox;
        private System.Windows.Forms.PictureBox overtimeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox settingBox;
        private System.Windows.Forms.PictureBox pictureBox1;


    }
}