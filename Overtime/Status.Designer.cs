namespace OT_Management
{
    partial class Status
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.refreshBox = new System.Windows.Forms.PictureBox();
            this.searchDept = new System.Windows.Forms.Button();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.sectionButton = new System.Windows.Forms.Button();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Image = global::OT_Management.Properties.Resources.Kemet_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(8, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(763, 342);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // refreshBox
            // 
            this.refreshBox.Image = ((System.Drawing.Image)(resources.GetObject("refreshBox.Image")));
            this.refreshBox.Location = new System.Drawing.Point(713, 8);
            this.refreshBox.Name = "refreshBox";
            this.refreshBox.Size = new System.Drawing.Size(58, 49);
            this.refreshBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBox.TabIndex = 49;
            this.refreshBox.TabStop = false;
            this.refreshBox.Click += new System.EventHandler(this.refreshBox_Click);
            // 
            // searchDept
            // 
            this.searchDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchDept.BackgroundImage")));
            this.searchDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchDept.Location = new System.Drawing.Point(668, 9);
            this.searchDept.Name = "searchDept";
            this.searchDept.Size = new System.Drawing.Size(26, 23);
            this.searchDept.TabIndex = 48;
            this.searchDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchDept.UseVisualStyleBackColor = true;
            this.searchDept.Click += new System.EventHandler(this.searchDept_Click);
            // 
            // departmentBox
            // 
            this.departmentBox.Enabled = false;
            this.departmentBox.Location = new System.Drawing.Point(530, 12);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.ReadOnly = true;
            this.departmentBox.Size = new System.Drawing.Size(132, 20);
            this.departmentBox.TabIndex = 47;
            // 
            // sectionButton
            // 
            this.sectionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sectionButton.BackgroundImage")));
            this.sectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sectionButton.Location = new System.Drawing.Point(668, 35);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(26, 23);
            this.sectionButton.TabIndex = 46;
            this.sectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // sectionBox
            // 
            this.sectionBox.Enabled = false;
            this.sectionBox.Location = new System.Drawing.Point(530, 37);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.ReadOnly = true;
            this.sectionBox.Size = new System.Drawing.Size(132, 20);
            this.sectionBox.TabIndex = 45;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(649, 428);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(122, 43);
            this.closeButton.TabIndex = 50;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(420, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Department";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 53;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dddd, dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(214, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker2.TabIndex = 54;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "From";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(779, 479);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.refreshBox);
            this.Controls.Add(this.searchDept);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Status";
            this.Text = "Status Approval";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox refreshBox;
        private System.Windows.Forms.Button searchDept;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Button sectionButton;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}