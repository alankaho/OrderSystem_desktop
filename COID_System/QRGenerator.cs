using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace COID_System
{
    
    public partial class QRGenerator : Form
    {
        
        public QRGenerator()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var img = new Bitmap(pictureBox1.Image);
            saveFileDialog1.ShowDialog();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            QRCodeEncoder temp = new QRCodeEncoder();
            
            try
            {
                pictureBox1.Image = temp.Encode(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var img = new Bitmap(pictureBox1.Image);
            img.Save(saveFileDialog1.FileName,ImageFormat.Png);
        }
    }
}
