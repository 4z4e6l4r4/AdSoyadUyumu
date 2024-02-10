using System.Security.Cryptography.X509Certificates;

namespace AdSoyadUyumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sAd = "Azra";
            string sSoyad = "Yüksel";

            start:

            Console.WriteLine("Ad giriniz: ");
            string gAd = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Soyad giriniz: ");
            string gSoyad = Convert.ToString(Console.ReadLine());

            if (sAd == gAd && sSoyad == gSoyad) 
            {
                Console.WriteLine("Giriş Başarılı!");
            }


            else if (sAd != gAd && sSoyad == gSoyad)
            {
                Console.WriteLine("Adınız Hatalı!");
                goto start;
            }

            else if (sAd == gAd && sSoyad != gSoyad)
            {
                Console.WriteLine("Soyadınız Hatalı!");
                goto start;
            }

       



        }
    }
}