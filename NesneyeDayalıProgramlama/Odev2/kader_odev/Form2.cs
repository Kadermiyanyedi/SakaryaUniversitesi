/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 2
**				ÖĞRENCİ ADI............: Kader MİYANYEDİ
**				ÖĞRENCİ NUMARASI.......: B191210380
**              DERSİN ALINDIĞI GRUP...: 1C
****************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kader_odev
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
      
        }
        int toplam1, toplam2;

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Son butonuna basılırsa programdan çıkar.
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
          //form1'deki textboxlara yazılan değerleri bu formdaki textboxlara yazdırdım.
            textBox11.Text = Form1.x;
            textBox21.Text = Form1.y;

            
            int sayi1, sayi2;
           
            sayi1 = Convert.ToInt32(textBox11.Text);
            sayi2 = Convert.ToInt32(textBox21.Text);
            
            //Girilen x sayısının tam bölenlerini bulup ekrana yazan for döngüsü
            for (int i = 1; i < sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    listBox1.Items.Add(Convert.ToString(i));
                    toplam1 = toplam1 + i;
                    textBox3.Text = Convert.ToString(toplam1);
                }
            }
            //Girilen y sayısının tam bölenlerini bulup ekrana yazan for döngüsü
            for (int i = 1; i < sayi2; i++)
            {
                if (sayi2 % i == 0)
                {
                    listBox2.Items.Add(Convert.ToString(i));
                    toplam2 = toplam2 + i;
                    textBox4.Text = Convert.ToString(toplam2);
                }
            }
           
            
        }
    }
}
