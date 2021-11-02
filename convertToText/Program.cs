using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convertText
{
    class Program
    {
        static void Main(string[] args)
        { //starting kısmı  go to terimi ile bir başlangıç noktası oluşturmak için kullandım. try catch ile hatayı yakaladığımızda hata mesajı sonrasında programın kapanmaması için bir başlangıç noktası starting yerine basla vb farklı şekilde isimlendirme de yapabilirsiniz.
            starting: Console.Write("0-999.999 arasında bir pozitif tam sayı giriniz : "); //burada kullanıcıya ne istediğimizi belirtiyoruz.
            int birler, onlar, yuzler, binler, onBinler, yuzBinler,sayi; // kullanıcağımız değişkenleri tanımladık.
            //Console.Write("0-999.999 arasında bir pozitif tam sayı giriniz : ");
            try //burada veri girişini  try bloğu içinde almamızın sebebi olası bir hata durumu ile karşılaşıalcak bir yer olması 
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi : "+sayi);
            }
            catch (Exception) 
            {
                Console.WriteLine("Lütfen pozitif tam sayi giriniz. Metinsel ifade girişi yapmayınız!"); //METİNSEL İFADENİN KONTROLÜNÜ YAKALADIĞIMIZ KISIM HATANIN GERÇEKLEŞMESİ DURUMUNDA ÇALIŞACAK KODLAR
                goto starting;
                throw;
                
            }
           
            if (sayi >= 0) //SAYININ 0 DAN BÜYÜK OLDUĞU DURUMDA YANİ POZİTİF OLMASI DURUMUNU KONTROL EDİYORUZ.
            {
                birler = sayi % 10;
                onlar = (sayi / 10) % 10;
                yuzler = (sayi / 100) % 10;
                binler = (sayi / 1000) % 10;
                onBinler = (sayi / 10000) % 10;
                yuzBinler = (sayi / 100000) % 10;
                string[] birlik = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
                string[] onluk = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };


                if (birler == 0 && onlar == 00 && yuzler == 0 && binler == 0 && onBinler == 0 && yuzBinler == 0)
                {
                    Console.WriteLine("Sıfır");
                }
                if (sayi >= 1000 && sayi >=100)
                {
                    if (yuzBinler != 0)
                    {
                        Console.Write(birlik[yuzBinler] + " " + "yüz ");
                    }
                    else if (yuzBinler == 1)
                    {
                        Console.Write("yüz bin");
                    }
                    Console.Write(onluk[onBinler] + " ");
                    Console.Write(birlik[binler] + " bin ");
                    Console.Write(birlik[yuzler] + "yüz ");
                }
                if (sayi <= 1000 && sayi>=100)

                {
                    if (yuzler != 0)
                    {
                        Console.Write(birlik[yuzler] + " " + "yüz ");
                    }
                    else if (yuzler == 1)
                    {
                        Console.Write("yüz");
                    }
                    Console.Write(birlik[yuzler] + " ");
                    
                }
                Console.Write(onluk[onlar] + " ");
                Console.Write(birlik[birler] + " ");
                Console.ReadKey();
            }
            else //SAYININ POZİTİF OLMAMA NEGATİFLİK DURUMUNDA YAPACAĞIMIZ İŞLEMLERİN OLDUĞU KISIM
            {
                Console.Clear();
                Console.WriteLine("Lütfen Pozitif Tam sayı giriniz Negatif giriş yapmayınız!");
                Console.Write("Devam Etmek istiyor musunuz Evet ='E' Hayır ='H'");
                
                string cevap = Convert.ToString(Console.ReadLine());
                if (cevap=="E"||cevap=="e")
                {
                    Console.WriteLine("işleme devam etmek için Lütfen bir tuşa basınız");
                    Console.ReadKey();
                    goto starting;
                }
                else
                {
                    Console.WriteLine("Çıkış yapılıyor iyi günler");
                    Console.ReadKey();
                }
               
            }
        }
    }
}