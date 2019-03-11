namespace OT_Management
{
    partial class Print
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Print));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.searchDept = new System.Windows.Forms.Button();
            this.departmentBox = new System.Windows.Forms.TextBox();
            this.sectionButton = new System.Windows.Forms.Button();
            this.sectionBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::OT_Management.Properties.Resources.Kemet_Logo;
            this.pictureBox3.Location = new System.Drawing.Point(2, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(134, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(148, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dddd, dd/MM/yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(199, 37);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker2.TabIndex = 62;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dddd, dd/MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(190, 20);
            this.dateTimePicker1.TabIndex = 61;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // searchDept
            // 
            this.searchDept.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchDept.BackgroundImage")));
            this.searchDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchDept.Location = new System.Drawing.Point(653, 9);
            this.searchDept.Name = "searchDept";
            this.searchDept.Size = new System.Drawing.Size(26, 23);
            this.searchDept.TabIndex = 60;
            this.searchDept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchDept.UseVisualStyleBackColor = true;
            this.searchDept.Click += new System.EventHandler(this.searchDept_Click);
            // 
            // departmentBox
            // 
            this.departmentBox.Enabled = false;
            this.departmentBox.Location = new System.Drawing.Point(515, 12);
            this.departmentBox.Name = "departmentBox";
            this.departmentBox.ReadOnly = true;
            this.departmentBox.Size = new System.Drawing.Size(132, 20);
            this.departmentBox.TabIndex = 59;
            // 
            // sectionButton
            // 
            this.sectionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sectionButton.BackgroundImage")));
            this.sectionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sectionButton.Location = new System.Drawing.Point(653, 35);
            this.sectionButton.Name = "sectionButton";
            this.sectionButton.Size = new System.Drawing.Size(26, 23);
            this.sectionButton.TabIndex = 58;
            this.sectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sectionButton.UseVisualStyleBackColor = true;
            this.sectionButton.Click += new System.EventHandler(this.sectionButton_Click);
            // 
            // sectionBox
            // 
            this.sectionBox.Enabled = false;
            this.sectionBox.Location = new System.Drawing.Point(515, 37);
            this.sectionBox.Name = "sectionBox";
            this.sectionBox.ReadOnly = true;
            this.sectionBox.Size = new System.Drawing.Size(132, 20);
            this.sectionBox.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 66;
            this.label7.Text = "Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(405, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 65;
            this.label5.Text = "Department";
            // 
            // findButton
            // 
            this.findButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findButton.BackgroundImage")));
            this.findButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.findButton.Location = new System.Drawing.Point(708, 9);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(59, 48);
            this.findButton.TabIndex = 67;
            this.findButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(861, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(61, 55);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 69;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Enabled = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 71);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(932, 449);
            this.crystalReportViewer1.TabIndex = 68;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(934, 520);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchDept);
            this.Controls.Add(this.departmentBox);
            this.Controls.Add(this.sectionButton);
            this.Controls.Add(this.sectionBox);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Print";
            this.Text = "Print";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button searchDept;
        private System.Windows.Forms.TextBox departmentBox;
        private System.Windows.Forms.Button sectionButton;
        private System.Windows.Forms.TextBox sectionBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button findButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}