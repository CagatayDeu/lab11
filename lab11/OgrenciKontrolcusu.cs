using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11
{
    class OgrenciKontrolcusu
    {
        private Ogrenci ogrenci;
        private OgrenciGorunum ogrenciGorunum;

        public OgrenciKontrolcusu(Ogrenci ogrenci, OgrenciGorunum ogrenciGorunum)
        {
            this.ogrenci = ogrenci;
            this.ogrenciGorunum = ogrenciGorunum;
        }

        public void bilgileriDegistir(string ogrenciIsmi, string kayitTarihi, string ogrenciBolum, string ogrenciNo, string notOrtalamasi)
        {
            ogrenci.OgrenciIsmi = ogrenciIsmi;
            ogrenci.KayitTarihi = kayitTarihi;
            ogrenci.OgrenciBolum = ogrenciBolum;
            ogrenci.OgrenciNo = ogrenciNo;
            ogrenci.NotOrtalamasi = notOrtalamasi;
        }

        public void bilgileriGoruntule()
        {
            ogrenciGorunum.bilgileriYazdir(ogrenci.OgrenciIsmi, ogrenci.KayitTarihi, ogrenci.OgrenciBolum, ogrenci.OgrenciNo, ogrenci.NotOrtalamasi);
        }

        public void bilgileriSirala(List<Ogrenci> list)
        {
            ogrenciGorunum.binary(list);
        }
    }
}
