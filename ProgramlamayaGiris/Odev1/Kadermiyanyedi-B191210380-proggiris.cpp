/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**		    BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   PROGRAMLAMAYA GİRİŞİ DERSİ
**	
**				ÖDEV NUMARASI…...: 1.Ödev
**				ÖĞRENCİ ADI...............: Kader Miyanyedi
**				ÖĞRENCİ NUMARASI.: B191210380
**				DERS GRUBU…………: 1.Öğretim A grubu
****************************************************************************/
#include <iostream>
#include <string> 

using namespace std;

struct Zaman
{
    int saat;
    int dakika;
    int saniye;
    long toplam_saniye;
};
Zaman zaman;

//Zaman degiskenlerinin sayisal degerlerini kontrol eden fonk.
bool timeControl(int saat, int dakika, int saniye){
    bool control = true;
    //Saatin 24ten buyuk ve 0dan kucuk olup olmadigini kontrol eden if blogu
    if(saat >= 24 || saat <=0){
        cout <<"Girilen saat degeri: "<<saat << " yanlis girilmistir."<<endl;
        control = false;
    }
    //Dakikanın 60dan buyuk ve 0dan kucuk olup olmadigini kontrol eden if blogu
    if(dakika >= 60 || dakika <0){
        cout <<"Girilen dakika degeri: "<<dakika << " yanlis girilmistir."<<endl;
        control = false;
    }
    //Saniyenin 60dan buyuk ve 0dan kucuk olup olmadigini kontrol eden if blogu
    if(saniye >=60 || saniye <0){
        cout <<"Girilen saniye degeri: "<<saniye << " yanlis girilmistir."<<endl;
        control = false;
    }
    return control;
}
void parsingTime(string time){
    string parseCharacter = ":";
    int timeStogare[3];
    int i=0;
    size_t pos = 0;
    //Zamani : gore parse eder ve timeStogare dizisine atar. pos : karakterinin indexini tutar.
    while ((pos = time.find(parseCharacter)) != string::npos) {
        //stoi integer tipine çevirmek için kullanildi. substr 0.indexten pos indexine kadar olan kismi alir.
        timeStogare[i] = stoi(time.substr(0, pos));
        //: karakterine kadar olan kismi stringin icinden cikarir. Boylece parse islemlerimiz kolaylasir.
        time.erase(0, pos + parseCharacter.length());
        i++;
    }
    timeStogare[i]=stoi(time);
    //Zaman degiskenleri istenen degerler arasında ise struct zamana bu degerleri atar ve totalsec bulur.
    if(timeControl(timeStogare[0], timeStogare[1], timeStogare[2])){
        zaman.saat = timeStogare[0];
        zaman.dakika = timeStogare[1];
        zaman.saniye = timeStogare[2];

        long totalsecs = zaman.saat * 3600 + zaman.dakika * 60 + zaman.saniye;
        zaman.toplam_saniye = totalsecs;
        cout <<"Saniye olarak hesaplanan deger: "<<zaman.toplam_saniye;
    }

}
int main(){
    string input_time;
    cout<< "Lutfen Saat:dakika:saniye seklinde zamani giriniz";
    cin >> input_time;
    //zamani parse eder ve struct tipindeki degiskenimize atar.
    parsingTime(input_time);
    return 0;
}
