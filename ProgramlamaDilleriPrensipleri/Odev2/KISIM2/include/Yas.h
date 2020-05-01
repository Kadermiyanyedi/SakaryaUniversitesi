/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*yas header file
* </p>
*/
#ifndef YAS_H
#define YAS_H
#include "../include/Rastgele.h"

struct YAS {
    int yas;
    Random rand;
}; 
typedef struct YAS* yas;

yas YasOlustur();
int Yasuret(const yas);
void YasYoket(const yas);

#endif
