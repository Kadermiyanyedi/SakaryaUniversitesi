#include "../include/bts.hpp"
#include "../include/node.hpp"
#include <iostream>
using namespace std;

bts :: bts(){
    int silinen_kok = 0;
    int silinen_buyuk_dugum=0;
    int soy_toplam=0;
    int soy=0;
}
void bts ::AraveEkle(node *&alt_dugum, int yeni) {
    if(alt_dugum == NULL){
        alt_dugum = new node(yeni);
        alt_dugum->soy_sayisi = 0;
    }
    else if(yeni <= alt_dugum->data){
        alt_dugum->soy_sayisi +=1;
        AraveEkle(alt_dugum->lchild,yeni);
    }
    else if(yeni > alt_dugum->data){
        alt_dugum->soy_sayisi +=1;
        AraveEkle(alt_dugum->rchild,yeni);
    }
    else return;
}

void bts ::Ekle(int yeni) {
    AraveEkle(root, yeni);

}
void bts::Postorder(node *alt_dugum){
    if(alt_dugum != NULL){
        Postorder(alt_dugum->lchild);
        Postorder(alt_dugum->rchild);
        cout<<" <"<<alt_dugum->data<<" "<<alt_dugum->soy_sayisi<<"> ";
    }
}
void bts::Postorder(){
    Postorder(root);
}

int bts::Toplam_soy_bul(node *alt_dugum) {

    if(alt_dugum != NULL){
        Toplam_soy_bul(alt_dugum->lchild);
        Toplam_soy_bul(alt_dugum->rchild);
        soy_toplam += alt_dugum->soy_sayisi;
    }

    return soy_toplam;

}
int bts::Toplam_soy() {
    return Toplam_soy_bul(root);
}

int bts::kok_dugum_sil(node *&alt_dugum) {
    node *silinecekDugum;
    silinen_kok = alt_dugum->data;
    if(alt_dugum->rchild == NULL){
        alt_dugum = alt_dugum->lchild;
        alt_dugum->soy_sayisi -= 1;
    }

    else if(alt_dugum->lchild == NULL){
        alt_dugum = alt_dugum->rchild;
        alt_dugum->soy_sayisi -= 1;
    }

    else{
        silinecekDugum = alt_dugum->lchild;

        node *ebeveynDugum = alt_dugum;
        while(silinecekDugum->rchild != NULL){
            ebeveynDugum=silinecekDugum;
            silinecekDugum->soy_sayisi--;
            silinecekDugum=silinecekDugum->rchild;
        }
        alt_dugum->data = silinecekDugum->data;
        if(ebeveynDugum == alt_dugum){
            alt_dugum->lchild= silinecekDugum->lchild;
            alt_dugum->soy_sayisi--;

        }
        else{
            ebeveynDugum->rchild = silinecekDugum->lchild;
            alt_dugum->soy_sayisi--;
        }

    }

    delete silinecekDugum;
    return silinen_kok;
}
int bts::kok_sil() {
    return kok_dugum_sil(root);
}

int bts::en_buyuk_sil(node *&alt_dugum) {
    node *silinecekDugum = alt_dugum->rchild;
    node *ebeveynDugum = alt_dugum;
    alt_dugum->soy_sayisi--;
    while(silinecekDugum->rchild != NULL){
        silinecekDugum = silinecekDugum->rchild;
        silinecekDugum->soy_sayisi--;
        ebeveynDugum = ebeveynDugum->rchild;
    }
    silinen_buyuk_deger = silinecekDugum->data;
    ebeveynDugum->rchild = silinecekDugum->lchild;
    delete silinecekDugum;
    return silinen_buyuk_deger;

}
int bts::en_buyuk() {

    return en_buyuk_sil(root);
}

bool bts::Bosmu(){
    return root == NULL;
}
void bts::Temizle(){
    while(!Bosmu()) kok_dugum_sil(root);
}

