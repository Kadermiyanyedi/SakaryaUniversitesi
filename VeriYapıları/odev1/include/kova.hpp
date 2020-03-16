#ifndef KOVA_HPP
#define KOVA_HPP
#include "top.hpp"

class Kova {
    private:
        Top* top;
		int renk;
        
    public:
		Kova(int kova_renk);
        Top* top_getir();
        void top_ekle();
        void top_sil();
        void top_degistir(Top* top);
		int renk_getir();
        
};
#endif
