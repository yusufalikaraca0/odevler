using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yrardim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] sayilar = new int[5];
        

        int min(int[] array)
        {
            int lower = 0;
            try
            {
                 lower = sayilar[0];
                foreach (var item in array)
                {
                    if (lower > item) lower = item;
                }
                return lower;
            }
            catch (Exception)
            {
                MessageBox.Show("error");

            }
            return lower;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int len = sayilar.Length;
            int[] gecici = sayilar;
            for (int i = 0; i < len; i++)
            {
                MessageBox.Show("Test");
                gecici[i] = min(sayilar);
                sayilar = sayilar.Where(val => val != min(sayilar)).ToArray();
            }
            foreach (int item in gecici)
            {
                listBox2.Items.Add(item.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        Random random = new Random();
        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < sayilar.Length; i++)
            {
               sayilar[i] = random.Next(100);
            }
            foreach (var item in sayilar)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
