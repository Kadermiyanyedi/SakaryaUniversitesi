/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*kurallara uygun kimlik no üretir ve kontrol eder
* </p>
*/
#include "../include/KimlikNo.h"
#include "../include/Rastgele.h"

kimlikNo kimlikNoOlustur(){
    kimlikNo kimlik_no = (kimlikNo)malloc(sizeof(struct KIMLIKNO));
    kimlik_no->rand = RandomOlustur();
    return kimlik_no;
}

char* kimlikno_uret(kimlikNo kimlik){
    int tek=0,cift=0,yedek=0;
    int a = RandomUret(kimlik->rand);
    if (a == 0){
        a = 1;
        kimlik->kimlik_no[0] = a+'0';
        yedek += a;
        cift += a;
    }
    else{
        kimlik->kimlik_no[0] = a+'0';
        yedek += a;
        cift +=a;
    }

    for(int i=1;i<9;i++){
        int num = RandomUret(kimlik->rand);
        yedek += num;
        kimlik->kimlik_no[i] = num +'0';
        if(i%2==0) cift += num;
        else tek += num;
    }
    int on = (abs(cift*7 - tek))%10;
    yedek += on;
    kimlik->kimlik_no[9] = on +'0';
    kimlik->kimlik_no[10] = (yedek%10)+'0';
    return kimlik->kimlik_no;
    
}

int kimliknoKontrol(kimlikNo km, char* kimlik){
    int tek=0,cift=0;
    for(int i =0; i<9;i++){
        int number = kimlik[i] - '0';
        if(i%2==0){
            cift += number;
        }
        else{
            tek += number;
        }
    }
    int on = kimlik[9]-'0';
    int temp = (abs(cift*7-tek))%10;
    int temp2 = (on + tek + cift)%10;
    int onbir = kimlik[10]-'0';
    if (on != temp)
        return -1;

    if(onbir != temp2)
        return -1;
    
    return 1;
   

}

void kimlikNoYoket(kimlikNo km){
    RandomYoket(km->rand);
	if(km == NULL) return;
	free(km);
	km = NULL;
} 