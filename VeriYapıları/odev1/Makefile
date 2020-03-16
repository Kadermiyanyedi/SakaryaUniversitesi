all: temizle calistir

lib/kovakontrol.o:
	g++ -o lib/kovakontrol.o -c src/kovakontrol.cpp

lib/kova.o:
	g++ -o lib/kova.o -c src/kova.cpp

lib/top.o:
	g++ -o lib/top.o -c src/top.cpp

bin/test.exe: lib/kovakontrol.o lib/kova.o lib/top.o
	g++ -o bin/test.exe lib/kovakontrol.o lib/kova.o lib/top.o src/test.cpp

calistir: bin/test.exe
	bin/test.exe

temizle:
	del bin\test.exe 2> nul
	del lib\kovakontrol.o 2> nul
	del lib\kova.o 2> nul
	del lib\top.o 2> nul