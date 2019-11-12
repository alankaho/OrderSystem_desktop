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

        public CategoryDetail()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        

        public void FillGrip()
        {
            
            textBox1.Text = textBox2.Text = textBox3.Text = "";
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


    }
}
