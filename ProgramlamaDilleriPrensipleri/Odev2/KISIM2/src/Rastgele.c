/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*rastgele sayi uretir
* </p>
*/
#include "../include/Rastgele.h"
#include "time.h"
#include <stdint.h>

Random RandomOlustur(){
	Random rn = (Random)malloc(sizeof(struct RANDOM));
	rn->random = 0;
	return rn;
}

int RandomUret(Random r){
    time_t gec;
    gec = time(NULL);
    struct tm * timeptr=localtime(&gec);
    int rand_state = r->random;
    int *p;
    p = (int*)malloc(sizeof(int));
    int res = ((intptr_t)p%+11)%10+timeptr->tm_sec*11;
    rand_state = res;
    rand_state = (rand_state * 1103515245 + 123456) & 0x7fffffff;
    return rand_state%10;
}

void RandomYoket(Random r){
	if(r == NULL) return;
	free(r);
	r = NULL;
} 
