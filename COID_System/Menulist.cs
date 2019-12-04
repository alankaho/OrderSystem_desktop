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

        private void AddEditModeOn(bool addMode1)
        {

            if (addMode1)
            {
                addMode = true;

                
                button2.Text = "Add";
                button1.Text = "Back";


            }
            else
            {
                editMode = true;
                button2.Text = "Confirm";
                button1.Text = "Back";
            }

            buttonAdd.Enabled = false;
            textBoxName.ReadOnly = false;
           
            checkedListBox1.Enabled = true;
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
                    
                    using (OrderSystemEntities db = new OrderSystemEntities())
                    {
                        
                        
                        FillForm();
                        offMode();

                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add
            if (addMode == true)
            {
                menu inputToMenu = parseInputToMenu();
                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    db.menus.Add(inputToMenu);
                    db.SaveChanges();
                    foreach (food foodname in checkedListBox1.CheckedItems)
                    {

                        
                    }

                }

                offMode();
                FillForm();
                MessageBox.Show("done!");
                return;

            }

            //edit mode
            if (editMode == false)
            {
                AddEditModeOn(false);
            }
            else
            {
                //edit combo

                OrderSystemEntities db = new OrderSystemEntities();

               




                //edit foodcombo
                listFoodEdited.Clear();
                foreach (food item in checkedListBox1.CheckedItems)
                {

                    listFoodEdited.Add(item.name);
                }

                int acount = 0;
                int dcount = 0;
                //var foodList = db.foods.Where(p => p.name.Contains(index));
                //if listFoodEdited not in listFoodCombo -> add
                foreach (string foodname in listFoodEdited)
                {
                    if (!listFoodCombo.Contains(foodname))
                    {
                        acount = acount + 1;
                        food food = db.foods.FirstOrDefault(x => x.name == foodname);

                       
                    }
                }

                MessageBox.Show("added " + acount + " food(s)=");

                //if listFoodCombo not in listFoodEdited -> delete
                foreach (string foodname in listFoodCombo)
                {
                    if (!listFoodEdited.Contains(foodname))
                    {
                       
                    }
                }
                MessageBox.Show("deleted " + dcount + " foods=");
                offMode();
                FillForm();
                MessageBox.Show("done!");
            }

            return;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private menu parseInputToMenu()
        {


            return null;
        }
    }
}
