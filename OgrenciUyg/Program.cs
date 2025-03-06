using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUyg
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(3, "Fikret", "Sınmaz", 75, 80, 90, "Necmettin Erbakan"); //yapıcı metodu burada kullandık

            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            

            

            while (kontrol)
            {
                IslemleriGoster();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.OgrenciBilgileriGoster();
                        break;

                    case "2":
                        double ogrenciOrtalama = ogrenci1.OgrenciOrtalamasiBul();
                        Console.WriteLine("Öğrencinin ortalaması : " + ogrenciOrtalama);
                        break;

                    case "3":
                        ogrenci1.okulGetir();
                        break;

                    case "4":
                        kontrol = false;
                        break;



                }
            }

        }
            static void IslemleriGoster()
        {
            Console.WriteLine("1 - Öğrenci bilgileri göster");
            Console.WriteLine("2 - Öğrencinin ortalamasını göster");
            Console.WriteLine("3 - Öğrencinin okulunu göster");
            Console.WriteLine("4 - Çıkış");
        }
    }
}
