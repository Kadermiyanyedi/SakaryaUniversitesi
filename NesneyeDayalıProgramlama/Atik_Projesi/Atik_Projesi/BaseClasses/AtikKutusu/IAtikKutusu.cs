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
    public interface IAtikKutusu : IDolabilen
    {
        /// <summary>     
        /// Atık kutusu boşaltıldığında oyun puanına kaç puan ekleneceğini döndürür.     
        ///  </summary>     
        int BosaltmaPuani { get; } 
        /// <summary>     
        /// Atık kutusunda gönderilen atığı alacak kadar boş yer varsa atığı kutuya ekler.     
        /// </summary>     
        /// <param name="atik">Eklenecek Atık</param>     
        /// <returns>Atığın kutuya eklenip eklenmediğini döndürür.</returns>    
        bool Ekle(Atik atik);
        /// <summary>    
        /// Atık kutusunun doluluk oranı %75'in üstündeyse atık kutusunu boşaltır.     
        /// </summary>    
        /// <returns>Atık kutusunun boşaltılıp boşaltılmadığını döndürür.</returns>    
        bool Bosalt();
    }
}
