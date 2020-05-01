/**
*
* @author Kader Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
* 		Yasin Altunbasak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
rastgele telefon no uretir
* </p>
*/
package rastgelekisiuret;
public class Telefon {
	public Telefon() {}
	String newTel = "05";
	long rakam;
	long tel_no=0;
	Rastgele rs = new Rastgele();
	
	public String TelefonNoUret() {
		do{
	        rakam = rs.RastgeleSayiUret();
	    }while(!(rakam == 4 || rakam == 5 || rakam == 3 || rakam == 0));
	    newTel += rakam+"";
	    
	    for (int i = 0; i < 8; i++) {
	        newTel += rs.RastgeleSayiUret() + "";
	    }
	    
	    String tel = newTel;
	    newTel = "05";
	    return tel;
	}

}
