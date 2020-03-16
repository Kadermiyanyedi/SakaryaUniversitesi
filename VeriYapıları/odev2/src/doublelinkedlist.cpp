#include "../include/node.hpp"
#include "../include/doublelinkedlist.hpp"
#include <iostream>
#include <string>
#include <sstream>
using namespace std;

Doublelinkedlist::Doublelinkedlist(){
	head = NULL;
	tail = NULL;
	eleman_sayisi = 0;
	index = 0;
	toplam_karakter_sayisi=0;
	toplam_index_karakter_sayisi=0;
}

void Doublelinkedlist::eleman_ekle(string data){

	if(eleman_sayisi == 0){
		Node *yeni = new Node(data,NULL,NULL,0);
		head = yeni;
		tail = yeni;

	}
	else{
	    int gecici=0;
	    if(eleman_kontrol(data)){
	        toplam_karakter_sayisi += (karakter_toplam(data) - 1);
            gecici = indexi_ver(data);
            toplam_index_karakter_sayisi += index_karakter_toplam(gecici);
            data = " ";
	    }

		Node *yeni = new Node(data,NULL,NULL,gecici);
		tail->next = yeni;
		yeni->prev = tail;
		tail = yeni;

	}
	eleman_sayisi++;
}
void Doublelinkedlist::eleman_yazdir() {
    Node *temp = head;
    cout<<"NULL "<<"<-:";
    while(temp != NULL){
        cout<<temp->data<<" - "<<temp->konum<<" :<->:";
        temp = temp->next;
    }
    cout<<" NULL"<<endl;
    cout<<"Toplam kazanc: "<<(toplam_karakter_sayisi-toplam_index_karakter_sayisi-2)<<" Byte";

    delete temp;
}
bool Doublelinkedlist::eleman_kontrol(string kontrol){

    Node *temp = head;
    while(temp != NULL){
        if(temp->data == kontrol){
            return true;
        }
        temp = temp->next;

    }
    delete temp;

}
int Doublelinkedlist::indexi_ver(string index_data) {
    index = 0;
    Node *temp = tail;
    while (temp != NULL) {
        if (temp->data == index_data)
            return index + 1;

        else {
            index++;
            temp = temp->prev;
        }

    }
    delete temp;
}

int Doublelinkedlist::karakter_toplam(string data_kontrol){
    return data_kontrol.length();
}
int Doublelinkedlist::index_karakter_toplam(int sayi){
    ostringstream strg;
    strg<< sayi;
    string s1 = strg.str();
    return s1.length();
}
void Doublelinkedlist::clear(){
    while(head != tail){
        Node *temp = tail;
        tail = tail->prev;
        delete temp;
    }
    delete head;
    delete tail;
}
