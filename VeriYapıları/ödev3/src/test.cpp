#include "../include/node.hpp"
#include "../include/bts.hpp"
#include <iostream>
#include <string>
#include <sstream>
#include <fstream>
using namespace std;

int main(){
  bts *benim = new bts();
  bts *rakip = new bts();
  string kelime= "";
  int tur_sayisi = 0;
  int benim_skor=0, rakip_skor=0,en_buyuk = 0, kok = 0;
  int sayi;
  char karakter;


  ifstream dosyaOku("benin.txt");


  if (dosyaOku.is_open()) {

      kelime= ' ';
      while (dosyaOku.get(karakter)) {
            if (karakter == ' ') {
                istringstream(kelime)>>sayi;
                benim->Ekle(sayi);
                kelime = ' ';

            }
            else{

                kelime += karakter;
            }
      }
      istringstream(kelime)>>sayi;
      benim->Ekle(sayi);
      dosyaOku.close();
  }


  ifstream dosyaOku2("rakip.txt");


  if (dosyaOku2.is_open()) {

      kelime= ' ';
      while (dosyaOku2.get(karakter)) {
          if (karakter == ' ') {
              istringstream(kelime)>>sayi;
              rakip->Ekle(sayi);
              kelime = " ";

          }
          else{
              kelime += karakter;
          }
      }
      istringstream(kelime)>>sayi;
      rakip->Ekle(sayi);
      dosyaOku2.close();
  }
benim->Temizle();
rakip->Temizle();
delete benim;
delete rakip;



}