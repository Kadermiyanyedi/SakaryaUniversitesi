#ifndef RASTGELEKISI_H
#define RASTGELEKISI_H
#include <stdio.h>
#include "../include/Telefon.h"
#include "../include/ImeiNo.h"
/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*RasteleKisi header file
* </p>
*/
#include "../include/Yas.h"
#include "../include/KimlikNo.h"
#include "../include/Rastgele.h"
#include "../include/Kisi.h"


struct RASTGELEKISI {
    char rskisi[100];    
    kimlikNo km;
    imei_ im;
    telefon tf;
    yas ys;
    kisi kisi_;
}; 
typedef struct RASTGELEKISI* rskisi;

rskisi rskisiOlustur();
void rskisi_uret(const rskisi, int sayi);
void rskisiYoket(const rskisi);


#endif