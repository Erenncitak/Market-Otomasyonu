using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketOtomasyonu.model
{
    public class Urun
    {
        public string id { get; set; }
        public string qrkod { get; set; }
        public string barkodKod { get; set; }
        public DateTime olusturulma_Tarih { get; set; }
        public DateTime guncellenme_Tarih { get; set; }
        public string urunIsim { get; set; }
        public float kilo { get; set; }
        public int fiyat { get; set; }
        public int ciro { get; set; }
    }
}
