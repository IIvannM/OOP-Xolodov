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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double y = Convert.ToDouble(textBoxY.Text);
            double d = Convert.ToDouble(textBoxd.Text);

            try
            {
                int n = Convert.ToInt32(comboBox1.Text);
                int r = Convert.ToInt32(comboBox2.Text);
                double z = 0;
                int k = 3;
                if (radioButton1.Checked)
                {

                    double x = Convert.ToDouble(textBoxX.Text);
                    int x0 = 1;
                    for (int i = 0; i < n; i++)
                    {
                        if (i % 2 == 0)
                        {
                            z += Math.Round(Math.Pow(x, i) / x0, 3);
                        }
                        else
                        {
                            z -= Math.Round(Math.Pow(x, i) / x0, 3);
                        }
                        k += 1;
                        x0 *= k;
                    }
                    textBoxZ.Text = z.ToString();
                }
                else if (radioButton2.Checked)
                {
                    double c = Convert.ToDouble(textBoxc.Text);
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= r; j++)
                        {
                            z += Math.Pow(j,2) + c * i / (Math.Pow(i, j) + d * j);
                        }
                    }
                    textBoxZ.Text = Math.Round(z, 3).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Перепроведь введённые данные");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
