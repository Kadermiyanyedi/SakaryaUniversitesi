/* @author Kader Miyanyedi kader.miyanyedi@ogr.sakarya.edu.tr
 * 			Yasin Altunbaşak yasin.altunbasak@ogr.sakarya.edu.tr
 * @since 28.02.2020
 * <p>
 * Txt metnini okur, istenilen verileri bulur ve ekrana yazdırır.
 * <p>
 */
package pdp_odev;
import java.io.*;
import java.util.Scanner;


public class Pdp {
	public static void main(String[] args) throws FileNotFoundException {
		
		int kelime_toplam = 0, mail_sayisi = 0, sh_sayisi = 0, cümle_sayisi = 0, ws_sayisi = 0;
		String secilecekharfler="aeıioöuü"; 
		
		File dosya = new File("icerik.txt");
		
		
		Scanner siteler = new Scanner(dosya);
		
		// hasNextLine bulunduğu satırdan sonra okunacak girdide hâlâ okunabilecek string verilerinin bulunup bulunmadığını kontrol eder.
		//nextLine metni satır satır okur.
		//split metodu stringi boşluklara göre ayırır.
		while(siteler.hasNextLine()) {
                    
            String satir = siteler.nextLine().trim();
                        
                        //if else ile iki metin arasındaki boşluklar olduğunda hata vermesini engellemiş olduk.
            if(satir != null && !satir.isEmpty()){
			String kelime[] = satir.split(" ");
                        
                        
			//Dizinin uzunluğu kelime sayısını verir.
			kelime_toplam += kelime.length;
			
			
			// web sayfaları .com, .edu, .net, .org, .com.tr, .edu.tr, .net.tr, .org.tr ile bitmelidir. Fakat .com .edu vs mail içerisinde de yer almaktadır.
			// Mailler @ içerir. İlk olarak if else kullanarak mail olup olmadığını kontrol ettik.
			// Eğer mail değil ise .com, .edu, .net, .org, .com.tr, .edu.tr, .net.tr, .org.tr içerip içermediğini kontrol ettik. Toplam mail sayısını bulduk.
			for(int m=0; m<kelime.length; m++) {
				if(kelime[m].indexOf("@") == -1){
					if(kelime[m].indexOf(" .com") >=0 || kelime[m].indexOf(" .edu")>=0 || kelime[m].indexOf(" .net")>=0 || kelime[m].indexOf(" .org") >=0 )
						ws_sayisi++;
				}
			}
			
			// Cümleler "." "!" "?" "..." gibi karakterler ile biterler. Son karakteri kontrol ederek toplam cümle sayısını bulduk.
			for(int l=0; l<kelime.length; l++) {
				
				if(kelime[l].charAt(kelime[l].length()-1) == '.' ||kelime[l].charAt(kelime[l].length()-1) == '!' 
									|| kelime[l].charAt(kelime[l].length()-1) == '?' || kelime[l].substring(kelime[l].length()-1) == "..." )
					cümle_sayisi += 1;
			}
			
			//Mailler @ içerir. Kelimeler içerisinde indexOf methodu ile bu karakterin olup olmadığını kontrol ettik. Toplam mail sayısını bulduk.
			for(int i=0; i<kelime.length; i++) {
				if(kelime[i].indexOf("@")>=0) {
					mail_sayisi +=1;
				}
			}
			
			// Kelimelerin karakterleri ile sesli harfleri içeren dizinin elemanlarını karşılaştırdık. Toplam sesli harf sayısını bulduk.
			for(String kelimeler : kelime) {
				for(int j=0; j<kelimeler.length(); j++) {
					for(int k=0; k<secilecekharfler.length(); k++) {
						if(kelimeler.toLowerCase().charAt(j) == secilecekharfler.charAt(k)) 
							sh_sayisi += 1;
						
					}
				}		
			}
			
		}
            }
		
		System.out.println("Toplam Sesli Harf Sayisi : " + sh_sayisi);
		System.out.println("Toplam Kelime Sayisi : " + kelime_toplam);
		System.out.println("Toplam Cümle Sayisi : "+ cümle_sayisi);
		System.out.println("Toplam Mail Sayisi : " + mail_sayisi);
		System.out.println("Toplam Web Sitesi Sayisi : " + ws_sayisi);
	}
}
