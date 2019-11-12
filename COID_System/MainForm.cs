﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COID_System.Entity;

namespace COID_System
{
    public partial class MainForm : Form
    {
        

        
        public MainForm()
        {
            InitializeComponent();

           

        }

        private void buttonMenuPlan_Click(object sender, EventArgs e)
        {
           
            
           
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

 
        

        private void MainForm_Load(object sender, EventArgs e)
        {
            detailFoods1.ComboClicked += new
                EventHandler(ShowComboTab);
            detailCombo1.FoodClicked += new
                EventHandler(ShowFoodTab);
        }


        private void buttonCustomerTab_Click(object sender, EventArgs e)
        {
           
         
        }

         void ShowFoodTab(object sender, EventArgs e)
        {
            detailFoods1.Show();
            detailCombo1.Hide();
        }

         void ShowComboTab(object sender, EventArgs e)
        {
            detailFoods1.Hide();
            detailCombo1.Show();
        }
    }
}
