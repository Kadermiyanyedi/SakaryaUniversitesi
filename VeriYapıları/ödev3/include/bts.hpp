#ifndef bts_HPP
#define bts_HPP
#include "../include/node.hpp"
class bts{
    private:
        node *root;
        void AraveEkle(node *&alt_dugum, int yeni);
        void Postorder(node *alt_dugum);
        int Toplam_soy_bul(node *alt_dugum);
        int kok_dugum_sil(node *&alt_dugum);
        int en_buyuk_sil(node *&alt_dugum);

    public:
        bts();
        int soy=0;
        int soy_toplam;
        int silinen_kok;
        int silinen_buyuk_deger;
        void Ekle(int yeni);
        void Postorder();
        int Toplam_soy();
        int kok_sil();
        int en_buyuk();
        bool Bosmu();
        void Temizle();

};

#endif