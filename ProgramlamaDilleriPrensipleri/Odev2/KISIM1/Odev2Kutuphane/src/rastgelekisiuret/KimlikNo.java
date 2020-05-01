/**
*
* @author Kader Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
* 		Yasin Altunbasak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
kimlikno üretir ve jontrol eder* </p>
*/
package rastgelekisiuret;
public class KimlikNo {
    Rastgele rs = new Rastgele();
    String KimlikNumarasi = "";

    public String KimlikNo() {
        KimlikNumarasi = "";
        long TcDizi[] = new long[11], yedek = 0;
        for (int sayac = 0; sayac < 11; sayac++) {
            if (sayac == 0) {
                TcDizi[0] =rs.RastgeleSayiUret() + 1;
            } else if (sayac < 10) {
                TcDizi[sayac] = rs.RastgeleSayiUret();
            }
        }
        TcDizi[9] = (((TcDizi[0] + TcDizi[2] + TcDizi[4] + TcDizi[6] + TcDizi[8]) * 7) - (TcDizi[1] + TcDizi[3] + TcDizi[5] + TcDizi[7])) % 10;
        for (int i = 0; i <= 9; i++) {
            yedek += TcDizi[i];
        }
        TcDizi[10] = yedek % 10;
        for (int a = 0; a < 11; a++) {
            KimlikNumarasi += TcDizi[a]%10;
            TcDizi[a] = 0;
        }
        String kimlik = KimlikNumarasi;
        return kimlik;
    }

    public String KimlikNoKontrol(String Tc) {
        if (Tc.length() != 11) {
            return "GeçersizTc";
        }
        int TcDizi[] = new int[Tc.length()];
        for (int i = 0; i < Tc.length(); i++) {
            
            TcDizi[i] =  Character.getNumericValue(Tc.charAt(i));
        }
        int Hane10, Hane11, yedek2 = 0;
        Hane10 = (((TcDizi[0] + TcDizi[2] + TcDizi[4] + TcDizi[6] + TcDizi[8]) * 7) - (TcDizi[1] + TcDizi[3] + TcDizi[5] + TcDizi[7])) % 10;
        for (int i = 0; i <= 9; i++) {
            yedek2 += TcDizi[i];
        }
        Hane11 = yedek2 % 10;
        if (TcDizi[9] == Hane10 && TcDizi[10] == Hane11) {
            return "GeçerliTc";
        } else {
            return "GeçersizTc";
        }
    }
    }