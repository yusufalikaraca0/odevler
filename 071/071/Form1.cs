using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _071
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                private void button2_Click(object sender, EventArgs e)
        {
                    }
        string islem = "";
        public class islemler
        {
            int a;
            int b;
            public islemler(int x,int y)
            {
                a = x;
                b = y;
            }
            public int topla()
            {
                return a + b;
            }
            public int cikar()
            {
                return a - b;
            }
            public int carp()
            {
                return a * b;
            }
            public decimal bol()
            {
                return a / b;
            }
            public decimal mod()
            {
                return a % b;
            }
            public string buyukOlaniBul()
            {
                int value = 0;
                if (a < b)
                    value = b;
                else if (a > b)
                    value = a;
                else
                    return "eşit";
                return value.ToString();
            }
            public decimal mutlak(decimal z)
            {
                return Math.Abs(z);
            }
            public string uzunolan(string h,string j)
            {
                if (h.Length > j.Length)
                    return h;
                else if (j.Length > h.Length)
                    return j;
                else
                    return "eşit";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            islemler i = new islemler(sayi1,sayi2);
            if (islem == "topla")
                label1.Text = i.topla().ToString();
            if (islem == "cikarma")
                label1.Text = i.cikar().ToString();
            if (islem == "carpma")
                label1.Text = i.carp().ToString();
            if (islem == "bolme")
                label1.Text = i.bol().ToString();
            if (islem == "mod")
                label1.Text = i.mod().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islem = "topla";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            islem = "cikarma";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            islem = "carpma";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            islem = "bolme";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            islem = "mod";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox3.Text);
            int sayi2 = int.Parse(textBox4.Text);
            islemler i = new islemler(sayi1, sayi2);
            label2.Text = i.buyukOlaniBul();

        }

        private void button8_Click(object sender, EventArgs e)
        {
          
            islemler i = new islemler(0, 0);
            label3.Text = (i.mutlak(decimal.Parse(textBox5.Text))).ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            islemler i = new islemler(0, 0);
            label4.Text = i.uzunolan(textBox6.Text, textBox7.Text);
        }
    }
}
