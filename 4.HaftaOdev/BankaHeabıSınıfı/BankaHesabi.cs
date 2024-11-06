using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaHeabıSınıfı
{
    public class BankaHesabi
    {
        public string HesapNumarasi { get; set; }
        private decimal bakiye;

        public decimal _bakiye
        {
            get { return _bakiye; }
          private  set { _bakiye = value; }
        }




        public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
        {
            HesapNumarasi = hesapNumarasi;
            _bakiye = ilkBakiye; // İlk bakiyeyi belirleyelim
        }

        public decimal parayatir(decimal miktar)
        {
            decimal yenibakiye=miktar +bakiye;

            return yenibakiye;
        }
        public decimal paracek(decimal miktar)
        {
            if (miktar > bakiye)
            {
                Console.WriteLine("hata");
                
            }
            else
            {
                decimal cekilen = bakiye - miktar;
            return cekilen;
            }
          
            return (decimal)this.bakiye;
        }

    }
}
