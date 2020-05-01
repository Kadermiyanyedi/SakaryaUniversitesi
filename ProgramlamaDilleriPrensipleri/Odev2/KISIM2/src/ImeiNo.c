/**
*
* @author Kader Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
          Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
* Kurallara uygun imei üretir
* Imei kontrol ve yıkıcı fonksiyonu içerir.
* </p>
*/
#include "../include/ImeiNo.h"
#include <math.h>

imei_ imeiOlustur(){
     imei_ imeino = (imei_)malloc(sizeof(struct IMEI));
     imeino->rand = RandomOlustur();
     return imeino;
}

char* imeino_uret(imei_ imei){
    int number[14];
    int temp = 0;
    for(int i = 0; i<14;i++){

        int num = RandomUret(imei->rand);
        imei->imei_no[i] = num + '0';
        if(i%2==0){
            temp += num;
        }
        else{
            int yedek = num*2;
            if(yedek>9)
                yedek -= 9;
            temp += yedek;
        }

    }
    int kontrol_d = (int)((ceil((temp) / 10)) * 10) + 10;
    if(abs(kontrol_d-temp)>9){
        temp = abs(kontrol_d-temp) % 10;
    }
    else{
        temp = abs(kontrol_d-temp)%10;
    }
    imei->imei_no[14] = temp+'0';
    return imei->imei_no;
}

int imeikontrol(imei_ imei_, char* imei){
    int control = 0;
    for(int i=0; i<14; i++){
        if(i % 2 ==0){
            control += imei[i]-'0';
        }
        else{
            int yedek = (imei[i]-'0')*2;
            if(yedek>9)
                yedek -=9;
            control += yedek;
        }
    }
    int kontrol_d = (int)((ceil((control) / 10)) * 10) + 10;
    if(abs(kontrol_d-control)>9){
        control = abs(kontrol_d-control) % 10;
    }
    else{
        control = abs(kontrol_d-control)%10;
    }
    int temp = imei[14]-'0';
    if(temp == control)
        return 1;
    else 
        return -1;

}

void imeiYoket(imei_ imei){
    RandomYoket(imei->rand);
	if(imei == NULL) return;
	free(imei);
	imei = NULL;
} 
