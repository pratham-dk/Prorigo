using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch.day04052022
{
    public class Product
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class Display
    {
        static void Main(string[] args)
        {
            List<Product> prodlist = new List<Product>()
            {
                new Product{ID=1,Name="Hp Laptop",Price=34000 },
                new Product{ID=2,Name="Lenovo Laptop",Price=35000 },
                new Product{ID=3,Name="Dell Laptop",Price=37000 },
                new Product{ID=4,Name="Asus Laptop",Price=32000 },
                new Product{ID=5,Name="MSI Laptop",Price=39000 },
                new Product{ID=6,Name="Samsung Laptop",Price=34500 },
                 new Product{ID=7,Name="Hp Laptop",Price=36500 }
            };

            /*            var result1 = from p in prodlist
                                      where p.Price < 35000
                                      select p;*/

            /* var result1 = from p in prodlist
                           where p.Name.StartsWith('l')  &&   p.Name.StartsWith('L')
                           select p;*/


            var result1 = from p in prodlist
                          where p.Name.Contains("Dell")
                          select p;

            foreach(Product p in result1)
            {
                Console.WriteLine($"{p.Name} {p.Price}");
            }
        }
    }
}
