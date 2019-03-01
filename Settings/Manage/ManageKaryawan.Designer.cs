namespace OT_Management
{
    partial class ManageKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageKaryawan));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.badgeBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.closeBox = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.genderBox = new System.Windows.Forms.ComboBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.timeBox = new System.Windows.Forms.TextBox();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.searchDept = new System.Windows.Forms.Button();
            this.searchSect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::OT_Management.Properties.Resources.Kemet_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(4, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(193, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Badge";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Department";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Date of Join";
            // 
            // badgeBox
            // 
            this.badgeBox.Location = new System.Drawing.Point(193, 79);
            this.badgeBox.MaxLength = 6;
            this.badgeBox.Name = "badgeBox";
            this.badgeBox.Size = new System.Drawing.Size(236, 20);
            this.badgeBox.TabIndex = 10;
            this.badgeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.badgeBox_KeyDown);
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(193, 109);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(236, 20);
            this.nameBox.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(193, 139);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // updateButton
            // 
            this.updateButton.Enabled = false;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(22, 260);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(115, 47);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(143, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 47);
            this.deleteButton.TabIndex = 18;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // closeBox
            // 
            this.closeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBox.Location = new System.Drawing.Point(385, 260);
            this.closeBox.Name = "closeBox";
            this.closeBox.Size = new System.Drawing.Size(115, 47);
            this.closeBox.TabIndex = 20;
            this.closeBox.Text = "Close";
            this.closeBox.UseVisualStyleBackColor = true;
            this.closeBox.Click += new System.EventHandler(this.closeBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(297, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Sex";
            // 
            // genderBox
            // 
            this.genderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genderBox.Enabled = false;
            this.genderBox.FormattingEnabled = true;
            this.genderBox.Items.AddRange(new object[] {
            "M",
            "F"});
            this.genderBox.Location = new System.Drawing.Point(346, 140);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(83, 21);
            this.genderBox.TabIndex = 13;
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(264, 260);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(115, 47);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(3, 324);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(522, 205);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 24);
            this.label8.TabIndex = 33;
            this.label8.Text = "Time Remain";
            // 
            // timeBox
            // 
            this.timeBox.Enabled = false;
            this.timeBox.Location = new System.Drawing.Point(193, 234);
            this.timeBox.MaxLength = 2;
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(47, 20);
            this.timeBox.TabIndex = 16;
            this.timeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeBox_KeyPress);
            // 
            // sectionBox
            // 
            this.sectionBox.Enabled = false;
            this.sectionBox.Location = new System.Drawing.Point(193, 200);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.Size = new System.Drawing.Size(203, 20);
            this.sectionBox.TabIndex = 35;
            // 
            // departmentBox
            // 
            this.departmentBox.Location = new System.Drawing.Point(193, 169);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(203, 20);
            this.departmentBox.TabIndex = 34;
            // 
            // searchDept
            // 
            this.searchDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchDept.BackgroundImage")));
            this.searchDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchDept.Location = new System.Drawing.Point(402, 166);
            this.searchDept.Name = "searchDept";
            this.searchDept.Size = new System.Drawing.Size(26, 23);
            this.searchDept.TabIndex = 36;
            this.searchDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchDept.UseVisualStyleBackColor = true;
            this.searchDept.Click += new System.EventHandler(this.searchDept_Click);
            // 
            // searchSect
            // 
            this.searchSect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchSect.BackgroundImage")));
            this.searchSect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchSect.Location = new System.Drawing.Point(402, 198);
            this.searchSect.Name = "searchSect";
            this.searchSect.Size = new System.Drawing.Size(26, 23);
            this.searchSect.TabIndex = 37;
            this.searchSect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchSect.UseVisualStyleBackColor = true;
            this.searchSect.Click += new System.EventHandler(this.searchSect_Click);
            // 
            // ManageKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(528, 531);
            this.Controls.Add(this.searchSect);
            this.Controls.Add(this.searchDept);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.timeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.genderBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.closeBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.badgeBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageKaryawan";
            this.Text = "Data Karyawan";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox badgeBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button closeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genderBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox timeBox;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Button searchDept;
        private System.Windows.Forms.Button searchSect;
    }
}