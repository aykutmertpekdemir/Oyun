using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiYarismasiOyunu
{
    class Program
    {
        public static void BilgiYarismasi()
        {
            Console.Title = "Bilgi Yarışması";
            Console.WriteLine("********************\nYarışmaya Hoşgeldiniz: ");
            Console.Write("Adınızı ve soyadınızı giriniz: ");
            string tamad = Console.ReadLine();
            Console.WriteLine("İlerlemek için 'Enter' tuşuna basınız:\nNOT: Her doğru cevabınız size 1000 TL kazandıracaktır. ");
            Console.ReadLine();
            int dogru = 0, yanlis = 0, para = 0;
            for (int i = 0; i < 11; i++)
            {
                Console.Clear();
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Soru 1- Cumhuriyet kaç yılında ilan edilmiştir?\n" + "A)1920\nB)1923\nC)1924\nD)1926");
                        break;
                    case 1:
                        Console.WriteLine("Soru 2- Türkiye'nin Başkenti hangi şehirdir?\n" + "A)İstanbul\nB)Konya\nC)Ankara\nD)İzmir");
                        break;
                    case 2:
                        Console.WriteLine("Soru 3- Maki hangi bölgenin bitki örtüsüdür?\n" + "A)Marmara\nB)Akdeniz\nC)İç Anadolu\nD)Karadeniz");
                        break;
                    case 3:
                        Console.WriteLine("Soru 4- Aşağıdakilerden hangisi İstanbul'da bulunan bir semt değildir?\n" + "A)Üsküdar\nB)Avcılar\nC)Kağıthane\nD)Urla");
                        break;
                    case 4:
                        Console.WriteLine("Soru 5- Aşağıdakilerden hangisi programlamada bulunan temel renklerden değildir?\n" + "A)Sarı\nB)Mavi\nC)Yeşil\nD)Kırmızı");
                        break;
                    case 5:
                        Console.WriteLine("Soru 6- Avrupanın kullandığı ortak para birimi nedir?\n" + "A)Dolar\nB)Zloty\nC)Euro\nD)Ruble;");
                        break;
                    case 6:
                        Console.WriteLine("Soru 7- Hangi ilimiz ege bölgesinde değildir?\n" + "A)İzmir\nB)Muğla\nC)Edirne\nD)Aydın");
                        break;
                    case 7:
                        Console.WriteLine("Soru 8- Sefiller kitabının yazarı kimdir?\n" + "A)Jules Verne\nB)Gogol\nC)Tolstoy\nD)Victor Hugo");
                        break;
                    case 8:
                        Console.WriteLine("Soru 9- Mustafa Kemal Atatürk'ün nüfusa kayıtlı olduğu il hangisidir?\n" + "A)İstanbul\nB)Gaziantep\nC)Ankara\nD)Samsun");
                        break;
                    case 9:
                        Console.WriteLine("Soru 10- İstiklal Marşı şairimiz kimdir?\n" + "A)Ziya Gökalp\nB)Orhan Veli\nC)Mehmet Akif Ersoy\nD)Reşat Nuri Güntekin");
                        break;
                    case 10:
                        Console.WriteLine("Soru 11- Tiger Woods hangi sporun en önemli temsilcisidir?\n" + "A)Futbol\nB)Golf\nC)Tenis\nD)Masa Tenisi");
                        break;
                }
                Console.WriteLine();
                Console.Write("Cevabı Giriniz: ");
                char[] cevap = { 'b', 'c', 'b', 'd', 'a', 'c', 'c', 'd', 'b', 'c', 'b' };
                char[] cevap2 = { 'B', 'C', 'B', 'D', 'A', 'C', 'C', 'D', 'B', 'C', 'B' };
                char cvp = Convert.ToChar(Console.ReadLine());

                if (cevap[i] == cvp || cevap2[i] == cvp)
                {
                    para = para + 1000;
                    dogru++;
                }
                else
                {
                    yanlis++;
                    Console.WriteLine("Cevabınız Yanlış, Doğru Cevap:" + cevap[i]);
                    Console.ReadKey();
                }
            }
            Console.Clear();
            Console.WriteLine("***Tebrikler Yarışmayı Tamamladınız***\n" + "Sonuçlar: Doğru Cevap Sayısı: {0} Yanlış Cevap Sayısı: {1}", dogru, yanlis);
            Console.WriteLine("Sayın {0}, Yarışmamızdan Toplam Kazandığınız Para Ödülü: {1}", tamad, para);           
        }

        public static void SayiTahminOyunu()
        {
            Random random = new Random();
            Console.Title = "Sayı Tahmini Yarışması";
            Console.WriteLine("********************\nYarışmamıza Hoşgeldiniz: ");
            Console.Write("Adınızı ve soyadınızı giriniz: ");
            string tamad = Console.ReadLine();
            Console.WriteLine("Şimdi sizin için 1 ile 250 arasında bir sayı belirledik ve bunu tahmin etmenizi bekliyoruz.\nHadi o zaman ilk tahmininizi yapın ");
            int tahmin = 0 ,sayi = random.Next(0, 251) , sayac = 0;
            while (tahmin != sayi )
            {
                sayac++;
                Console.Write("Tahmin edin: ");
                tahmin = Convert.ToInt32(Console.ReadLine());
                if (tahmin < sayi)
                {
                    Console.WriteLine("Sayımızdan küçüksünüz. Daha büyük bir tahmin giriniz: ");                    
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("Sayımızı geçtiniz. Daha küçük bir tahmhin giriniz");
                }
            }
            Console.WriteLine("Tebrikler, {0}. denemenizde bildiniz.\nTahmininiz: {1}\nSayı: {2}",sayac,tahmin,sayi);
        }
        public static void Secim()
        {
            Console.Write("Oynamak istediğiniz oyunu seçiniz: \n1-)Bilgi Yarişması\n2-)SayıTahminOyunu\nSeçim: ");
            int secim = Convert.ToInt32(Console.ReadLine());
            if (secim == 1)
            {
                BilgiYarismasi();
            }
            else if (secim == 2)
            {
                SayiTahminOyunu();
            }
            else
            {
                Console.WriteLine("Hatalı bir tuşlama yaptınız");
            }
        }

        static void Main(string[] args)
        {
            Secim();

            Console.WriteLine("Ana menüye dönmek için lütfen 1'i tuşlayınız:");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (bas == 1)
            {
                default:Secim();
                    break;
            }
            Console.WriteLine("\nKatılımınız için teşekkür ederiz:");
            Console.ReadKey();
                      
        }                  
    }
}
