namespace OT_Management
{
    partial class ManageDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDepartment));
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cancelButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentBox
            // 
            this.departmentBox.AcceptsReturn = true;
            this.departmentBox.Enabled = false;
            this.departmentBox.Location = new System.Drawing.Point(176, 116);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.Size = new System.Drawing.Size(237, 20);
            this.departmentBox.TabIndex = 12;
            // 
            // codeBox
            // 
            this.codeBox.AcceptsReturn = true;
            this.codeBox.Location = new System.Drawing.Point(176, 85);
            this.codeBox.MaxLength = 4;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(237, 20);
            this.codeBox.TabIndex = 11;
            this.codeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(198, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 37;
            this.label1.Text = "Manage Section";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox2.Image = global::OT_Management.Properties.Resources.Kemet_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(141, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(5, 203);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(455, 228);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // cancelButton
            // 
            this.cancelButton.Enabled = false;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelButton.ImageKey = "(none)";
            this.cancelButton.Location = new System.Drawing.Point(244, 161);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(93, 36);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeButton.ImageKey = "(none)";
            this.closeButton.Location = new System.Drawing.Point(367, 161);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(93, 36);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteButton.ImageKey = "(none)";
            this.deleteButton.Location = new System.Drawing.Point(122, 161);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(93, 36);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.saveButton.ImageKey = "(none)";
            this.saveButton.Location = new System.Drawing.Point(7, 161);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(93, 36);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Update";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ManageDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(466, 440);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Department";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
    }
}