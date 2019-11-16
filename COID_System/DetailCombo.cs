using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


        void fillCombo()
        {
            OrderSystemEntities db = new OrderSystemEntities();
            foreach (var i in db.comboes)
            {
                listBox1.Items.Add(i);
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

        public void ShowFoodList()
        {
            listBoxFood2.Items.Clear();
            listBoxFood1.Items.Clear();
            foreach (food_combo i in listFood1)
            {
                listBoxFood1.Items.Add(i);
            }


            foreach (food_combo i in listFood2)
            {
                listBoxFood2.Items.Add(i);
            }
        }


        private void AddEditModeOn(bool addMode)
        {
            buttonAddFood.Visible = true;
            buttonRemoveFood.Visible = true;
            buttonConfirm.Visible = true;
            buttonEdit.Visible = false;
            buttonDelete.Visible = false;
            buttonBack.Visible = true;
            listBoxFood2.Visible = true;
            if (addMode)
            {
                buttonConfirm.Text = "Add";
                FillArray();
                ShowFoodList();
            }
            else
            {
                string temp = "";
                FillArray(temp);
                ShowFoodList();
            }

            listBox1.Enabled = false;
            labelSearch.Visible = true;
            textBoxSearch.Visible = true;
        }

        private void AddEditModeOff()
        {
            buttonAddFood.Visible = false;
            buttonRemoveFood.Visible = false;
            buttonConfirm.Visible = false;
            buttonEdit.Visible = true;
            buttonDelete.Visible = true;
            buttonBack.Visible = false;
            listBoxFood2.Visible = false;
            if (buttonConfirm.Text.Equals("Add")) buttonConfirm.Text = "Confirm";
            listBox1.Enabled = true;
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

        private void listBoxFood2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFood2.SelectedIndex > -1)
            {
                food_combo foodSelected = (food_combo) listBoxFood2.SelectedItem;
                buttonAddFood.Enabled = true;
            }
        }

        private void listBoxFood1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFood1.SelectedIndex > -1)
            {
                food_combo foodSelected = (food_combo) listBoxFood1.SelectedItem;
                buttonRemoveFood.Enabled = true;
            }
        }
    }
}