﻿namespace WindowsFormsIntroductionApp
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnGreet = new System.Windows.Forms.Button();
            this.cmbMonths = new System.Windows.Forms.ComboBox();
            this.cmbDaysOfWeek = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnDate = new System.Windows.Forms.Button();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUseName = new System.Windows.Forms.TextBox();
            this.btnUserName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Location = new System.Drawing.Point(35, 32);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(198, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Your Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(261, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 35);
            this.txtName.TabIndex = 1;
            // 
            // btnGreet
            // 
            this.btnGreet.BackColor = System.Drawing.SystemColors.Control;
            this.btnGreet.Location = new System.Drawing.Point(582, 31);
            this.btnGreet.Name = "btnGreet";
            this.btnGreet.Size = new System.Drawing.Size(114, 37);
            this.btnGreet.TabIndex = 2;
            this.btnGreet.Text = "Greet Me";
            this.btnGreet.UseVisualStyleBackColor = false;
            this.btnGreet.Click += new System.EventHandler(this.btnGreet_Click);
            // 
            // cmbMonths
            // 
            this.cmbMonths.FormattingEnabled = true;
            this.cmbMonths.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonths.Location = new System.Drawing.Point(40, 154);
            this.cmbMonths.Name = "cmbMonths";
            this.cmbMonths.Size = new System.Drawing.Size(121, 28);
            this.cmbMonths.TabIndex = 3;
            // 
            // cmbDaysOfWeek
            // 
            this.cmbDaysOfWeek.FormattingEnabled = true;
            this.cmbDaysOfWeek.Location = new System.Drawing.Point(220, 154);
            this.cmbDaysOfWeek.Name = "cmbDaysOfWeek";
            this.cmbDaysOfWeek.Size = new System.Drawing.Size(121, 28);
            this.cmbDaysOfWeek.TabIndex = 4;
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(401, 154);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 28);
            this.cmbYear.TabIndex = 5;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(36, 108);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(103, 20);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Select Month";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(216, 108);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(86, 20);
            this.lblDay.TabIndex = 7;
            this.lblDay.Text = "Select Day";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(397, 108);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(92, 20);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Select Year";
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(551, 144);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(115, 38);
            this.btnDate.TabIndex = 9;
            this.btnDate.Text = "Show Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(40, 215);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(218, 26);
            this.txtdate.TabIndex = 10;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(40, 297);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(132, 20);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Enter User Name";
            // 
            // txtUseName
            // 
            this.txtUseName.Location = new System.Drawing.Point(220, 291);
            this.txtUseName.Name = "txtUseName";
            this.txtUseName.Size = new System.Drawing.Size(238, 26);
            this.txtUseName.TabIndex = 12;
            this.txtUseName.TextChanged += new System.EventHandler(this.txtUseName_TextChanged);
            // 
            // btnUserName
            // 
            this.btnUserName.Location = new System.Drawing.Point(530, 282);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(181, 44);
            this.btnUserName.TabIndex = 13;
            this.btnUserName.Text = "Add UserName";
            this.btnUserName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserName);
            this.Controls.Add(this.txtUseName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.cmbDaysOfWeek);
            this.Controls.Add(this.cmbMonths);
            this.Controls.Add(this.btnGreet);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnGreet;
        private System.Windows.Forms.ComboBox cmbMonths;
        private System.Windows.Forms.ComboBox cmbDaysOfWeek;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUseName;
        private System.Windows.Forms.Button btnUserName;
    }
}

