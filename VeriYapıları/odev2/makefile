hepsi: derle calistir

derle:
	g++ -I ./include/ -o ./lib/node.o -c ./src/node.cpp
	g++ -I ./include/ -o ./lib/doublelinkedlist.o -c ./src/doublelinkedlist.cpp
	g++ -I ./include/ -o ./bin/test ./lib/node.o ./lib/doublelinkedlist.o ./src/test.cpp

calistir:
	./bin/test