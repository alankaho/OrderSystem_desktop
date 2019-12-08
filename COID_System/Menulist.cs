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

            var foodlist = db.foods.Where(r => r.disable == false);
            var combolist = db.comboes.Where(r => r.disable == false);


            foreach (var i in foodlist)
            {
                checkedListBoxFood.Items.Add(i);
            }


            //fill combo checklist
           
            foreach (var i in combolist)
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
            menu tempMenu = new menu();
            tempMenu.id = Int32.Parse(textBoxID.Text);
            tempMenu.menu_name = textBoxName.Text;
            tempMenu.creator = textBoxCreator.Text;
            tempMenu.date_create = DateTime.Today;
            tempMenu.disable = false;

            return tempMenu;
        }

        //import data on menu
        private void listBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            listFoodCombo.Clear();
            //deselected all food
            for (int i = 0; i < checkedListBoxFood.Items.Count; i++)
            {

                checkedListBoxFood.SetItemChecked(i, false);

            }
            //deselected all combo
            for (int i = 0; i < checkedListBoxCombo.Items.Count; i++)
            {

                checkedListBoxCombo.SetItemChecked(i, false);

            }

            //put all data into textbox
            if (listBoxMenu.SelectedIndex > -1)
            {
                menu selectedMenu = new menu();
                selectedMenu = (menu)listBoxMenu.SelectedItem;
                using (OrderSystemEntities db = new OrderSystemEntities())
                {
                    selectedMenu = db.menus.FirstOrDefault(x => x.id == selectedMenu.id);
                   // comboTemp = selectedMenu;
                    if (selectedMenu == null)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    textBoxName.Text = selectedMenu.menu_name;
                    textBoxID.Text = selectedMenu.id.ToString();
                    textBoxDate.Text = selectedMenu.date_create.ToShortTimeString();
                    
                 

                    //set food selected

                    var menuDetails = db.menu_detail.Where(r => r.menuId == selectedMenu.id);
                    foreach (menu_detail md in menuDetails)
                    {
                        food food1 = db.foods.FirstOrDefault(x => x.id == md.productID);
                        combo combo1 = db.comboes.FirstOrDefault(x => x.id == md.productID);
                        if (food1 != null)
                        {
                            for (int i = 0; i < checkedListBoxFood.Items.Count; i++)
                            {

                                if (food1.name == checkedListBoxFood.Items[i].ToString())
                                {
                                    checkedListBoxFood.SetItemChecked(i, true);

                                    break;
                                }
                            }
                        }
                        if (combo1 != null)
                        {
                            for (int i = 0; i < checkedListBoxCombo.Items.Count; i++)
                            {

                                if (combo1.name == checkedListBoxCombo.Items[i].ToString())
                                {
                                    checkedListBoxFood.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }

                    }

                }

            }
        }
    }
}
