/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*Rastgele header file
* </p>
*/
#ifndef RASTGELE_H
#define RASTGELE_H
#include "stdio.h"
#include "stdlib.h"
#include <time.h>

struct RANDOM {
    int random;
}; 

typedef struct RANDOM* Random;
Random RandomOlustur();
int RandomUret(const Random);
void RandomYoket(const Random);

#endif