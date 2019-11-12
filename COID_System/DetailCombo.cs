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
    public partial class DetailCombo : UserControl
    {
        public DetailCombo()
        {
            InitializeComponent();
        }

        public event EventHandler FoodClicked;
        private combo comboTemp;

        private void buttonFood_Click(object sender, EventArgs e)
        {
            OnUserControlButtonClick();
        }

        private void OnUserControlButtonClick()
        {
            if (FoodClicked != null)
            {
                FoodClicked(this, EventArgs.Empty);
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
            if (addMode == true) buttonConfirm.Text = "Add";
            listBox1.Enabled = false;
            labelSearch.Visible = true;


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
    }
}
