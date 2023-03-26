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

namespace Lab1.person
{
    public partial class Form1 : Form
    {
        double w, g, q, numE, o;
        double t;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            w = Int32.Parse(textBox1.Text);
            numE = Int32.Parse(textBox2.Text);
            o = Int32.Parse(textBox3.Text);
            try 
            {
                t = w + (Math.Cos(g * q) / w) - numE + Math.Sin(numE) + Math.Abs(Math.Sqrt(o));
                Text = string.Format("Результат: t = {0}", t);
            }
            catch
            {
                Text = string.Format("ERROR");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox4.Text = "3,4";
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Text = string.Format("Координаты: {0};{1}", e.X, e.Y);
            label1.Text = string.Format("Координаты: {0};{1}", e.X, e.Y);
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            g = e.X;
            q = e.Y;
            label2.Text = string.Format("g = {0}", g);
            label3.Text = string.Format("q = {0}", q);
        }
    }
}
