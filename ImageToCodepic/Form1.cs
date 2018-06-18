using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToCodepic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageBtn_Click(object sender, EventArgs e)
        {
            if (openImageFileDialog.ShowDialog() == DialogResult.OK)
            {

                generateProgressBar.Value = 0;
                //MessageBox.Show(openImageFileDialog.FileName);
                ImageToCode itc = new ImageToCode(this);
                showCodePicTextbox.Text = itc.ToCodeFromImage(Image.FromFile(openImageFileDialog.FileName));
            }
        }
        public void setProgressBar(int p)
        {
            generateProgressBar.Value = p;
        }
    }
}
