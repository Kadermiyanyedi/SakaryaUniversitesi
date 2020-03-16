#ifndef DOUBLELINKEDLIST_HPP
#define DOUBLELINKEDLIST_HPP
#include "node.hpp"
#include <string>


using namespace std;
class Doublelinkedlist{
	private:
		Node *head;
		Node *tail;
		int eleman_sayisi;
        int index;
        int toplam_karakter_sayisi;
        int toplam_index_karakter_sayisi;

	public:
        Doublelinkedlist();
		void eleman_ekle(string data);
		void eleman_yazdir();
		bool eleman_kontrol(string kontrol);
		int indexi_ver(string index_data);
        int karakter_toplam(string data_kontrol);
        int index_karakter_toplam(int sayi);
        void clear();

		

};
#endif