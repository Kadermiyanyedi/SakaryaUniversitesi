hepsi: derle calistir

derle:
	g++ -I ./include/ -o ./lib/Rastgele.o -c ./src/Rastgele.c
	g++ -I ./include/ -o ./lib/ImeiNo.o -c ./src/ImeiNo.c
	g++ -I ./include/ -o ./lib/KimlikNo.o -c ./src/KimlikNo.c
	g++ -I ./include/ -o ./lib/Kisi.o -c ./src/Kisi.c
	g++ -I ./include/ -o ./lib/Telefon.o -c ./src/Telefon.c
	g++ -I ./include/ -o ./lib/Yas.o -c ./src/Yas.c
	g++ -I ./include/ -o ./lib/RastgeleKisi.o -c ./src/RastgeleKisi.c
	g++ -I ./include/ -o ./bin/Test ./lib/Rastgele.o ./lib/ImeiNo.o ./lib/KimlikNo.o ./lib/Kisi.o ./lib/Telefon.o ./lib/Yas.o ./lib/RastgeleKisi.o ./src/Test.c

calistir:
	./bin/Test
