/**
*
* @author Kader Miyanyedi kader.miyanyedi@ogr.sau.edu.tr
* 		Yasin Altunbasak yasin.altunbasak@ogr.sau.edu.tr
* @since 20.04.2020
* <p>
rastgele sayi uretir* </p>
*/
package rastgelekisiuret;
public class Rastgele {
    public Rastgele() {
		
	}
	public long RastgeleSayiUret() {
		
		long start = (System.currentTimeMillis()*11) % 10;
        try {
			Thread.sleep(11);
		} catch (InterruptedException e) {
			e.printStackTrace();
		}
		return start;

	}
    
}
