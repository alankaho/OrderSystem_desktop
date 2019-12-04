using COID_System.Entity;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace COID_System
{
    public partial class DetailFoods : UserControl
    {
        private OrderSystemEntities db;
        private bool addMode { get; set; }
        private bool editMode { get; set; }
        private food foodSelected;
        public event EventHandler ComboClicked;
        public event EventHandler CategoryClicked;


        public DetailFoods()
        {

            InitializeComponent();
            
        }


        public void loadForm()
        {
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
            listBoxFood.Items.Clear();
            comboBoxCategory.Items.Clear();
            db = new OrderSystemEntities();
            var foods = db.foods.Where(r => r.disable == false);
            foreach (var i in foods)
            {
                listBoxFood.Items.Add(i.name);
            }

            foreach (var i in db.categories)
            {

                comboBoxCategory.Items.Add(i.name);
            }

            listBoxFood.Enabled = true;

        }





        //update info to textbox based on selected food
        private void listBox1_Click(object sender, EventArgs e)
        {
            if (listBoxFood.SelectedIndex > -1 && editMode == false)
            {
                foodSelected = new food
                {
                    name = listBoxFood.GetItemText(listBoxFood.SelectedItem)
                };
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
                     food foodInput = parseInputToFood();
                    using (OrderSystemEntities db = new OrderSystemEntities())
                    {
                        
                        foodSelected.disable = true;
                        db.Entry(foodSelected).State = EntityState.Modified;
                        db.SaveChanges();
                        FillListFood();
                        offMode();

                        MessageBox.Show("Deleted Successfully");
                    }
                }
            }

        }
        //confirm button + edit button
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

                food foodInput = parseInputToFood();

                using (OrderSystemEntities db = new OrderSystemEntities())
                {
                    
                    foodSelected.disable = true;
                    db.Entry(foodSelected).State = EntityState.Modified;
                    db.SaveChanges();

                    db.foods.Add(foodInput);
                    db.SaveChanges();
                }
                offMode();
                FillListFood();
                MessageBox.Show("done!");
            }

            return;
        }

        public void editModeOn()
        {
           
            {
                textBoxName.ReadOnly = false;
                textBoxDescription.ReadOnly = false;
                textBoxPrice.ReadOnly = false;
                textBoxID.ReadOnly = false;
              
                buttonAdd.Enabled = false;
                editMode = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button1.Text = "Cancel";
                button2.Text = "Confirm";
                listBoxFood.Enabled = false;
            }

        }

        public void categoryMode()
        {

            {
                buttonCombo.Enabled = false;
                textBoxName.ReadOnly = false;
                textBoxDescription.ReadOnly = false;
                textBoxPrice.ReadOnly = false;
                textBoxID.ReadOnly = false;
               
                buttonAdd.Enabled = false;
                editMode = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button1.Text = "Cancel";
                button2.Text = "Confirm";
                listBoxFood.Enabled = false;
            }

        }



        public void offMode()
        {
            textBoxName.ReadOnly = true;
            textBoxDescription.ReadOnly = true;
            textBoxPrice.ReadOnly = true;
            textBoxID.ReadOnly = true;
           
            textBoxName.Text = textBoxDescription.Text = textBoxPrice.Text = textBoxID.Text = comboBoxCategory.Text= "";
            listBoxFood.Enabled = true;
            addMode = false;
            editMode = false;
            button2.Text = "Edit";
            button1.Text = "Delete";
            
            button1.Enabled = false;
            button2.Enabled = false;
            buttonAdd.Enabled = true;
        }

        private food parseInputToFood()
        {
            category category = new category();
            category = db.categories.FirstOrDefault(x => x.name == comboBoxCategory.Text);
            food inputToFood = new food();
            inputToFood.id = textBoxID.Text.Trim();
            inputToFood.name = textBoxName.Text.Trim();
            inputToFood.description = textBoxDescription.Text.Trim();
            inputToFood.price = float.Parse(textBoxPrice.Text);
            inputToFood.categoryID = category.id;
            inputToFood.disable = false;
            return inputToFood;
        }

        private void buttonCombo_Click(object sender, EventArgs e)
        {
            if (ComboClicked != null)
            {
                ComboClicked(this, EventArgs.Empty);
            }

        }

        

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            if (CategoryClicked != null)
            {
                CategoryClicked(this, EventArgs.Empty);
            }
        }
    }
}
