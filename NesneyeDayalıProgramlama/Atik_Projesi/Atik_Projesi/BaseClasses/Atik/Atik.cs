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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atik_Projesi
{
    public class Atik : IAtik
    {
        private int _hacim;
        private Image _image;
        private string _atikAdi;
        private string _atikCinsi;

        public int Hacim { get => _hacim; set => _hacim = value; }
        public Image Image { get => _image; set => _image = value; }
        public string AtikAdi { get => _atikAdi; set => _atikAdi = value; }
        public string AtikCinsi { get => _atikCinsi; set => _atikCinsi = value; }

        public override string ToString()
        {
            return $"{AtikAdi} ({Hacim})";
        }
    }
}
