using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COID_System.dao;
using System.Collections;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Reflection;
using COID_System.Entity;

namespace COID_System
{
    public partial class CategoryForm : Form
    {
        private category categoryModel;
        private bool AddMode; 
        public CategoryForm()
        {
            InitializeComponent();
           categoryModel = new category();
           AddMode = false;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.AutoGenerateColumns = false;
            fillGrip();
        }

        private OrderSystemEntities db;
        void fillGrip()
        {
            
              //  dataGridView1.DataSource = db.categories.ToList<category>();
                db = new OrderSystemEntities();
                db.categories.Load();
                this.dataGridView1.DataSource = db.categories.Local.ToBindingList();
            
        }

        private void dataGridView1_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                categoryModel.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                using (OrderSystemEntities db = new OrderSystemEntities())
                {
                    categoryModel = db.categories.FirstOrDefault(x => x.id == categoryModel.id);
                    textBoxName.Text = categoryModel.name;
                    textBoxDescription.Text = categoryModel.description;
                    
                }
                buttonAdd.Text = "Update";
                deleteButton.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (AddMode == false)
            {
                textBox1.ReadOnly = false;
                textBoxDescription.ReadOnly = false;
                textBoxName.ReadOnly = false;
                buttonAdd.Text = "Confirm";
                AddMode = true;
                buttonEdit.Enabled = false;
                deleteButton.Enabled = false;
            }
            else
            {
                categoryModel.id = Convert.ToInt32(textBox1.Text.Trim());
                categoryModel.name = textBoxName.Text.Trim();
                categoryModel.description = textBoxDescription.Text.Trim();

                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    db.categories.Add(categoryModel);

                    db.SaveChanges();
                }
                MessageBox.Show("done!");
                Clear();
            }
            
        }

        void Clear()
        {
            textBox1.Text = textBoxDescription.Text = textBoxName.Text = "";
            fillGrip();
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            categoryModel.name = textBoxName.Text.Trim();
            categoryModel.description = textBoxDescription.Text.Trim();

            using (OrderSystemEntities db = new OrderSystemEntities())
            {

                db.Entry(categoryModel).State = EntityState.Modified;

                db.SaveChanges();
            }
            Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure to Delete this Record ?", "EF CRUD Operation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (OrderSystemEntities db = new OrderSystemEntities())
                {
                    var entry = db.Entry(categoryModel);
                    if (entry.State == EntityState.Detached)
                        db.categories.Attach(categoryModel);
                    db.categories.Remove(categoryModel);
                    db.SaveChanges();
               
                    Clear();
                    MessageBox.Show("Deleted Successfully");
                }
            }
        }

        private void categoryBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                categoryModel.id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
                using (OrderSystemEntities db = new OrderSystemEntities())
                {
                    categoryModel = db.categories.FirstOrDefault(x => x.id == categoryModel.id);
                    textBoxName.Text = categoryModel.name;
                    textBoxDescription.Text = categoryModel.description;
                    textBox1.Text = categoryModel.id.ToString();

                }
                buttonEdit.Enabled = true;
                deleteButton.Enabled = true;

                AddMode = false;
                buttonAdd.Text = "Add";
                textBox1.ReadOnly = true;
                textBoxDescription.ReadOnly = true;
                textBoxName.ReadOnly = true;
            }
        }
    }
}