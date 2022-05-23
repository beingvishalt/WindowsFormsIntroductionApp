﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsIntroductionApp
{
    public partial class Form1 : Form
    {
        string[] DaysOfWeek = {"Sunday","Monday","Tuesday","Wednesday","Thursday","Friday","Saturday" };

        string[] names = { "Vishal", "Sagar", "Mahesh", "Pratik" };
        public Form1()
        {
            InitializeComponent();
        }

     

        private void btnGreet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, "+txtName.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach(string Day in DaysOfWeek)
            //{
            //    cmbDaysOfWeek.Items.Add(Day);
            //}

            for (int i = 1; i < 31; i++)
            {
                cmbDaysOfWeek.Items.Add(i);
            }

            for (int i = 1950; i <2050 ; i++)
            {
                cmbYear.Items.Add(i);
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            txtdate.Text=cmbDaysOfWeek.SelectedItem +","+ cmbMonths.SelectedItem+","+cmbYear.SelectedItem;
        }
    }
}
