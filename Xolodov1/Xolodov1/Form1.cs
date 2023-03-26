using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xolodov1
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

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = listBox1.Text;
            int L = str.Length;
            int k = 0;
            for (int i = 0; i < L; i++)
                if (str[i] == ' ')
                    k++;
            data.Value = k.ToString();
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = listBox1.Text;
            str = new string(str.ToCharArray().Reverse().ToArray());
            data.Value = str.ToString();
            Form2 newForm = new Form2();
            newForm.ShowDialog();
        }
    }
}
