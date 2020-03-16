#include "../include/node.hpp"
#include <iostream>
#include <string>
using namespace std;

Node::Node(string data, Node *next, Node *prev,int konum){
	this->data = data;
	this->next = next;
	this->prev = prev;
	this->konum = konum;
}
