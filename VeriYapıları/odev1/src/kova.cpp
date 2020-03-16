/**
* @file kova.cpp
* @description top adresi dondurur,top nesnesini siler,topları degistirir
* @course 1.Ogretim C grubu
* @assignment Odev1
* @date 25.10.2019
* @author Kader Miyanyedi kader.miyanyedi@ogr.sakarya.edu.tr   Rabia OKATAN rabia.okatan@ogr.sakarya.edu.tr
*/#include <iostream>
#include "../include/kova.hpp"
#include "../include/top.hpp"
#include<iostream>

using namespace std;

Kova::Kova(int kova_renk) {
	top = NULL;
	renk = kova_renk;
}

Top* Kova::top_getir(){
    return top;
}

void Kova::top_ekle(){
    if(top == NULL){
        char c = 'A' + (rand() % 26);
        top = new Top(c);
    }
}
        
void Kova::top_sil(){
    if(top != NULL){
        delete top;
        top = NULL;
    }
}

void Kova::top_degistir(Top* yeni_top){
    top = yeni_top;
}

int Kova::renk_getir() {
	return renk;
}

