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

        private void button1_Click(object sender, EventArgs e)
        {

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
                    category = db.categories.FirstOrDefault(x => x.id == foodSelected.categoryID);
                    comboBoxCategory.Text = category.name;

                    button1.Enabled = true;

                    button2.Enabled = true;
                }
            }


        }
    }
}
