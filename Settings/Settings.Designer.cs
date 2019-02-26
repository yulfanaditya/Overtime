namespace OT_Management
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label1 = new System.Windows.Forms.Label();
            this.AddNewUser = new System.Windows.Forms.PictureBox();
            this.ManageKaryawan = new System.Windows.Forms.PictureBox();
            this.ManageUserBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageKaryawan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 42);
            this.label1.TabIndex = 7;
            this.label1.Text = "Settings";
            // 
            // AddNewUser
            // 
            this.AddNewUser.Image = ((System.Drawing.Image)(resources.GetObject("AddNewUser.Image")));
            this.AddNewUser.Location = new System.Drawing.Point(12, 241);
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(272, 147);
            this.AddNewUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddNewUser.TabIndex = 16;
            this.AddNewUser.TabStop = false;
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // ManageKaryawan
            // 
            this.ManageKaryawan.Image = ((System.Drawing.Image)(resources.GetObject("ManageKaryawan.Image")));
            this.ManageKaryawan.Location = new System.Drawing.Point(290, 88);
            this.ManageKaryawan.Name = "ManageKaryawan";
            this.ManageKaryawan.Size = new System.Drawing.Size(272, 147);
            this.ManageKaryawan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManageKaryawan.TabIndex = 15;
            this.ManageKaryawan.TabStop = false;
            this.ManageKaryawan.Click += new System.EventHandler(this.ManageKaryawan_Click);
            // 
            // ManageUserBox
            // 
            this.ManageUserBox.Image = ((System.Drawing.Image)(resources.GetObject("ManageUserBox.Image")));
            this.ManageUserBox.Location = new System.Drawing.Point(12, 88);
            this.ManageUserBox.Name = "ManageUserBox";
            this.ManageUserBox.Size = new System.Drawing.Size(272, 147);
            this.ManageUserBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ManageUserBox.TabIndex = 14;
            this.ManageUserBox.TabStop = false;
            this.ManageUserBox.Click += new System.EventHandler(this.ManageUserBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::OT_Management.Properties.Resources.Kemet_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(480, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 80);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(572, 406);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.AddNewUser);
            this.Controls.Add(this.ManageKaryawan);
            this.Controls.Add(this.ManageUserBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.AddNewUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageKaryawan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ManageUserBox;
        private System.Windows.Forms.PictureBox ManageKaryawan;
        private System.Windows.Forms.PictureBox AddNewUser;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}