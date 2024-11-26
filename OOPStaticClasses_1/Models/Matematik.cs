using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPStaticClasses_1.Models
{
    //Static class'lar instance'landıgında özel bir özgünlük olusturmayacak ve ilgili nesnesinin varolus amacı olusturulacak bir baska nesneden asla farklı olmayacak  idealar karsımıza cıktıgında acılır. Böylece ilgili varolus asla degişmeyecegi, duragan kalacagı (static kalacagı) icin ondan bir instance olusturmak anlamsız olacaktır...Cünkü instance olusturmak demek bir amacı olan özel bir nesne olusturmak demektir...İlgili nesnenin özgün olmasıdır...Eger bir sınıf, kac nesne olusturulursa olusturulsun bu nesneler hala toplu olarak tek bir amaca hizmet ediyorsa (birbirlerine nazaran bir varolus farklılıgı yaratmıyorsa) o zaman özgünlüklerini kaybedeceklerdir...Böyle bir durumda class'ın static olarak olusturulması onun nesne olusturulmadan amacını direkt yapmasını saglar...

    //Static sınıflar miras alamazlar,miras veremezler, instance'ları alınamaz, Ram'e direkt cıkartılırlar ve iclerinde sadece static ogeler barındırabilirler...


    //Instance member : Bir class'ın sadece instance'i alınarak ulasılan bir ögesidir

    //Static Member : Sınıfın sadece kendisi üzerinden ulasılabilen ögedir
    public static class Matematik
    {


        
        static Matematik()
        {

        }

        //Bir öge static keyword'u icermiyorsa o instance member'dir...Static class'lar instance member barındıramaz...
        public static string KareAl(int sayi)
        {
            if (sayi < 0)
            {
                return "0'dan byük bir sayı giriniz";
            }
            return (sayi * sayi).ToString();
        }
    }
}
