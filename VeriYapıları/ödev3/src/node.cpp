#include "../include/node.hpp"

node :: node(int data,node *lchild, node *rchild){
    this->data = data;
    this->lchild = lchild;
    this->rchild = rchild;
}