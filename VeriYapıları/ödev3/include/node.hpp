#ifndef node_HPP
#define node_HPP
#include <iostream>
using namespace std;

class node{
    public:
        int data;
        node *lchild, *rchild;
        int soy_sayisi;
        node(int data,node *lchild = NULL, node *rchild = NULL);

};

#endif