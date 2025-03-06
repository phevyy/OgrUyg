using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUyg
{
    public class Ogrenci
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        private int vize1;
        private int vize2;
        private int final;
        private string okulismi;

        public Ogrenci(int _ogrenciNo, string _isim, string _soyisim, int _vize1, int _vize2, int _final, string _okulismi)
        {
            ogrenciNo = _ogrenciNo;
            isim = _isim;
            soyisim = _soyisim;
            vize1 = _vize1;                        // Yapıcı metot yazılışı
            vize2 = _vize2; 
            final = _final;
            okulismi = _okulismi;
        }

        public void OgrenciBilgileriGoster()
        {
            Console.WriteLine("Öğrencinin Numarası : " + ogrenciNo);
            Console.WriteLine("Öğrencinin ismi : " + isim);
            Console.WriteLine("Öğrencinin soyismi : " + soyisim);
            Console.WriteLine("Öğrencinin Vize1 Notu : " + vize1);
            Console.WriteLine("Öğrencinin Vize2 Notu : " + vize2);
            Console.WriteLine("Öğrencinin Final Notu : " + final);
            Console.WriteLine("Öğrencinin Okul İsmi : " + okulismi);
        }
        public double OgrenciOrtalamasiBul()
        {
            double ortalama = vize1 * 0.2 + vize2 * 0.2 + final * 0.6;
            return ortalama;
        }
        public void okulGetir()
        {
            Console.WriteLine("Okul ismi : " + okulismi);
        }

    }


}
