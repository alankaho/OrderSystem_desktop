using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COID_System
{
    public partial class DetailCombo : UserControl
    {
        public DetailCombo()
        {
            InitializeComponent();
        }

        public event EventHandler FoodClicked;

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
    }
}
