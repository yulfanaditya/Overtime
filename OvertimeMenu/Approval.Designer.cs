namespace OT_Management
{
    partial class Approval
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Approval));
            this.listView1 = new System.Windows.Forms.ListView();
            this.approveButton = new System.Windows.Forms.Button();
            this.declineButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.Section = new System.Windows.Forms.Label();
            this.approveAllButton = new System.Windows.Forms.Button();
            this.sectionButton = new System.Windows.Forms.Button();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.searchDept = new System.Windows.Forms.Button();
            this.refreshBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(764, 312);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // approveButton
            // 
            this.approveButton.Location = new System.Drawing.Point(10, 407);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(122, 43);
            this.approveButton.TabIndex = 1;
            this.approveButton.Text = "Approve";
            this.approveButton.UseVisualStyleBackColor = true;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // declineButton
            // 
            this.declineButton.Location = new System.Drawing.Point(266, 407);
            this.declineButton.Name = "declineButton";
            this.declineButton.Size = new System.Drawing.Size(122, 43);
            this.declineButton.TabIndex = 2;
            this.declineButton.Text = "Decline";
            this.declineButton.UseVisualStyleBackColor = true;
            this.declineButton.Click += new System.EventHandler(this.declineButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(652, 407);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(122, 43);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::OT_Management.Properties.Resources.Kemet_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(10, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Department";
            // 
            // departmentLabel
            // 
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentLabel.Location = new System.Drawing.Point(345, 9);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(148, 29);
            this.departmentLabel.TabIndex = 9;
            this.departmentLabel.Text = "Department";
            // 
            // Section
            // 
            this.Section.AutoSize = true;
            this.Section.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.Location = new System.Drawing.Point(200, 38);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(101, 29);
            this.Section.TabIndex = 10;
            this.Section.Text = "Section";
            // 
            // approveAllButton
            // 
            this.approveAllButton.Location = new System.Drawing.Point(138, 407);
            this.approveAllButton.Name = "approveAllButton";
            this.approveAllButton.Size = new System.Drawing.Size(122, 43);
            this.approveAllButton.TabIndex = 12;
            this.approveAllButton.Text = "Approve All";
            this.approveAllButton.UseVisualStyleBackColor = true;
            this.approveAllButton.Click += new System.EventHandler(this.approveAllButton_Click);
            // 
            // sectionButton
            // 
            this.sectionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sectionButton.BackgroundImage")));
            this.sectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sectionButton.Location = new System.Drawing.Point(534, 39);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(26, 23);
            this.sectionButton.TabIndex = 41;
            this.sectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // sectionBox
            // 
            this.sectionBox.Enabled = false;
            this.sectionBox.Location = new System.Drawing.Point(350, 41);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.ReadOnly = true;
            this.sectionBox.Size = new System.Drawing.Size(178, 20);
            this.sectionBox.TabIndex = 40;
            // 
            // departmentBox
            // 
            this.departmentBox.Enabled = false;
            this.departmentBox.Location = new System.Drawing.Point(350, 15);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.ReadOnly = true;
            this.departmentBox.Size = new System.Drawing.Size(178, 20);
            this.departmentBox.TabIndex = 42;
            // 
            // searchDept
            // 
            this.searchDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchDept.BackgroundImage")));
            this.searchDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchDept.Enabled = false;
            this.searchDept.Location = new System.Drawing.Point(534, 15);
            this.searchDept.Name = "searchDept";
            this.searchDept.Size = new System.Drawing.Size(26, 23);
            this.searchDept.TabIndex = 43;
            this.searchDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchDept.UseVisualStyleBackColor = true;
            this.searchDept.Click += new System.EventHandler(this.searchDept_Click);
            // 
            // refreshBox
            // 
            this.refreshBox.Image = ((System.Drawing.Image)(resources.GetObject("refreshBox.Image")));
            this.refreshBox.Location = new System.Drawing.Point(667, 15);
            this.refreshBox.Name = "refreshBox";
            this.refreshBox.Size = new System.Drawing.Size(58, 52);
            this.refreshBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshBox.TabIndex = 44;
            this.refreshBox.TabStop = false;
            this.refreshBox.Click += new System.EventHandler(this.refreshBox_Click);
            // 
            // Approval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(788, 461);
            this.Controls.Add(this.refreshBox);
            this.Controls.Add(this.searchDept);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.approveAllButton);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.declineButton);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Approval";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Approval";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button approveButton;
        private System.Windows.Forms.Button declineButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.Label Section;
        private System.Windows.Forms.Button approveAllButton;
        private System.Windows.Forms.Button sectionButton;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Button searchDept;
        private System.Windows.Forms.PictureBox refreshBox;
    }
}