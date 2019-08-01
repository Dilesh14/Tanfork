using Filters.Models;
using Filters.Models.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Filters
{
    class Program
    {
        public static void Main()
        {
            Datas data = new Datas();
            FilterLogic Logic = new FilterLogic();
            IList<Theme> product = new List<Theme>() { data.t1, data.t2, data.t3, data.t4, data.t5, data.t6 };
            Console.WriteLine("Products are ::::::");
            foreach (Theme t in product)
            {
                Console.WriteLine($"{t.Color} --- {t.NumOfPhotos} --- {t.Orientation} ");
            }
            Console.ReadLine();
            Console.WriteLine("Filtering for landscape Or Port And Num photos =3 and color = Red");
            foreach(Theme t in product.Where(x=>(Logic.IsLand(x) ||Logic.IsPort(x))&&(Logic.IsNum3(x))&&(Logic.IsRed(x))))
            {
                Console.WriteLine($"{t.Color} --- {t.NumOfPhotos} --- {t.Orientation} ");
            }
        }
    }
}
