/**
*
* @author Kader Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
* 		Yasin Altunbasak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
rastgele yas döndürü
* </p>
*/
package rastgelekisiuret;

public class Yas {
    public long YasOlustur(){
        Rastgele rs = new Rastgele();
        long yas = rs.RastgeleSayiUret();
        long temp = rs.RastgeleSayiUret();
        if(temp <= 3){
        yas = yas*yas +10;
        }
        else if(temp <= 6){
        yas = yas*2+4;
        }
        return yas;
       
    }
    
}
