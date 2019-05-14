using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class OgrenciGorunum
    {

        public void bilgileriYazdir(string OgrenciIsmi, string KayitTarihi, string OgrenciBolum, string OgrenciNo, string NotOrtalamasi)
        {
            Console.WriteLine(OgrenciIsmi);
            Console.WriteLine(KayitTarihi);
            Console.WriteLine(OgrenciBolum);
            Console.WriteLine(OgrenciNo);
            Console.WriteLine(NotOrtalamasi);
        }

        public void binary(List<Ogrenci> list)
        {

            using (var s = File.OpenWrite(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\binary.bin"))
            {
                var bw = new BinaryWriter(s);

                foreach(Ogrenci i in list)
                {
                    bw.Write(Encoding.ASCII.GetBytes(i.OgrenciIsmi));
                    bw.Write(Encoding.ASCII.GetBytes(i.OgrenciNo));
                    bw.Write(Encoding.ASCII.GetBytes(i.NotOrtalamasi));
                    bw.Write(Encoding.ASCII.GetBytes(i.KayitTarihi));
                    bw.Write(Encoding.ASCII.GetBytes(i.OgrenciBolum));
                }
            }
           
        }
    }
}
