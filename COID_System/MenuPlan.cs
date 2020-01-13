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
            loadMenuToComboBox();
        }

        public void loadMenuToComboBox()
        {
            OrderSystemEntities db = new OrderSystemEntities();
            foreach (var i in db.menus)
            {
                comboBoxBreakfast.Items.Add(i.menu_name);
                comboBoxLunch.Items.Add(i.menu_name);
                comboBoxDinner.Items.Add(i.menu_name);

            }

        }

       

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            OrderSystemEntities db = new OrderSystemEntities();
            
            time_menu date = db.time_menu.FirstOrDefault(x => x.date_service == monthCalendar1.SelectionRange.Start);
            if (date != null)
            {
                if (date.breakfast_mId == null)
                {
                    comboBoxBreakfast.Text = "Empty";
                }
                else
                {
                   
                    comboBoxBreakfast.Text = date.menu.menu_name.ToString();
                }
                if (date.lunch_mId == null)
                {
                    comboBoxLunch.Text = "Empty";
                }
                else
                {
                   
                    comboBoxLunch.Text = date.menu1.menu_name.ToString();
                }
                if (date.dinner_mId == null)
                {
                    comboBoxDinner.Text = "Empty";
                }
                else
                {
                   
                    comboBoxDinner.Text = date.menu2.menu_name.ToString();
                }
            }
            else
            {
                comboBoxBreakfast.Text = "Empty";
                comboBoxLunch.Text = "Empty";
                comboBoxDinner.Text = "Empty";
            }
            

            
            
            
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {



            listBox1.Items.Clear();
            
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
                listBox1.Items.Add(i);
            }
        }
    }
}
