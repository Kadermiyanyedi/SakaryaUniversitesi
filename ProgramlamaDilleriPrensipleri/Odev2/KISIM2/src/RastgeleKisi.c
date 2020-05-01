/**
*
* @author Kader Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
          Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
* Tüm bilgileri kisiler.txt ye yazar. Yıkıcı fonksiyonu cagrılınca tüm yıkıcı fonksiyonlar çağrılır. Kesinlikle çöp oluşmaz.
* </p>
*/
#include "../include/RastgeleKisi.h"

rskisi rskisiOlustur(){
   rskisi rs_kisi = (rskisi)malloc(sizeof(struct RASTGELEKISI));
   rs_kisi->im = imeiOlustur();
   rs_kisi->km = kimlikNoOlustur();
   rs_kisi->tf = telefonOlustur();
   rs_kisi->ys = YasOlustur(); 
   rs_kisi->kisi_ = kisiOlustur();
   return rs_kisi;

}
void rskisi_uret(rskisi rsk, int kisiSayisi){

   FILE *fp = fopen("Kisiler.txt","w");

   for(int i = 0; i<kisiSayisi; i++){
      char* imei = imeino_uret(rsk->im);
      char* kimlik = kimlikno_uret(rsk->km);
      char* isim = kisi_uret(rsk->kisi_);
      int yas = Yasuret(rsk->ys);
      char* telefon = telefonNo_uret(rsk->tf);
	   fprintf(fp,"%.11s %s %d %.11s (%.15s)\n",kimlik,isim,yas,telefon,imei);
   }

	fclose(fp);
  
}
void rskisiYoket(rskisi r){
      imeiYoket(r->im);
      kimlikNoYoket(r->km);
      kisiYoket(r->kisi_);
      YasYoket(r->ys);
      telefonYoket(r->tf);
   if(r == NULL) return;
	free(r);
	r = NULL;
}
