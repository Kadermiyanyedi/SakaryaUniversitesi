/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*isimler.txtden rastgele isim getirir
* </p>
*/
#include "../include/Kisi.h"
#include "../include/Rastgele.h"

kisi kisiOlustur(){
     srand(time(NULL)); 
     kisi k = (kisi)malloc(sizeof(struct KISI));
     return k;
}
char* kisi_uret(kisi k){
    char line[50];
    int i = 0;
    int sayi = rand()%3000;
    FILE *file = fopen("random_isimler.txt", "r");
    if(file){
    while (fgets(line, sizeof(line), file)) { 
        if(line != NULL){
            if(i==sayi){
            line[strlen(line)-1] = '\0';
            strcpy(k->risim,line);
            
            }
        i++;
        }
        }  
    }
    fclose(file);
    return k->risim;
}
void kisiYoket(kisi k){
    
    if(k == NULL) return;
	free(k);
	k = NULL;
}