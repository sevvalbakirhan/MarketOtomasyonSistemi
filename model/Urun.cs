using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace market.model
{
    public class Urun
    {
        public string id { get; set; }
        public string qrkod { get; set; }
        public string barkodkod { get; set; }
        public  DateTime olusturulma_Tarih { get; set; }
        public DateTime güncelleme_Tarih { get; set; }
        public string urunİsim { get; set; }
        public float kilo { get; set; }
        public int fiyat { get; set; }
        public int ciro { get; set; }


    }
}
