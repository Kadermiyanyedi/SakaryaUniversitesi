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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atik_Projesi
{
    public class AtikKutusu : IAtikKutusu
    {
        int _bosaltmaPuani;
        int _kapasite;
        int _doluHacim;
        int _dolulukOrani;


        public int BosaltmaPuani { get => _bosaltmaPuani; set => _bosaltmaPuani = value; }
        public int Kapasite { get => _kapasite; set => _kapasite = value; }
        public int DoluHacim { get => _doluHacim; set => _doluHacim = value; }
        public int DolulukOrani { get =>(100*DoluHacim/Kapasite); set => _dolulukOrani = value; }

        public bool Bosalt()
        {
            if (DolulukOrani >= 75) return true;
            return false;
        }

        public bool Ekle(Atik atik)
        {
            if (atik.Hacim <= (Kapasite - DoluHacim)) return true;
            return false;
        }
    }
}
