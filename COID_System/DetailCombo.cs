using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using COID_System.Entity;

namespace COID_System
{
    public partial class DetailCombo : UserControl
    {
        public DetailCombo()
        {
            InitializeComponent();
        }

        private ArrayList listFoodCombo;
        private ArrayList listFoodEdited;
        
        public event EventHandler FoodClicked;
        private combo comboTemp;
        private combo selectedCombo;
        
        private bool addMode { get; set; }
        private bool editMode { get; set; }

        //switch to foodDetail
        private void buttonFood_Click(object sender, EventArgs e)
        {
            if (FoodClicked != null)
            {
                FoodClicked(this, EventArgs.Empty);
            }
        }





        public void start()
        {
            FillForm();
            listFoodCombo = new ArrayList();
            listFoodEdited = new ArrayList();
        }

        

        public void FillForm()
        {
            //fill food checklist
            checkedListBox1.Items.Clear();
            
            OrderSystemEntities db = new OrderSystemEntities();
            
            var foods1 = db.foods.Where(r => r.disable == false);
            foreach (food i in foods1)
            {
                checkedListBox1.Items.Add(i);
            }


            //fill combo
            var combos1 = db.comboes.Where(r => r.disable == false);
            listBoxCombo.Items.Clear();
            foreach (var i in combos1)
            {
                listBoxCombo.Items.Add(i);
            }
        }


