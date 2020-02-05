using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COID_System.Entity;

namespace COID_System
{
    public partial class Login : Form
    {
        private MainForm mf;
        public Login()
        {
           
            
            InitializeComponent();
            textBoxPass.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String username = textBoxName.Text;
            String pass = textBoxPass.Text; 
            user name = DAOuser.LoginCheck(username,pass);
            if (name != null)
            {
                this.Hide();
                if (name.role == 1)
                {
                    MessageBox.Show("Welcome manager " + name.name);
                }
                else
                {
                    MessageBox.Show("Welcome employee " + name.name);
                }
                
                mf = new MainForm();
                mf.Show();
            }
            
            



        }
    }
}
