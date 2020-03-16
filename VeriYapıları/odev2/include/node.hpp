#ifndef NODE_HPP
#define NODE_HPP
#include <string>
using namespace std;
class Node{
	public:
        string data;
		Node *next;
		Node *prev;
		int konum;
		Node(string data, Node *next, Node *prev, int konum);

};
#endif