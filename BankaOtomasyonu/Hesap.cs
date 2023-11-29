using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaOtomasyonu
{
    public class Hesap 
    {
        public int HesapNo { get; set; }
        public int Bakiye { get; set; }
        public int EkBakiye { get; set; }
        public int GunlukLimit { get; set; } = 750;
        public List<int> Hesaplarim = new List<int>();

        public List<HesapOzetiRapor> RaporListesi { get; set; }

        public Hesap()
        {
            Random rnd = new Random();
            this.HesapNo = rnd.Next(1000, 9999);

        }

    }
}