        private void AddEditModeOn(bool addMode1)
        {
            
            if (addMode1)
            {
                addMode = true;

                textBoxDiscount.Text = textBoxName.Text = textBoxDescription.Text = textBoxPrice.Text = textBoxID.Text = textBoxDiscount.Text = "";
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
            textBoxDescription.ReadOnly = false;
            textBoxPrice.ReadOnly = false;
            textBoxID.ReadOnly = false;
            textBoxDiscount.ReadOnly = false;
            listBoxCombo.Enabled = false;
            
            checkedListBox1.Enabled = true;
        }

       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditModeOn(true);
            
        }

      

      
        //button to delete + cancel add/edit
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (addMode == true || editMode == true)
            {
                offMode();
            }
            else
            {
                if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int count = 0;
                    combo comboInput = ParseInputToCombo();
                    using (OrderSystemEntities db = new OrderSystemEntities())
                    {
                        //delete foodcombo
                        foreach (string foodname in listFoodCombo)
                        {
                            food food = db.foods.FirstOrDefault(x => x.name == foodname);
                            food_combo foodcombo = new food_combo();
                            foodcombo.foodID = food.id;
                            foodcombo.comboID = comboTemp.id;
                            foodcombo.price = comboTemp.price;
                            var entry1 = db.Entry(foodcombo);
                                if (entry1.State == EntityState.Detached)
                                    db.food_combo.Attach(foodcombo);
                                db.food_combo.Remove(foodcombo);
                                db.SaveChanges();
                                count++;

                        }





                        //delete combo

                        comboTemp.disable = true;
                        db.Entry(comboTemp).State = EntityState.Modified;
                        db.SaveChanges();
                        
                        FillForm();
                        offMode();

                        MessageBox.Show("Deleted combo which has " + count + "food(s) Successfully");
                    }
                }
            }
        }

        //confirm button + edit button
        private void button2_Click(object sender, EventArgs e)
        {
            //add
            if (addMode == true)
            {
                combo combo = ParseInputToCombo();
                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    db.comboes.Add(combo);
                    db.SaveChanges();
                    foreach (food foodname in checkedListBox1.CheckedItems)
                    {

                        food_combo foodcombo = new food_combo();
                        foodcombo.foodID = foodname.id;
                        foodcombo.comboID = combo.id;
                        foodcombo.price = combo.price;
                        db.food_combo.Add(foodcombo);
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

                combo comboInput = ParseInputToCombo();
                

                comboTemp.disable = true;
                db.Entry(comboTemp).State = EntityState.Modified;
                db.SaveChanges();

                db.comboes.Add(comboInput);
                db.SaveChanges();


                //edit foodcombo
                listFoodEdited.Clear();
                foreach (food item in checkedListBox1.CheckedItems)
                {
                    
                    listFoodEdited.Add(item.name);
                }

                int acount=0;
                
                
                //if listFoodEdited not in listFoodCombo -> add
                foreach (string foodname in listFoodEdited)
                {
                    
                    
                        acount = acount+1;
                        food food = db.foods.FirstOrDefault(x => x.name == foodname);
                             
                        food_combo foodcombo = new food_combo();
                        foodcombo.foodID = food.id;
                        foodcombo.comboID = comboInput.id;
                        foodcombo.price = comboInput.price;
                         db.food_combo.Add(foodcombo);
                          db.SaveChanges();
                    
                }

                MessageBox.Show("added "+acount+" food(s)");

                
                
                offMode();
                FillForm();
                MessageBox.Show("done!");
            }

            return;
        }

        public void offMode()
        {
            textBoxName.ReadOnly = true;
            textBoxDescription.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
            textBoxID.ReadOnly = true;
            textBoxDiscount.ReadOnly = true;
            textBoxName.Text = textBoxDescription.Text = textBoxPrice.Text = textBoxID.Text = textBoxDiscount.Text = "";
            
            addMode = false;
            editMode = false;
            button2.Text = "Edit";
            button1.Text = "Delete";
            listBoxCombo.Enabled = true;
            button2.Enabled = true;
            button1.Enabled = true;
            buttonAdd.Enabled = true;
            
            checkedListBox1.Enabled = false;
        }

        private combo ParseInputToCombo()
        {
            combo inputToCombo = new combo();

            inputToCombo.id = textBoxID.Text.Trim();
            inputToCombo.name = textBoxName.Text.Trim();
            inputToCombo.description = textBoxDescription.Text.Trim();
            inputToCombo.price = float.Parse(textBoxPrice.Text);
            inputToCombo.discount_price = float.Parse(textBoxDiscount.Text);
            inputToCombo.create_time = DateTime.Now;
            inputToCombo.disable = false;
            return inputToCombo;
        }

        private void listBoxCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            listFoodCombo.Clear();
            //deselected all food
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
               
                
                    checkedListBox1.SetItemChecked(i, false);
                   
            }
            //put all data into textbox
            if (listBoxCombo.SelectedIndex > -1)
            {
                combo selectedCombo = new combo();
                this.selectedCombo = selectedCombo = (combo)listBoxCombo.SelectedItem;
                


                using (OrderSystemEntities db = new OrderSystemEntities())
                {


                    selectedCombo = db.comboes.FirstOrDefault(x => x.id == selectedCombo.id);
                    comboTemp = selectedCombo;
                    if (selectedCombo == null)
                    {
                        MessageBox.Show("Error");
                        return;
                    }
                    textBoxName.Text = selectedCombo.name;
                    textBoxPrice.Text = selectedCombo.price.ToString();
                    textBoxDescription.Text = selectedCombo.description;
                    textBoxID.Text = selectedCombo.id;
                    textBoxDiscount.Text = selectedCombo.discount_price.ToString();

                    //set food selected
                    
                    var foodcombo = db.food_combo.Where(r => r.comboID == selectedCombo.id);
                    foreach (food_combo fc in foodcombo)
                    {
                        
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            if (fc.food.name == checkedListBox1.Items[i].ToString())
                            {
                                checkedListBox1.SetItemChecked(i, true);
                                listFoodCombo.Add(fc.food.name);
                                break;
                            }
                        }
                    }

                }
                
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            OrderSystemEntities db = new OrderSystemEntities();
            checkedListBox1.Items.Clear();
            string searchText = textBoxSearch.Text;
            var matches = from m in db.foods
                where m.name.Contains(searchText)
                select m;
            foreach (food match in matches)
            {
                checkedListBox1.Items.Add(match);
            }

            if (editMode)
            {
                combo selectedCombo = this.selectedCombo;
                selectedCombo = db.comboes.FirstOrDefault(x => x.id == selectedCombo.id);
                var foodcombo = db.food_combo.Where(r => r.comboID == selectedCombo.id);
                foreach (food_combo fc in foodcombo)
                {

                    for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    {
                        if (fc.food.name == checkedListBox1.Items[i].ToString())
                        {
                            checkedListBox1.SetItemChecked(i, true);
                            listFoodCombo.Add(fc.food.name);
                            break;
                        }
                    }
                }
            }

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}