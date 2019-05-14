using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> liste = new List<Ogrenci>();
            Ogrenci ogrenci = new Ogrenci();
            OgrenciGorunum ogrenciGorunum = new OgrenciGorunum();
            OgrenciKontrolcusu ogrenciKontrolcusu;


            foreach (string line in File.ReadLines(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\ogrenci.txt.", Encoding.UTF8))
            {
                string[] temp = line.Split(',');
                Ogrenci tempogrenci = new Ogrenci();
                tempogrenci.OgrenciIsmi = temp[0];
                tempogrenci.OgrenciNo = temp[1];
                tempogrenci.NotOrtalamasi = temp[2];
                tempogrenci.KayitTarihi = temp[3];
                tempogrenci.OgrenciBolum = temp[4];

                liste.Add(tempogrenci);
            }



            liste = liste.OrderBy(o => o.OgrenciNo).ToList();


            ogrenci.OgrenciIsmi = liste[9].OgrenciIsmi;
            ogrenci.OgrenciNo = liste[9].OgrenciNo;
            ogrenci.NotOrtalamasi = liste[9].NotOrtalamasi;
            ogrenci.KayitTarihi = liste[9].KayitTarihi;
            ogrenci.OgrenciBolum = liste[9].OgrenciBolum;

            ogrenciKontrolcusu = new OgrenciKontrolcusu(ogrenci, ogrenciGorunum);

            Console.WriteLine("Değişmeden Önce ->\n");
            ogrenciKontrolcusu.bilgileriGoruntule();
            ogrenciKontrolcusu.bilgileriDegistir("Cagatay", "10.10.2015", "Bilgisayar Mühendisliği", "2016280053", "75.5");
            Console.WriteLine("\nDeğiştikten Sonra ->\n");
            ogrenciKontrolcusu.bilgileriGoruntule();

            ogrenciKontrolcusu.bilgileriSirala(liste);

            Console.Read();
        }
    }
}
