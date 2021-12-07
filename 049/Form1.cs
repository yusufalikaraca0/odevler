using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _049
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                int baslangic = int.Parse(txtbaslnagic.Text);
                int bitis =int.Parse(textBox1.Text);
                for (int i = baslangic; i < bitis; i++)
                {
                    string text = i.ToString();
                    int toplam = 0;
                    for (int j = 0; j < text.Length; j++)
                    {
                        toplam += int.Parse(text.Substring(j, 1));
                        
                    }
                    if (i % toplam == 0)
                        listBox1.Items.Add(i+" | "+toplam);
                    //MessageBox.Show("toplam = " + toplam.ToString() + " sayi =" + i.ToString() + " sonuc = " + (i % toplam).ToString());
                    //MessageBox.Show(toplam.ToString()+" number is = "+i.ToString());
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Geçersiz Argüment");
                MessageBox.Show(err.Message);
            }
        }

        private void txtbaslnagic_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(txtbaslnagic.Text == "Başlangıç")
            {
                txtbaslnagic.Text = "";
            }
        }

        private void textBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (txtbaslnagic.Text == "Bitiş")
            {
                txtbaslnagic.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            
            
        }
    }
}
