/**
* @file kovakontrol.cpp
* @description Kovayi ekrana yazdirir, kovalari tersten dizer, kovalara top ekler ve siler, toplari tersten yerlestirir, top degistirir, kova degistirir, kova dizisini siler.
* @course 1.Ogretim C grubu
* @assignment Odev1
* @date 25.10.2019
* @author Kader Miyanyedi kader.miyanyedi@ogr.sakarya.edu.tr   Rabia OKATAN rabia.okatan@ogr.sakarya.edu.tr
*/
#include "../include/kova.hpp"
#include "../include/kovakontrol.hpp"
#include<iostream>

#if defined(_WIN32) || defined(WIN32) || defined(__CYGWIN__) || defined(__MINGW32__) || defined(__BORLANDC__)
#define OS_WIN
#include <windows.h>
HANDLE hConsole;
#endif

using namespace std;

Kova_kontrol::Kova_kontrol(){
	
}

void Kova_kontrol::Kova_yaz(int boyut,Kova **kovalar){
    for(int i=0; i<boyut; i++){
        Kova *kova = kovalar[i];
        Kova_sekil(i,kova); 
    } 
}

void Kova_kontrol::Kova_tersten_diz(int boyut,Kova **kovalar){
    for(int i=0; i<(boyut/2); i++){
        Kova* kova = kovalar[i];
        kovalar[i] = kovalar[(boyut-1)-i];
        kovalar[(boyut-1)-i] = kova;
    }
}

void Kova_kontrol::Kova_sekil(int index,Kova *kova){
    
    #ifdef OS_WIN
    hConsole = GetStdHandle(STD_OUTPUT_HANDLE);
    SetConsoleTextAttribute(hConsole, kova->renk_getir());
    #endif
    
    cout<<index+1<<". Kova"<<endl<<endl;
    
    cout<<"   .|.  "<<endl;
    cout<<"  .   . "<<endl; 
    cout<<" .     ."<<endl;
    cout<<" #     #"<<endl;
    cout<<" #  ";
    
    if (kova->top_getir() == NULL){
        cout<<"-";
    } 
    else {
        cout<<kova->top_getir()->harf_getir(); 
    }

    cout<<"  #"<<endl;
    cout<<" #     #"<<endl;
    cout<<" #######"<<endl;
    cout<<"Kova adresi: "<<kova<<endl;
    cout<<"Top adresi: ";

    if (kova->top_getir() == NULL){
        cout<<"NULL";
    } 
    else {
        cout<<kova->top_getir();
    }
    
    cout<<endl<<endl;
    
    #ifdef OS_WIN
    SetConsoleTextAttribute(hConsole, 7);
    #endif
}

void Kova_kontrol::Kova_top_yerlestir(int boyut,Kova **kovalar){
    for(int i=0; i<boyut; i++){
        kovalar[i]->top_ekle();
    }
}

void Kova_kontrol::Kova_top_sil(int boyut,Kova **kovalar){
    for(int i=0; i<boyut; i++){
        kovalar[i]->top_sil();
    }
}

void Kova_kontrol::Kova_degistir(int ana,int hedef,Kova **kovalar){
    Kova* temp = kovalar[ana];
    kovalar[ana] = kovalar[hedef];
    kovalar[hedef] = temp;
}

void Kova_kontrol::Kova_top_degistir(int ana,int hedef,Kova **kovalar){
    Top* top1 = kovalar[ana]->top_getir();
    Top* top2 = kovalar[hedef]->top_getir();
    kovalar[ana]->top_degistir(top2);
    kovalar[hedef]->top_degistir(top1);
}

void Kova_kontrol::Top_tersten_diz(int boyut,Kova **kovalar){
    for(int i=0; i<(boyut/2); i++){
        Kova_top_degistir((boyut-1)-i,i,kovalar);
    }
}

void Kova_kontrol::Kova_temizle(int boyut,Kova **kovalar){
    Kova_top_sil(boyut,kovalar);
    delete[] kovalar;
}
