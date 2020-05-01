/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*telefon no üretir
* </p>
*/
#include "../include/Telefon.h"
#include "../include/Rastgele.h"
#include <string.h>
telefon telefonOlustur(){
    telefon tf = (telefon)malloc(sizeof(struct TELEFON));
    tf->rand = RandomOlustur();
    return tf;

}
char* telefonNo_uret(telefon tf){
    char newTel[11];
   newTel[0] = '0';
    newTel[1] = '5';
    int deger = RandomUret(tf->rand);
    if(deger<=3) {
        newTel[2]='3';
	}
	else if(deger<=6) {
        newTel[2]='4';
	}
	else {
        newTel[2] ='5';
    }
    int tel_no = 0;
    for(int i=3; i<11;i++){
        int gecici = RandomUret(tf->rand);
        newTel[i] =gecici+'0';
    }
   
    newTel[11] = ' ';
    newTel[12] = ' ';
    strcpy(tf->telefon,newTel);
	return tf->telefon;

}


void telefonYoket(telefon tf){
    RandomYoket(tf->rand);
	if(tf == NULL) return;
	free(tf);
	tf = NULL;
} 