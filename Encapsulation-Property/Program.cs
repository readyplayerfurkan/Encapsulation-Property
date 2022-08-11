using System;

namespace Patika
{
    class Program
    {
        static void Main()
        {
            Ogrenci ogrenci1 = new Ogrenci("Furkan", "Yılmaz", 1, 256);
            ogrenci1.OgrenciBilgileriniGetir();

            Ogrenci ogrenci2 = new Ogrenci("Emir", "Akbaş", 2, 253);
            ogrenci2.SinifiAzalt();            
            ogrenci2.SinifiAzalt();
            ogrenci2.OgrenciBilgileriniGetir();
        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int no;
        private int sinif;

        public string Isim 
        {
            get { return isim; }
            set { isim = value; } 
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int No { get => no; set => no = value; }
        public int Sinif 
        { 
            get => sinif;
            set
            { 
                if (value < 1)
                {
                    Console.WriteLine("Sınıf 1'den küçük olamaz!");
                    value = 1;
                }
                else
                    sinif = value; 
            }
        }

        public Ogrenci(string isim, string soyisim, int sinif, int no)
        {
            No = no;
            Soyisim = soyisim;
            Sinif = sinif;
            Isim = isim;
        }

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******* Öğrenci Bilgileri ********");
            Console.WriteLine("Öğrenci Adı          :{0}", this.isim);
            Console.WriteLine("Öğrenci Soyad        :{0}", this.soyisim);
            Console.WriteLine("Öğrenci No           :{0}", this.no);
            Console.WriteLine("Öğrenci Sınıf        :{0}", this.sinif);
        }

        public void SinifiAzalt()
        {
           this.Sinif -= 1;
        }

        public Ogrenci() { }
    }
}
