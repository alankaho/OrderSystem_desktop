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
    public partial class FoodComboList : UserControl
    {
        public FoodComboList()
        {
            InitializeComponent();
            
            checkedListBox1 = null;
        }

        private OrderSystemEntities db;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        void FillListCombo()
        {

            //  dataGridView1.DataSource = db.categories.ToList<category>();
            db = new OrderSystemEntities();
            // db.comboes.Load();

            foreach (var i in db.comboes)
            {
                checkedListBox1.Items.Add(i);
            }



        }
    }
}
