using System;

namespace MyNamespace
{
    class Program
    {
        public static void Main(string[] args)
        {
            // List<t> class
            //System.Collections.Generic
            //T-> object türündedir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(10);
            sayiListesi.Add(6);
            sayiListesi.Add(92);
            sayiListesi.Add(18);
            sayiListesi.Add(15);
            sayiListesi.Add(4);

            List<string> RenkListesi = new List<string>();

            RenkListesi.Add("Kırmızı");
            RenkListesi.Add("Mavi");
            RenkListesi.Add("Sarı");
            RenkListesi.Add("Turuncu");
            RenkListesi.Add("Yesil");

            // Count 

            Console.WriteLine(sayiListesi.Count);
            Console.WriteLine(RenkListesi.Count);

            // foreach ve listForeach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in RenkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            RenkListesi.ForEach(renk => Console.WriteLine(renk));

            // listeden eleman çıkarma
            sayiListesi.Remove(4);
            RenkListesi.Remove("Mavi");

            sayiListesi.RemoveAt(1); // 1. index
            RenkListesi.RemoveAt(0); // 0. index

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            RenkListesi.ForEach(renk => Console.WriteLine(renk));

            // Liste içerisinde arama 
            if (sayiListesi.Contains(92))
            {
                Console.WriteLine("sayi 92 liste içerisinde bulundu");
            }

            // Eleman ile index e erişme
           Console.WriteLine( RenkListesi.BinarySearch("Sarı"));

           // Diziyi Liste Çevirme

           string [] hayvanlar = {"Ayı" ,"Kuş", "Aslan"};

           List<string> hayvanlarListesi = new List<string>(hayvanlar);

           // Liste Temizleme

           hayvanlarListesi.Clear();

           // Liste İçerisinde nesne tutmak
           List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

           Kullanıcılar kullanıcılar1 = new Kullanıcılar();

           kullanıcılar1.Isim ="Halil";
           kullanıcılar1.Soyisim = "Özcan";
           kullanıcılar1.Yas = 24;

           Kullanıcılar kullanıcılar2 = new Kullanıcılar();

           kullanıcılar2.Isim ="Hakan";
           kullanıcılar2.Soyisim = "Özcan";
           kullanıcılar2.Yas = 20;

           kullanıcıListesi.Add(kullanıcılar1);
           kullanıcıListesi.Add(kullanıcılar2);


           List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
           yeniListe.Add(new Kullanıcılar(){
            Isim = "Deniz",
            Soyisim ="Çağlayan",
            Yas = 24
           });

           foreach (var kullanıcı in kullanıcıListesi)
           {
            Console.WriteLine("kullanıcı Adi : " + kullanıcı.Isim);
            Console.WriteLine("Kullanıcı Soyisim : " + kullanıcı.Soyisim);
            Console.WriteLine("Kullanıcı Yasi : " + kullanıcı.Yas);
           }

           yeniListe.Clear();



        }
    }

    public class Kullanıcılar
    {
         private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}