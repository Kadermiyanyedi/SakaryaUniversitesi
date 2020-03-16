/****************************************************************************
**				        SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				    NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1
**				ÖĞRENCİ ADI............: Kader MİYANYEDİ
**				ÖĞRENCİ NUMARASI.......: B191210380
**              DERSİN ALINDIĞI GRUP...: 1.Öğretim C Grubu
****************************************************************************/

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections;

namespace NetCoreProject
{
    class B191210380_soru1
    {
        //if else ile ortalamaya uygun harf notunu döndürür
        //harf notunun kaç adet olduğunu saklar
        static string harf_notu_getir(double ortalama, int[] harf_sayilari)
        {
            if (ortalama >= 90){
                harf_sayilari[0] = harf_sayilari[0]+1;
                return "AA";
            }
                
            else if (ortalama >= 85){
                harf_sayilari[1] = harf_sayilari[1]+1;
                return "BA";
            }
                
            else if (ortalama >= 80){
                harf_sayilari[2] = harf_sayilari[2]+1;
                return "BB";
            }
                
            else if (ortalama >= 75){
                harf_sayilari[3] = harf_sayilari[3]+1;
                return "CB";
            }
                
            else if (ortalama >= 65){
                harf_sayilari[4] = harf_sayilari[4]+1;
                return "CC";
            }
                
            else if (ortalama >= 58){
                harf_sayilari[5] = harf_sayilari[5]+1;
                return "DC";
            }
                
            else if (ortalama >= 50){
                harf_sayilari[6] = harf_sayilari[6]+1;
                return "DD";
            }
                
            else if (ortalama >= 40){
                harf_sayilari[7] = harf_sayilari[7]+1;
                return "FD";
            }
                
            else{
                harf_sayilari[8] = harf_sayilari[8]+1;
                return "FF";
            }
        }
        static void Main(string[] args)
        {   
            int sinif_mevcut = 0;
            double ortalama = 0;
            int[] harf_sayilari = {0,0,0,0,0,0,0,0,0};
            string[] harfler = {"AA","BA","BB","CB","CC","DC","DD","FD","FF"};
            List<string> ad_soyad = new List<string>();
            List<string> ogr_no = new List<string>();
            Dictionary<string, double> ogr_no_ortalama = new Dictionary<string, double>();

            string kayitlar = Path.Combine(Directory.GetCurrentDirectory(), "oku.txt");
            string[] kayit = System.IO.File.ReadAllLines(kayitlar);

            string yaz =  Path.Combine(Directory.GetCurrentDirectory(), "yaz.txt");
            FileStream fs = new FileStream(yaz, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            //kayıtların üstünde satır satır dolaşmayı sağlar.
            //dolaşılan kayıt split metodu ile boşluklarına ayrılır
            //uygun olan veri tipine atanır. ortalama hesaplanır.
            //sınıf mevcudunu bulur.
            foreach (string line in kayit)
            {
                string[] kelime = line.Split(' ');
                if (kelime[0].ToString() != "")
                {   sinif_mevcut++;
                    ad_soyad.Add(kelime[0] + " " + kelime[1]);
                    ogr_no.Add(kelime[2]);
                    ortalama = (Int16.Parse(kelime[3])*0.1 + Int16.Parse(kelime[4])*0.1 + Int16.Parse(kelime[5])*0.3 + Int16.Parse(kelime[6])*0.5);
                    ogr_no_ortalama.Add(kelime[2],ortalama);
                    
                }
            }
           
            sw.WriteLine("Sinif mevcudu : "+sinif_mevcut + "\n");
            
            //harf notunu getirir
            //ad-soyad,öğrenci numarası, ortalama ve harf notu txt dosyasına yazdırılır
            for(int j=0; j<sinif_mevcut; j++){
                string harf_notu = harf_notu_getir(ogr_no_ortalama[ogr_no[j]],harf_sayilari);
                sw.WriteLine(ad_soyad[j] + " " + ogr_no[j] + "  Ortalaması:" + ogr_no_ortalama[ogr_no[j]] + "  Harf Notu: " + harf_notu);
            }

            sw.WriteLine();

            //harf notundan kaç kişi aldığını txt dosyasına yazdırır
            for(int k=0; k<9; k++){
                sw.WriteLine(harfler[k]+" alan toplam öğrenci sayısı: "+harf_sayilari[k]);
            }

            //istatistiği hesaplar ve txt dosyasına yazdırır
            sw.WriteLine("\n İSTATİSTİK \n");
            for(int l=0; l<9; l++){
                sw.WriteLine(harfler[l]+" istatiği: %" + (harf_sayilari[l]/Convert.ToDouble(sinif_mevcut))*100);
            }

            sw.Flush();
            sw.Close();
            fs.Close(); 
            }
        }
    }