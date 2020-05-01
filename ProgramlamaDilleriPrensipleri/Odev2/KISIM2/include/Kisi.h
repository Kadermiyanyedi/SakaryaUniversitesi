/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*kisi header file
* </p>
*/
#ifndef KISI_H
#define KISI_H
#include "../include/Rastgele.h"
#include <string.h>

struct KISI {
    char risim[50];
}; 
typedef struct KISI* kisi;

kisi kisiOlustur();
char* kisi_uret(const kisi);
void kisiYoket(const kisi);


#endif