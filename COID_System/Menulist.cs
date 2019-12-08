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
       

        public event EventHandler FoodClicked;
        private combo comboTemp;
        private string comboSelected;
        private bool addMode { get; set; }
        private bool editMode { get; set; }


        public void FillForm()
        {
            //fill food checklist
            checkedListBoxFood.Items.Clear();
            checkedListBoxFood.MultiColumn = true;
            OrderSystemEntities db = new OrderSystemEntities();

            foreach (food i in db.foods)
            {
                checkedListBoxFood.Items.Add(i);
            }


            //fill combo checklist
           
            foreach (var i in db.comboes)
            {
                checkedListBoxCombo.Items.Add(i);
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
           
            checkedListBoxFood.Enabled = true;
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
                    foreach (food food in checkedListBoxFood.CheckedItems)
                    {
                        menu_detail menuDetail = new menu_detail();
                        menuDetail.menuId = inputToMenu.id;
                        menuDetail.price = food.price;
                        menuDetail.productID = food.id;
                        db.menu_detail.Add(menuDetail);
                        db.SaveChanges();
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
                listFoodCombo.Clear();
                foreach (food item in checkedListBoxFood.CheckedItems)
                {
                    listFoodCombo.Add(item);
                }

                foreach (combo item in checkedListBoxCombo.CheckedItems)
                {
                    listFoodCombo.Add(item);
                }
               
               
                //if listFoodEdited not in listFoodCombo -> add
                foreach (var foodname in listFoodCombo)
                {
                    if (!listFoodCombo.Contains(foodname))
                    {
                       
                        

                       
                    }
                }

              

               
                
                
                offMode();
                FillForm();
                MessageBox.Show("done!");
            }

            return;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditModeOn(true);
        }

        private menu parseInputToMenu()
        {


            return null;
        }
    }
}
