using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int kolon = 0;
        int satir = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            


        }
        private void button3_Click(object sender, EventArgs e)
        {


            int uzunluk = Convert.ToInt32(textBox1.Text);
            string[,] kupon = new string[uzunluk, uzunluk];
            string[] satirarray = textBox4.Text.Split(',');
            string toplam = "";
            for (int i = 0; i < satirarray.Length; i++)
            {
                
                kupon[satir, i] = satirarray[i];
                toplam += satirarray[i] + " | ";
            }
            listBox1.Items.Add(toplam);
            if(listBox1.Items.Count >= uzunluk){
                string[,] loto = new string[uzunluk, uzunluk];
                for (int i = 0; i < uzunluk; i++)
                {
                    string toplam2 = "";
                    for (int j = 0; j < uzunluk; j++)
                    {
                        loto[i, j] = random.Next(90).ToString();
                        toplam2 += loto[i, j] + " | ";


                    }
                    listBox2.Items.Add(toplam2);
                }
                int sutun_kontrol = 0;
                int satir_kontrol = 0;
                int dogru_sayi = 0;
                int dogru_sutun = 0;
                for (int i = 0; i < uzunluk; i++)
                {
                    for (int j = 0; j < uzunluk; j++)
                    {
                        if(kupon[i,j] == loto[i, j])
                        {
                            dogru_sayi++;   
                        }
                       

                       
                    }
                    MessageBox.Show("satir");

                    satir_kontrol++;
                }
                MessageBox.Show("doğru tutan sayılar = "+satir_kontrol.ToString());
            }
            satir++;

        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
