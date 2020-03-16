/**
* @file top.cpp
* @description top nesnesi olusturur,top harfini dondurur.
* @course 1.Ogretim C grubu
* @assignment Odev1
* @date 25.10.2019
* @author Kader Miyanyedi kader.miyanyedi@ogr.sakarya.edu.tr   Rabia OKATAN rabia.okatan@ogr.sakarya.edu.tr
*/

#include "../include/top.hpp"
#include<iostream>


using namespace std;
 
Top::Top(char top_harf) {
    top=top_harf;
}

char Top::harf_getir(){
     return top;
}

