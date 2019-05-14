using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class Ogrenci
    {
        private string ogrenciIsmi,kayitTarihi,ogrenciBolum, ogrenciNo, notOrtalamasi;



        public string OgrenciIsmi
        {
            get { return ogrenciIsmi; }
            set { ogrenciIsmi = value; }
        }

        public string KayitTarihi
        {
            get { return kayitTarihi; }
            set { kayitTarihi = value; }
        }

        public string OgrenciBolum
        {
            get { return ogrenciBolum; }
            set { ogrenciBolum = value; }
        }

       
        public string OgrenciNo
        {
            get { return ogrenciNo; }
            set { ogrenciNo = value; }
        }

        public string NotOrtalamasi
        {
            get { return notOrtalamasi; }
            set { notOrtalamasi = value; }
        }

    }
}
