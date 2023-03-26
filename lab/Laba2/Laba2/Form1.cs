using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba2
{
    public partial class Form1 : Form
    {
        int j;
        double result;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            j = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            j = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(textBoxR.Text);
            int n = Convert.ToInt32(textBoxN.Text);
            double z = 0;
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            double c = Convert.ToDouble(textBoxc.Text);
            double d = Convert.ToDouble(textBoxd.Text);

            switch (j)
            {
                case 1:
                    result = 1;
                    break;
                case 2:
                    result = 2;
                    break;
                default:
                    MessageBox.Show("Не выбрана формула");
                    break;
            }
            textBoxZ.Text = "Z = " + result.ToString();

                

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
