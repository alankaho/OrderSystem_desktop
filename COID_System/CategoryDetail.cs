using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COID_System.Entity;

namespace COID_System
{
    public partial class CategoryDetail : UserControl
    {
        private OrderSystemEntities db;
        public event EventHandler hideClicked;
        private category categoryTemp;

        public CategoryDetail()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            category temp = praseInputToCategory();
            using (OrderSystemEntities db = new OrderSystemEntities())
            {

                db.categories.Add(temp);

                db.SaveChanges();
            }
            FillGrip();
            MessageBox.Show("done!");
            return;
        }

        

        public void FillGrip()
        {
            
            textBoxName.Text = textBoxID.Text = textBoxDescription.Text = "";
            listBox1.Items.Clear();
            db = new OrderSystemEntities();
            foreach (var i in db.categories)
            {
                listBox1.Items.Add(i);
            }

            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (hideClicked != null)
            {
                hideClicked(this, EventArgs.Empty);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            category temp = praseInputToCategory();


            using (OrderSystemEntities db = new OrderSystemEntities())
            {

                db.Entry(temp).State = EntityState.Modified;

                db.SaveChanges();
            }
            
            FillGrip();
            MessageBox.Show("done!");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                categoryTemp = new category();
                string categoryName = listBox1.GetItemText(listBox1.SelectedItem);



                using (OrderSystemEntities db = new OrderSystemEntities())
                {

                    categoryTemp = db.categories.FirstOrDefault(x => x.name == categoryName);
                    textBoxName.Text = categoryTemp.name;

                    textBoxDescription.Text = categoryTemp.description;
                    textBoxID.Text = categoryTemp.id.ToString();


                }
            }
            
        }

        private category praseInputToCategory()
        {
            category temp = new category();
            temp.id = Int32.Parse(textBoxID.Text);
            temp.name = textBoxName.Text;
            temp.description = textBoxDescription.Text;
            return temp;
        }
    }
}
