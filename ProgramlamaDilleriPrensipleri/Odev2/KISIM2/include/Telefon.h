/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*telefon header file
* </p>
*/
#ifndef TELEFON_H
#define TELEFON_H
#include "../include/Rastgele.h"
#include <string.h>

struct TELEFON {
    Random rand;
    char telefon[11];
}; 
typedef struct TELEFON* telefon;

telefon telefonOlustur();
char* telefonNo_uret(const telefon);
void telefonYoket(const telefon);
#endif