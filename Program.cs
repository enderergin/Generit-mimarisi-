using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string>();

            for (int i = 0;  i < 5; i++)
            {
                Console.WriteLine("5 string girin");
                string a = Console.ReadLine();
                isimler.Add(a);
            }

            List<baseClass> list = new List<baseClass>();
            list.Add(new baseClass()
            {
                id = 1,
                isim ="ender",
                soyisim = "ergin",


            });
            foreach (baseClass item in list)
            {
                Console.WriteLine(item.isim, item.id, item.soyisim);
            }
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            Console.ReadLine();
        }
    }
}
