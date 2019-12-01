using System;
using System.Collections;
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
    public partial class Menulist : Form
    {
        public Menulist()
        {
            InitializeComponent();
            FillForm();
        }

        private ArrayList listFoodCombo;
        private ArrayList listFoodEdited;

        public event EventHandler FoodClicked;
        private combo comboTemp;
        private string comboSelected;
        private bool addMode { get; set; }
        private bool editMode { get; set; }


        public void FillForm()
        {
            //fill food checklist
            checkedListBox1.Items.Clear();

            OrderSystemEntities db = new OrderSystemEntities();

            foreach (food i in db.foods)
            {
                checkedListBox1.Items.Add(i);
            }


            //fill combo checklist
           
            foreach (var i in db.comboes)
            {
                checkedListBox1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
