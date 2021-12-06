using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci1=new ogrenci();
            ogrenci1.Isim="Volkan";
            ogrenci1.Soyisim="Şallı";
            ogrenci1.Ogrencino=040070071;
            ogrenci1.Sinif=4;
            ogrenci1.ogrencibilgileri();
            ogrenci1.sinifdusur();
            Console.WriteLine(ogrenci1.Sinif);
            ogrenci1.sinifdusur();
            Console.WriteLine(ogrenci1.Sinif);
            ogrenci1.sinifdusur();
            Console.WriteLine(ogrenci1.Sinif);
            ogrenci1.sinifdusur();
            Console.WriteLine(ogrenci1.Sinif);
            ogrenci1.sinifdusur();
            Console.WriteLine(ogrenci1.Sinif);



        }
    }
    class ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrencino;
        private int sinif;

        public string Isim { 
            get{return isim;}
            set{isim = value;} }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Ogrencino { get => ogrencino; set => ogrencino = value; }
        public int Sinif { get => sinif; 
        set{
        if(value < 2)
        {
        Console.WriteLine("Sinif en az 1 olabilir");
        sinif = 1;
        }
        else
        sinif=value;
            } 
        }

        public ogrenci(string isim, string  soyisim, int ogrencino, int sinif)
        {

            Isim = isim;
            Soyisim = soyisim;
            Ogrencino = ogrencino;
            Sinif = sinif;
        }
        public ogrenci(){}

        public void ogrencibilgileri()
        {
            Console.WriteLine("********Ogrenci Bilgileri********");
            Console.WriteLine("Ogrenci adi:     {0}",this.Isim);
            Console.WriteLine("Ogrenci soyadi:     {0}",this.Soyisim);
            Console.WriteLine("Ogrenci no:     {0}",this.Ogrencino);
            Console.WriteLine("Ogrenci sinifi:     {0}",this.Sinif);
        }

        public void sinifatlat()
        {
            this.Sinif++;
        }
        public void sinifdusur()
        {
            this.Sinif--;
        }


    }
}
