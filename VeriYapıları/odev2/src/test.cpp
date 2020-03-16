#include "../include/node.hpp"
#include "../include/doublelinkedlist.hpp"
#include <iostream>
#include <fstream>

using namespace std;

int main() {
    Doublelinkedlist *kelimeler = new Doublelinkedlist();
    string kelime = "";
    char karakter;
    ifstream dosyaOku("icerik.txt");


    if (dosyaOku.is_open()) {

        kelime = ' ';
        while (dosyaOku.get(karakter)) {
            if (karakter == ' ') {

                kelimeler->eleman_ekle(kelime);
                kelime = ' ';

            } else {

                kelime += karakter;
            }
        }
        kelimeler->eleman_ekle(kelime);
        dosyaOku.close();
    }
    kelimeler->eleman_yazdir();
    delete kelimeler;
    return 0;

}