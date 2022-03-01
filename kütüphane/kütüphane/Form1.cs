using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace kütüphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList no = new ArrayList();
        ArrayList tc = new ArrayList();

        ArrayList isim = new ArrayList();
        ArrayList kitap = new ArrayList();
        int indexno = 0;    
        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        void update()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("İSİM|TC|NO|KİTAP");
            for (int i = 0; i < tc.Count; i++)
            {
                string toplam = "";
                toplam += isim[i] + "|";
                toplam += tc[i] + "|";
                toplam += no[i] + "|";
                toplam += kitap[i] + "|";
                listBox1.Items.Add(toplam);
                indexno++;
            }
          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            no.Add(textBox1.Text);
            tc.Add(textBox2.Text);
            isim.Add(textBox3.Text);
            kitap.Add(textBox4.Text);

            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            no.RemoveAt(int.Parse(textBox5.Text));
            tc.RemoveAt(int.Parse(textBox5.Text));
            isim.RemoveAt(int.Parse(textBox5.Text));
            kitap.RemoveAt(int.Parse(textBox5.Text));
            indexno--;

            update();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tc.Count.ToString());
            int silinecek = find(textBox6.Text, tc);
            tc.RemoveAt(silinecek);
            isim.RemoveAt(silinecek);
            kitap.RemoveAt(silinecek);
            no.RemoveAt(silinecek);

          
            indexno--;

            update();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tc.Remove(textBox7.Text);

            isim.Remove(textBox7.Text);
            kitap.Remove(textBox7.Text);
            no.Remove(textBox7.Text);
            indexno--;

            update();

        }
        int find(string findobject,ArrayList eray)
        {
            int toplam = 0;
            for (int i = 0; i < eray.Count; i++)
            {
                if(eray[i].ToString() == findobject)
                {
                toplam = i;
                }
            }
            return toplam;
        }
        private void button5_Click(object sender, EventArgs e)
        {
           if(comboBox1.Text == "tc")
            {
                //MessageBox.Show(find(textBox8.Text, tc).ToString());
                int arama = find(textBox8.Text, tc);
                tc.RemoveAt(arama);
                tc.Insert(arama,textBox9.Text);
            }
            else if (comboBox1.Text == "no")
            {
                int arama = find(textBox8.Text, no);
                no.RemoveAt(arama);
                no.Insert(find(textBox8.Text, no), textBox9.Text);
            }
            else if (comboBox1.Text == "kitap")
            {
                int arama = find(textBox8.Text, kitap);
                kitap.RemoveAt(arama);
                kitap.Insert(find(textBox8.Text, kitap), textBox9.Text);
            }
            else if (comboBox1.Text == "isim")
            {
                int arama = find(textBox8.Text, isim);
                isim.RemoveAt(arama);
                isim.Insert(find(textBox8.Text, isim), textBox9.Text);
            }
            update();
        }
    }
}
