using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
        }

        private ArrayList listFood1;
        private ArrayList listFood2;
        private Array addFood;
        private Array removeFood;
        public event EventHandler FoodClicked;
        private combo comboTemp;
        private string foodSelected;

        //switch to foodDetail
        private void buttonFood_Click(object sender, EventArgs e)
        {
            if (FoodClicked != null)
            {
                FoodClicked(this, EventArgs.Empty);
            }
        }


       

        public void FillArray(string comboID)
        {
            OrderSystemEntities db = new OrderSystemEntities();
            //get all food joined with combo
            listFood1 = new ArrayList();
            listFood2 = new ArrayList();


            //var foodList = db.foods.Where(p => p.name.Contains(index));

            //get all food joined with combo
            var foodjoined = db.food_combo.Where(x => x.comboID == comboID);
            foreach (var i in foodjoined)
            {
                listFood1.Add(i.foodID);
            }
            // get all food not joined with combo
            var subselect = (from b in db.food_combo select b.food.name).ToList();

            var result = from c in db.foods where !subselect.Contains(c.name) select c;
            foreach (var i in result)
            {
                listFood2.Add(i.id);
            }

        }

        public void FillArray()
        {
            listFood1 = new ArrayList();
            listFood2 = new ArrayList();
            OrderSystemEntities db = new OrderSystemEntities();

            var foodList = db.foods;
            foreach (var i in foodList)
            {
                listFood2.Add(i.id);
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
            //foreach (food_combo item in db.food_combo)
            //{
            //    int index = checkedListBox1.Items.IndexOf(item.foodID);

            //    if (index >= 0)
            //    {
            //        checkedListBox1.SetItemChecked(index, true);
            //    }
            //}

            //fill combo
            foreach (var i in db.comboes)
            {
                listBoxCombo.Items.Add(i);
            }
        }


        private void AddEditModeOn(bool addMode)
        {
            buttonConfirm.Visible = true;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonBack.Visible = true;
            
            if (addMode)
            {
                buttonConfirm.Text = "Add";
                
                FillForm();
            }
            else
            {
                string temp = "";
                
                FillForm();
            }

            listBoxCombo.Enabled = false;
            labelSearch.Visible = true;
            textBoxSearch.Visible = true;
        }

        private void AddEditModeOff()
        {
            buttonConfirm.Visible = false;
            buttonEdit.Visible = true;
            buttonDelete.Visible = true;
            buttonBack.Visible = false;
           
            if (buttonConfirm.Text.Equals("Add")) buttonConfirm.Text = "Confirm";
            listBoxCombo.Enabled = true;
            labelSearch.Visible = false;
            textBoxSearch.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddEditModeOn(true);
           
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            AddEditModeOn(false);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            AddEditModeOff();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //add function
            if (buttonConfirm.Text.Equals("Add"))
            {

            }
            //edit function
            else
            {

            }
        }

        private combo parseInputToCombo()
        {
            comboTemp = new combo();

            comboTemp.id = textBoxID.Text.Trim();
            comboTemp.name = textBoxName.Text.Trim();
            comboTemp.description = textBoxDescription.Text.Trim();
            comboTemp.price = float.Parse(textBoxPrice.Text);
            comboTemp.discount_price = float.Parse(textBoxDiscount.Text);

            return comboTemp;
        }

        private void buttonRemoveFood_Click(object sender, EventArgs e)
        {
        }

        private void buttonAddFood_Click(object sender, EventArgs e)
        {
            listFood2.Remove(foodSelected);
            listFood1.Add(foodSelected);
            FillArray();
        }

        private void listBoxCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBox1.ClearSelected();
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
                            }
                        }
                    }

                }
            }
        }
    }
}