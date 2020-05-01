/**
*
* @author Kader Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
* 		Yasin Altunbasak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
* imei uretir ve kontrol eder
* </p>
*/
package rastgelekisiuret;

public class ImeiNo {
    public ImeiNo() {}
	Rastgele rs = new Rastgele();
	String imei_no = "";
        int kontrol_deger = 0;
	char kontrol =' ';
	
	public String ImeiNoUret() {
		for(int i=0; i<14; i++) {
			long rs_sayi = rs.RastgeleSayiUret()%10;
			imei_no += String.valueOf(rs_sayi);
		}
                for(int i=0; i<imei_no.length(); i++) {
			kontrol = imei_no.charAt(i);
			if(i%2 ==0) {
				kontrol_deger += Character.getNumericValue(kontrol);
			}
			else {
                                int yedek = ((Character.getNumericValue(kontrol)))*2;
                                if(yedek>9)
                                    yedek -=9;
				kontrol_deger +=yedek;
			} 
		}
                
		int kontrol_d = (int)((Math.ceil((kontrol_deger) / 10)) * 10) + 10;
                
                if((kontrol_d - kontrol_deger) >9){
                        kontrol_deger = (kontrol_d - kontrol_deger)%10;
                        imei_no += String.valueOf(kontrol_deger%10);
                }
                else{
                     imei_no += String.valueOf((kontrol_d-kontrol_deger)%10);
                }
                
                String im = imei_no;
                 imei_no = "";
		return im;
	}
	public String ImeıKontrol(String imei_no){
		int kontrol_deger = 0;
		char kontrol =' ';
                int control = 0;
                if(imei_no.length() != 15)
                    return "GecersizImei";
		for(int i=0; i<14; i++) {
			kontrol = imei_no.charAt(i);
			if(i%2 ==0) {
				kontrol_deger += Character.getNumericValue(kontrol)*1;
			}
			else {
                                int yedek =  Character.getNumericValue(kontrol)*2;
                                if(yedek>9)
                                    yedek = yedek - 9;
				kontrol_deger +=yedek;
			}
		}
                
		int kontrol_d = (int)((Math.ceil((kontrol_deger) / 10)) * 10) + 10;
                
		if((kontrol_d - kontrol_deger) >9){
                        control = (kontrol_d - kontrol_deger)%10;
                }
                else{
                     control= kontrol_d-kontrol_deger;
                }
		int on_bes = Character.getNumericValue(imei_no.charAt(14));
                
		if(control!=on_bes) {
			return "GecerliImei";
		}
		else {
			return "GecersizImei";
		}
	}
}
