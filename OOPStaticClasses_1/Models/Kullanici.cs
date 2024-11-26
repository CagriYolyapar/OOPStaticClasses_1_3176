using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStaticClasses_1.Models
{
    public class Kullanici
    {
        public Kullanici()
        {
            KullaniciSayisi++;
        }
        public string Isim { get; set; }
        public string SoyIsim { get; set; }
        public static int KullaniciSayisi { get; set; }


    }
}
