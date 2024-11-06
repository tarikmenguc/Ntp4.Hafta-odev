using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaSınıfı
{
    public class KiralikArac
    {
        public string Plaka { get; set; }
        public decimal GunlukUcret { get; set; }
        public bool MusaitMi { get; private set; }

        public KiralikArac(string plaka, decimal gunlukUcret)
        {
            Plaka = plaka;
            GunlukUcret = gunlukUcret;
            MusaitMi = true;
        }

        public void AraciKirala()
        {
            if (MusaitMi)
            {
                MusaitMi = false;
                Console.WriteLine("Araç kiralandı.");
            }
            else
            {
                Console.WriteLine("Araç zaten kirada.");
            }
        }

        public void AraciTeslimEt()
        {
            if (!MusaitMi)
            {
                MusaitMi = true;
                Console.WriteLine("Araç teslim edildi.");
            }
            else
            {
                Console.WriteLine("Araç zaten müsait.");
            }
        }
    }

}
