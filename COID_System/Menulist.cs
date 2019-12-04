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

        public void offMode()
        {
            textBoxName.Enabled = false;
            addMode = false;
            editMode = false;
            button2.Text = "Edit";
            button1.Text = "Delete";

            
            buttonAdd.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (addMode == true || editMode == true)
            {
                offMode();
            }
            else
            {
                if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foodSelected = parseInputToFood();
                    using (OrderSystemEntities db = new OrderSystemEntities())
                    {
                        var entry = db.Entry(foodSelected);
                        if (entry.State == EntityState.Detached)
                            db.foods.Attach(foodSelected);
                        db.foods.Remove(foodSelected);
                        db.SaveChanges();
                        FillListFood();
                        offMode();

                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addMode == true)
            {
                foodSelected = parseInputToFood();
                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    db.foods.Add(foodSelected);

                    db.SaveChanges();
                }
                offMode();
                FillListFood();
                MessageBox.Show("done!");
                return;
            }

            if (editMode == false)
            {
                editModeOn();
            }
            else
            {
                foodSelected = parseInputToFood();

                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    db.Entry(foodSelected).State = EntityState.Modified;

                    db.SaveChanges();
                }
                offMode();
                FillListFood();
                MessageBox.Show("done!");
            }

            return;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
