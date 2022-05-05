using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch
{ 
    public class Practice2
    {
    static void Main(string[] args)
    {
        List<int> list1 = new List<int>();
        list1.Add(10);
        list1.Add(20);

        List<string> list2 = new List<string>();
        list2.Add("Hi");
        list2.Add("Hello");



        foreach(int i in list1)
        {
            Console.WriteLine(i);
        }

        foreach(string i in list2)
        {
            Console.WriteLine(i);
        }

        List<Product> productsList = new List<Product>();
            {
                new Product { Id = 1, Name = "HP", Price = 33000 };
                new Product { Id = 2, Name = "DEll", Price = 34000 };
                new Product { Id = 3, Name = "lenovo", Price = 38000 };

                foreach(Product p in productsList)
                {
                    Console.WriteLine(p.Id);
                }
            }

    }
    }
}
