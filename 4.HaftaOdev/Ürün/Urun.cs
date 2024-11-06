using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün
{
    public class Urun
    {
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        private decimal _indirim;

        public decimal Indirim
        {
            get => _indirim;
            set
            {
                if (value < 0) _indirim = 0;
                else if (value > 50) _indirim = 50;
                else _indirim = value;
            }
        }

        public Urun(string ad, decimal fiyat)
        {
            Ad = ad;
            Fiyat = fiyat;
        }

        public decimal IndirimliFiyat()
        {
            return Fiyat * (1 - Indirim / 100);
        }
    }

}
