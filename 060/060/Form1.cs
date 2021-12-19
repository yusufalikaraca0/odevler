using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _060
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Kopyalandı!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            byte[] array = Encoding.ASCII.GetBytes(metin);
            foreach (byte i in array)
            {
                // MessageBox.Show(i.ToString()+" = "+Convert.ToChar(i));
                textBox2.Text += Convert.ToChar(i+5);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            byte[] array = Encoding.ASCII.GetBytes(metin);
            foreach (byte i in array)
            {
                // MessageBox.Show(i.ToString()+" = "+Convert.ToChar(i));
                textBox2.Text += Convert.ToChar(i - 5);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;
            byte[] array = Encoding.Unicode.GetBytes(metin);
            foreach (byte i in array)
            {
                // MessageBox.Show(i.ToString()+" = "+Convert.ToChar(i));
                textBox2.Text += Convert.ToChar(i+5);
            }
        }
    }
}
