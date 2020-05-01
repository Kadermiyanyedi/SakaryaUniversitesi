/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: Proje
**				ÖĞRENCİ ADI............: Kader Miyanyedi
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atik_Projesi
{
    public partial class Form1 : Form
    {

        Atik randomAtik;
        List<Button> atikKutusuButonlari = new List<Button>();
        List<Atik> atikListesi = new List<Atik>();
        //atiklar
        Atik domates = new Domates(150, Image.FromFile("DOMATES.jpg"),"Domates","organik");
        Atik salatalik = new Salatalik(120, Image.FromFile("SALATALIK.jpg"),"Salatalik","organik");
        Atik camSise = new CamSise(600, Image.FromFile("CAMSISE.jpg"),"Cam Şişe","cam");
        Atik bardak = new Bardak(250, Image.FromFile("BARDAK.jpg"),"Bardak","cam");
        Atik kolaKutusu = new KolaKutusu(350, Image.FromFile("KOLAKUTUSU.jpg"),"Kola Kutusu","metal");
        Atik salcaKutusu = new SalcaKutusu(550, Image.FromFile("SALCAKUTUSU.jpg"),"Salca Kutusu","metal");
        Atik dergi = new Dergi(200, Image.FromFile("DERGI.jpeg"),"Dergi","kagit");
        Atik gazete = new Gazete(250,Image.FromFile("GAZETE.jpg"),"Gazete","kagit");
        //atik kutulari
        AtikKutusu organikAtikKutusu = new OrganikAtikKutusu(0,700,0,0);
        AtikKutusu camAtikKutusu = new CamAtikKutusu(600,2200,0,0);
        AtikKutusu kagitAtikKutusu = new KagitAtikKutusu(1000,1200,0,0);
        AtikKutusu metalAtikKutusu = new MetalAtikKutusu(800,2300,0,0);

        int puan = 0;
        int sure = 60;
        //fonksiyonlar
        //atik kutularini aktif veya deaktif etmek icin kullanilir
        public void AtikKutusuAktifDeaktif(List<Button> bttns,bool config)
        {
            AtikKutusuButonlariniEkler();
            foreach (var btn in bttns)
            {
                btn.Enabled = config;
            }
        }
        //progressbarlari guncelle
        public void ProgressBarlariGuncelle()
        {
            progressBarCam.Value = camAtikKutusu.DolulukOrani;
            progressBarKagit.Value = kagitAtikKutusu.DolulukOrani;
            progressBarMetal.Value = metalAtikKutusu.DolulukOrani;
            progressBarOrganik.Value = organikAtikKutusu.DolulukOrani;
        }
        //hacimleri 0 la
        public void DoluHacimleriSifirla()
        {
            organikAtikKutusu.DoluHacim = 0;
            camAtikKutusu.DoluHacim = 0;
            metalAtikKutusu.DoluHacim = 0;
            kagitAtikKutusu.DoluHacim = 0;
        }
        private void AtikKutusuButonlariniEkler()
        {
            atikKutusuButonlari.Add(buttonBosaltCam);
            atikKutusuButonlari.Add(buttonBosaltKagit);
            atikKutusuButonlari.Add(buttonBosaltMetal);
            atikKutusuButonlari.Add(buttonBosaltOrganik);
            atikKutusuButonlari.Add(buttonEkleCam);
            atikKutusuButonlari.Add(buttonEkleKagit);
            atikKutusuButonlari.Add(buttonEkleMetal);
            atikKutusuButonlari.Add(buttonEkleOrganik);
        }
        public void AtiklariListeyeEkle()
        {
            atikListesi.Add(domates);
            atikListesi.Add(salatalik);
            atikListesi.Add(camSise);
            atikListesi.Add(bardak);
            atikListesi.Add(kolaKutusu);
            atikListesi.Add(salcaKutusu);
            atikListesi.Add(dergi);
            atikListesi.Add(gazete);
        }
        public Atik RandomAtikUretVeFotografDegistir(List<Atik> atik)
        {
            Thread.Sleep(412);
            int randomSayi = new Random().Next(0, 8);
            pictureBox1.Image = atik[randomSayi].Image;
            return atik[randomSayi];
        }
        public void ListboxlariSifirla()
        {
            listBoxCam.Items.Clear();
            listBoxKagit.Items.Clear();
            listBoxMetal.Items.Clear();
            listBoxOrganik.Items.Clear();
        }
        public void PuaniGuncelle()
        {
            puan += randomAtik.Hacim;
            labelPuan.Text = Convert.ToString(puan);
        }
        public Form1()
        {
            InitializeComponent();
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure -= 1;
            labelSure.Text = Convert.ToString(sure);
            if (sure == 0){
                timer1.Stop();
                AtikKutusuAktifDeaktif(atikKutusuButonlari,false);
                ProgressBarlariGuncelle();
                buttonYeniOyun.Enabled = true;

            } 
        }
        //yeni oyun a tikladigimizda atik kutularinin eski dolu hacimleri 0 lanir
        //progress barlar guncellenir
        //listboxlari 0 lar
        //random atik olusur ve imagesi gelir
        //atik kutularinin gerekli butonlari aktif olur
        //yeni oyun butonu deaktif olur
        //sure 60 dan geriye saymaya baslar
        private void buttonYeniOyun_Click(object sender, EventArgs e)
        {
            sure = 60;
            timer1.Interval = 1000;
            DoluHacimleriSifirla();
            ListboxlariSifirla();
            ProgressBarlariGuncelle();
            randomAtik = RandomAtikUretVeFotografDegistir(atikListesi);
            AtikKutusuAktifDeaktif(atikKutusuButonlari, true);
            buttonYeniOyun.Enabled = false;
            timer1.Start();
        }

        private void buttonCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ORGANIK
        private void buttonEkleOrganik_Click(object sender, EventArgs e)
        {
            if ((randomAtik.Equals(domates)||randomAtik.Equals(salatalik))&&organikAtikKutusu.Ekle(randomAtik))
            {
                listBoxOrganik.Items.Add(randomAtik.ToString());
                organikAtikKutusu.DoluHacim += randomAtik.Hacim;
                ProgressBarlariGuncelle();
                PuaniGuncelle();
                randomAtik=RandomAtikUretVeFotografDegistir(atikListesi);
            }
        }

        private void buttonBosaltOrganik_Click(object sender, EventArgs e)
        {
            if (organikAtikKutusu.Bosalt())
            {
                organikAtikKutusu.DoluHacim = 0;
                listBoxOrganik.Items.Clear();
                ProgressBarlariGuncelle();
                puan += organikAtikKutusu.BosaltmaPuani;
                sure += 3;
            }
        }
        //KAGIT
        private void buttonEkleKagit_Click(object sender, EventArgs e)
        {
            if ((randomAtik.Equals(dergi)||randomAtik.Equals(gazete))&&kagitAtikKutusu.Ekle(randomAtik))
            {
                listBoxKagit.Items.Add(randomAtik.ToString());
                kagitAtikKutusu.DoluHacim += randomAtik.Hacim;
                ProgressBarlariGuncelle();
                PuaniGuncelle();
                randomAtik = RandomAtikUretVeFotografDegistir(atikListesi);
            }
        }
        
        private void buttonBosaltKagit_Click(object sender, EventArgs e)
        {
            if (kagitAtikKutusu.Bosalt())
            {
                kagitAtikKutusu.DoluHacim = 0;
                listBoxKagit.Items.Clear();
                ProgressBarlariGuncelle();
                puan += kagitAtikKutusu.BosaltmaPuani;
                sure += 3;
            }
        }
        //CAM
        private void buttonEkleCam_Click(object sender, EventArgs e)
        {
            if ((randomAtik.Equals(bardak) || randomAtik.Equals(camSise)) && camAtikKutusu.Ekle(randomAtik))
            {
                listBoxCam.Items.Add(randomAtik.ToString());
                camAtikKutusu.DoluHacim += randomAtik.Hacim;
                ProgressBarlariGuncelle();
                PuaniGuncelle();
                randomAtik = RandomAtikUretVeFotografDegistir(atikListesi);
            }
        }

        private void buttonBosaltCam_Click(object sender, EventArgs e)
        {
            if (camAtikKutusu.Bosalt())
            {
                camAtikKutusu.DoluHacim = 0;
                listBoxCam.Items.Clear();
                ProgressBarlariGuncelle();
                puan += camAtikKutusu.BosaltmaPuani;
                sure += 3;
            }
        }
        //METAL
        private void buttonEkleMetal_Click(object sender, EventArgs e)
        {
            if ((randomAtik.Equals(kolaKutusu) || randomAtik.Equals(salcaKutusu)) && metalAtikKutusu.Ekle(randomAtik))
            {
                listBoxMetal.Items.Add(randomAtik.ToString());
                metalAtikKutusu.DoluHacim += randomAtik.Hacim;
                ProgressBarlariGuncelle();
                PuaniGuncelle();
                randomAtik = RandomAtikUretVeFotografDegistir(atikListesi);
            }
        }

        private void buttonBosaltMetal_Click(object sender, EventArgs e)
        {
            if (metalAtikKutusu.Bosalt())
            {
                metalAtikKutusu.DoluHacim = 0;
                listBoxMetal.Items.Clear();
                ProgressBarlariGuncelle();
                puan += metalAtikKutusu.BosaltmaPuani;
                sure += 3;
            }
        }
        //FORM1
        private void Form1_Load(object sender, EventArgs e)
        {
            AtikKutusuAktifDeaktif(atikKutusuButonlari, false);
            AtiklariListeyeEkle();
        }
    }
}
