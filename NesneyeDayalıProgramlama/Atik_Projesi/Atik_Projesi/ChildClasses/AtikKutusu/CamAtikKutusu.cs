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
    class CamAtikKutusu:AtikKutusu
    {
        public CamAtikKutusu(int bosaltmaPuani, int kapasite, int doluHacim, int dolulukOrani)
        {
            this.BosaltmaPuani = bosaltmaPuani;
            this.Kapasite = kapasite;
            this.DoluHacim = doluHacim;
            this.DolulukOrani = dolulukOrani;
        }
    }
}
