using System;
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
    public partial class DetailFoods : UserControl
    {
        private OrderSystemEntities db;
        private bool addMode { get; set; }
        private bool editMode { get; set; }
        private food foodSelected;

        public DetailFoods()
        {

            InitializeComponent();
            FillListFood();
            addMode = false;
            editMode = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DetailFoods_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //turn on add mode
        private void button1_Click(object sender, EventArgs e)
        {
            if (addMode == false)
            {
                textBoxName.ReadOnly = false;
                textBoxDescription.ReadOnly = false;
                textBoxPrice.ReadOnly = false;
                textBoxID.ReadOnly = false;
               // comboBoxCategory.Enabled = true;
                buttonAdd.Enabled = false;
                addMode = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button1.Text = "Cancel";
                button2.Text = "Confirm";
                listBoxFood.Enabled = false;
            }
           
        }



        //fill data to Food List
        void FillListFood()
        {
            db = new OrderSystemEntities();
            foreach (var i in db.foods)
            {
                listBoxFood.Items.Add(i.name);
            }

            foreach (var i in db.categories)
            {

                comboBoxCategory.Items.Add(i.name);
            }

        }





        //update info to textbox base on selected food
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBoxFood.SelectedIndex > -1 && editMode == false)
            {
                foodSelected = new food();
                foodSelected.name = listBoxFood.GetItemText(listBoxFood.SelectedItem);
                category category = new category();


                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    foodSelected = db.foods.FirstOrDefault(x => x.name == foodSelected.name);
                    textBoxName.Text = foodSelected.name;
                    textBoxPrice.Text = foodSelected.price.ToString();
                    textBoxDescription.Text = foodSelected.description;
                    textBoxID.Text = foodSelected.id;
                    category = db.categories.FirstOrDefault(x => x.id == foodSelected.categoryID);
                    comboBoxCategory.Text = category.name;

                    button1.Enabled = true;

                    button2.Enabled = true;
                }
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (addMode == true)
            {
                AddModeOff();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (addMode == true)
            {
                category category = new category();
                category = db.categories.FirstOrDefault(x => x.name == comboBoxCategory.Text);
                foodSelected = new food();
                foodSelected.id = textBoxID.Text.Trim();
                foodSelected.name = textBoxName.Text.Trim();
                foodSelected.description = textBoxDescription.Text.Trim();
                foodSelected.price = float.Parse(textBoxPrice.Text);
                foodSelected.categoryID = category.id;
                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    db.foods.Add(foodSelected);

                    db.SaveChanges();
                }
                AddModeOff();
                
                MessageBox.Show("done!");
                return;
            }

            if (editMode == false)
            {
                editMode = true;

            }
        }

        void editModeOn
        {

        }

        void editModeOff
        {

        }

        private void AddModeOff()
        {
            textBoxName.ReadOnly = true;
            textBoxDescription.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
            textBoxID.ReadOnly = true;
            // comboBoxCategory.Enabled = true;
            listBoxFood.Enabled = true;
            addMode = false;
            button2.Text = "Delete";
            button1.Text = "Edit";
            button1.Enabled = false;
            button2.Enabled = false;
            buttonAdd.Enabled = true;
        }
    }
}
