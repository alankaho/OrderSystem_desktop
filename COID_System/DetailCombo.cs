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
    public partial class DetailCombo : Form
    {
        public DetailCombo()
        {
            InitializeComponent();
            FillForm();
            listFoodCombo = new ArrayList();
            listFoodEdited = new ArrayList();

        }

        private ArrayList listFoodCombo;
        private ArrayList listFoodEdited;
        
        public event EventHandler FoodClicked;
        private combo comboTemp;
        private string comboSelected;
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


       

       
        

        

        public void FillForm()
        {
            //fill food checklist
            checkedListBox1.Items.Clear();
            
            OrderSystemEntities db = new OrderSystemEntities();

            foreach (food i in db.foods)
            {
                checkedListBox1.Items.Add(i);
            }
            

            //fill combo
            listBoxCombo.Items.Clear();
            foreach (var i in db.comboes)
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
            labelSearch.Visible = true;
            textBoxSearch.Visible = true;
            buttonSearch.Visible = true;
            checkedListBox1.Enabled = true;
        }

       

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditModeOn(true);
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AddEditModeOn(false);
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
                    combo combo = ParseInputToCombo();
                    using (OrderSystemEntities db = new OrderSystemEntities())
                    {
                        var entry = db.Entry(combo);
                        if (entry.State == EntityState.Detached)
                            db.comboes.Attach(combo);
                        db.comboes.Remove(combo);
                        db.SaveChanges();
                        FillForm();
                        offMode();

                        MessageBox.Show("Deleted Successfully");
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

                        food_combo foodcombo = new food_combo(foodname.id,combo.id,combo.price);
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

                combo combo = ParseInputToCombo();
                db.Entry(combo).State = EntityState.Modified;
                db.SaveChanges();
                
                


                //edit foodcombo
                listFoodEdited.Clear();
                foreach (food item in checkedListBox1.CheckedItems)
                {
                    
                    listFoodEdited.Add(item.name);
                }

                int acount=0;
                int dcount = 0;
                //var foodList = db.foods.Where(p => p.name.Contains(index));
                //if listFoodEdited not in listFoodCombo -> add
                foreach (string foodname in listFoodEdited)
                {
                    if (!listFoodCombo.Contains(foodname))
                    {
                        acount = acount+1;
                        food food = db.foods.FirstOrDefault(x => x.name == foodname);
                             
                        food_combo foodcombo = new food_combo(food.id, combo.id, combo.price);
                         db.food_combo.Add(foodcombo);
                          db.SaveChanges();
                    }
                }

                MessageBox.Show("added "+acount+" food(s)=");

                //if listFoodCombo not in listFoodEdited -> delete
                foreach (string foodname in listFoodCombo)
                {
                    if (!listFoodEdited.Contains(foodname))
                    {
                        food food = db.foods.FirstOrDefault(x => x.name == foodname);
                        food_combo foodcombo = new food_combo(food.id, combo.id, combo.price);
                        var entry = db.Entry(foodcombo);
                        if (entry.State == EntityState.Detached)
                            db.food_combo.Attach(foodcombo);
                        db.food_combo.Remove(foodcombo);
                        db.SaveChanges();
                        dcount++;
                    }
                }
                MessageBox.Show("deleted " + dcount + " foods=");
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
            buttonSearch.Visible = false;
            labelSearch.Visible = false;
            textBoxSearch.Visible = false;
            textBoxSearch.Text = "";
            checkedListBox1.Enabled = false;
        }

        private combo ParseInputToCombo()
        {
            comboTemp = new combo();

            comboTemp.id = textBoxID.Text.Trim();
            comboTemp.name = textBoxName.Text.Trim();
            comboTemp.description = textBoxDescription.Text.Trim();
            comboTemp.price = float.Parse(textBoxPrice.Text);
            comboTemp.discount_price = float.Parse(textBoxDiscount.Text);
            comboTemp.create_time = DateTime.Now;
            
            return comboTemp;
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
                selectedCombo = (combo)listBoxCombo.SelectedItem;
                
               

                using (OrderSystemEntities db = new OrderSystemEntities())
                {


                    selectedCombo = db.comboes.FirstOrDefault(x => x.id == selectedCombo.id);
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

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}