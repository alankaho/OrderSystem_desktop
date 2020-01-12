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
    public partial class MenuPlan : Form
    {
        public MenuPlan()
        {
            InitializeComponent();
        }

        public void loadform()
        {
            
        }

       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            OrderSystemEntities db = new OrderSystemEntities();

            var foodlist = db.foods.Where(r => r.disable == false);
            var combolist = db.comboes.Where(r => r.disable == false);


            foreach (var i in foodlist)
            {
                listBox1.Items.Add(i);
            }


            //fill combo checklist

            foreach (var i in combolist)
            {
                listBox2.Items.Add(i);
            }
        }
    }
}
