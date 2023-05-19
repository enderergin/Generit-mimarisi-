using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(); //object tipinde değer tutar null değerlerde tutar
            ht.Add(1, 2);
            ht.Add(2, "üc");
            ht.Add(3, "şakşuka");
            ht.Add(4,true); 
            ht.Add(5,false);
   
            Dictionary<int, string> ds = new Dictionary<int, string>(); // hachtable'ın gelişmiş hali  //değer atamak zorundasın
            ds.Add(4, "ender");
            ds.Add(2, "ergin");
            ds.Add(3, "eşref");
            bool silme = ds.Remove(1);
            if ( silme )
            {
                Console.WriteLine("silindi");
            }
            else
            {
                Console.WriteLine("böyle bir değer bulunamdı");
            }

            if ( ds.ContainsKey(1)) // key olarak değeri arar
            {
                ds.Remove(1);
                Console.WriteLine("değer silindi");
            }
            else
            {
                ds.Add(1, "enderrr");
                Console.WriteLine("değer girildi");
                ds.Reverse();

            }
            bool aranandeger = ds.ContainsValue("bir"); // kolleksiyon içerinde değer arıyor.
            if ( aranandeger )
            {
                Console.WriteLine("aranan değer bulundu");
            }
            else
            {
                Console.WriteLine("değer bulunamadı");
            }
            var sirala = ds.OrderByDescending(x => x.Key);// key değerine göre büyükte küçüğe sıralar

            foreach (var item in sirala)
            {
                Console.WriteLine("içerisindeki key değeri {0} value değeri: {1}",item.Key,item.Value);

            }

            var kucuktenBuyuge = ds.OrderBy(x => x.Key); // key değerine göre küçükten büyüğe sıralar
            foreach (var item in kucuktenBuyuge)
            {
                Console.WriteLine("küçükden büyüğe sıralanması {0} value değeri {1}", item.Key, item.Value);
            }

            SortedList<int, string> srt = new SortedList<int, string>(); //Dictionary'ini aynısı sadece Key'e göre ilkten sona sıralar
            srt.Add(1, "bir");
            srt.Add(2, "iki");
            srt.Add(100, "yüz");
            srt.Add(1342, "binüçyüzkırkiki");
            foreach (var item in srt)
            {
                Console.WriteLine("sıralı sistemi {0} value {1} ",item.Key,item.Value);
            }
         }
    }
}
