using System;

namespace _20170809_1Con_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aynı tipte aynı amaç için birden fazla değer tutulacaksa diziler kullanılır.
            //Bir değişkeni dizi haline getirmek için tipin sonuna [] konur.
            //Diziler tanımlanırken ne kadar yer kaplayacakları belli olsun diye instance olarak üretilmelidirler. bu da new komutu ile olur. new string[20]; diyerek kaç eleman tutabielceğini belirtmek gerekmektedir.

            string[] kisi; // bu sadece değişken gibi tanımlanmış şekilde. herhangi bir instance verilmediği için bellekte null gösterir. eğer program içerisinde kullanılmazsa GC tarafından temizlenir.

            // index herzaman 0 dan başlar. index, elemanın başlangıçtan uzaklığını belirtir.

            string[] kisiler = new string[20]; // şuanda bellekte 20 adet yer ayırdı.
            kisiler[0] = "Murtaza";
            Console.Write(kisiler[0]); // murtaza bilgisini verir

            // baştan tanımlanacak bir değer var ise aşağıdaki 2 örnekte olduğu gibi tanımlanabilir.
            string[] hg = new string[] { "Pazartesi", "Salı", "Çarşamba", "Perşembe" , "Cuma" , "Cumartesi" , "Pazar"}; //1
            string[] hg2 = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuma", "Cumartesi", "Pazar" };//2

            Console.Read();
            
                       
        }
    }
}
