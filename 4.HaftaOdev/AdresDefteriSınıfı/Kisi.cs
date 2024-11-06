using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdresDefteriSınıfı
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TelefonNumarasi { get; set; }

        public Kisi(string ad, string soyad, string telefonNumarasi)
        {
            Ad = ad;
            Soyad = soyad;
            TelefonNumarasi = telefonNumarasi;
        }

        public string KisiBilgisi()
        {
            return $"{Ad} {Soyad} - Telefon: {TelefonNumarasi}";
        }
    }

}
