/**
* @file test.cpp
* @description Kullanicidan kova sayisini alir, kova dizisi ve nesneleri uretir, islem menusunu sunar.
* @course 1.Ogretim C grubu
* @assignment Odev1
* @date 25.10.2019
* @author Kader Miyanyedi kader.miyanyedi@ogr.sakarya.edu.tr   Rabia OKATAN rabia.okatan@ogr.sakarya.edu.tr
*/
#include <iostream>
#include "../include/kova.hpp"
#include "../include/kovakontrol.hpp"

using namespace std;

int main(){

    int kovaSayisi = 0;
    int secenek = 0;
    int hedef,ana;

    while(kovaSayisi <= 0){
        cout << "Kova sayisi: ";
        cin >> kovaSayisi;
        if(kovaSayisi <= 0){
            cout << "Lutfen kova sayisini sifirdan buyuk ve asiri buyuk olmayacak sekilde giriniz" << endl;
        }
        if(cin.fail()){
            cin.clear();
            cin.ignore();
        }
    }
    
    Kova** kovalar = (Kova**) new(nothrow) Kova*[kovaSayisi];
    
    if(!kovalar){
        cout<<"Bellek alani acilamadi!"<<endl;
        return 1;
    }

    for(int i=0; i<kovaSayisi; i++){
        Kova* kova = new Kova((i%6)+1);
        kovalar[i] = kova;
    }

    Kova_kontrol* kova_kontrol = new Kova_kontrol();
    kova_kontrol->Kova_yaz(kovaSayisi,kovalar);
    
    while(secenek!=7){

        cout<<" [1] Toplari yerlestir."<<endl;
        cout<<" [2] Toplari yoket."<<endl;
        cout<<" [3] Kova degistir."<<endl;
        cout<<" [4] Top degistir."<<endl;
        cout<<" [5] Kovalari tersten yerlestir."<<endl;
        cout<<" [6] Toplari tersten yerlestir."<<endl;
        cout<<" [7] Cikis."<<endl<<endl;

        cout<<"Lutfen yapmak istediginiz islemi seciniz: ";
        cin >> secenek;
        
        if(cin.fail()){
            cin.clear();
            cin.ignore();
            continue;
        }
        
        switch (secenek){
            case 1:
                kova_kontrol->Kova_top_yerlestir(kovaSayisi,kovalar);
                kova_kontrol->Kova_yaz(kovaSayisi,kovalar);
                break;
                
            case 2:
                kova_kontrol->Kova_top_sil(kovaSayisi,kovalar);
                kova_kontrol->Kova_yaz(kovaSayisi,kovalar);
                break;

            case 3:
                cout<<"Hangi kova: ";
                cin>>ana;
                if(cin.fail()||ana<1||ana>kovaSayisi){
                    cout<<"Bir hata olustu"<<endl<<endl;
                    cin.clear();
                    cin.ignore();
                    continue;
                }
                cout<<"Hangi kova ile: ";
                cin>>hedef;
                if(cin.fail()||hedef<1||hedef>kovaSayisi){
                    cout<<"Bir hata olustu"<<endl<<endl;
                    cin.clear();
                    cin.ignore();
                    continue;
                }
                kova_kontrol->Kova_degistir(ana-1,hedef-1,kovalar);
                kova_kontrol->Kova_yaz(kovaSayisi,kovalar);
                break;

            case 4:
                cout<<"Hangi top: ";
                cin>>ana;
                if(cin.fail()||ana<1||ana>kovaSayisi){
                    cout<<"Bir hata olustu"<<endl<<endl;
                    cin.clear();
                    cin.ignore();
                    continue;
                }
                cout<<"Hangi top ile: ";
                cin>>hedef;
                if(cin.fail()||hedef<1||hedef>kovaSayisi){
                    cout<<"Bir hata olustu"<<endl<<endl;
                    cin.clear();
                    cin.ignore();
                    continue;
                }
                kova_kontrol->Kova_top_degistir(ana-1,hedef-1,kovalar);
                kova_kontrol->Kova_yaz(kovaSayisi,kovalar);
                break;
                
            case 5:
                kova_kontrol->Kova_tersten_diz(kovaSayisi,kovalar);
                kova_kontrol->Kova_yaz(kovaSayisi,kovalar);
                break;

            case 6:
                kova_kontrol->Top_tersten_diz(kovaSayisi,kovalar);
                kova_kontrol->Kova_yaz(kovaSayisi,kovalar);
                break;

            case 7:
                kova_kontrol->Kova_temizle(kovaSayisi,kovalar);
                delete kova_kontrol;
                break;

        }
    }
    return 0;
}

