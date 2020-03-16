#ifndef KOVAKONTROL_HPP
#define KOVAKONTROL_HPP

class Kova_kontrol{

    private:
        void Kova_sekil(int index,Kova *kova);

    public:
        Kova_kontrol();
        void Kova_yaz(int boyut,Kova **kovalar);
        void Kova_top_yerlestir(int boyut,Kova **kovalar);
        void Kova_top_sil(int boyut, Kova **kovalar);
        void Kova_degistir(int ana,int hedef,Kova **kovalar);
        void Kova_top_degistir(int ana,int hedef,Kova **kovalar);
        void Kova_tersten_diz(int boyut,Kova **kovalar);
        void Top_tersten_diz(int boyut,Kova **kovalar);
        void Kova_temizle(int boyut,Kova **kovalar);

};

#endif

