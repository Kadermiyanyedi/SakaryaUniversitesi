/**
*
* @author KAder Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
        Yasin Altunbaşak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
*yas üretir
* </p>
*/#include "../include/Yas.h"
#include "../include/Rastgele.h"
#include <math.h>

yas YasOlustur(){
    yas yas_ = (yas)malloc(sizeof(struct YAS));
    yas_->rand = RandomOlustur();
    yas_->yas = 0;
    return yas_;
}

int Yasuret(yas yas_){
    int yas = RandomUret(yas_->rand);
    int temp = RandomUret(yas_->rand);
    
    if(temp <= 3)
        yas = yas*yas +10;
    else if(temp == 4)
        yas -= 1;

    else if(temp <= 6)
        yas = yas*2+4;
    else
        yas *= temp;

    return abs(yas);
}

void YasYoket(yas yas_){
    RandomYoket(yas_->rand);
    if(yas_ == NULL) return;
	free(yas_);
	yas_ = NULL;
}