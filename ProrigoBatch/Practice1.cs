using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch
{
    public class Product:IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

       /* public void Salary {  get ; set; }  */
        public int CompareTo(Object obj)
        {
            Product p = (Product)obj;
           if(this.Price > p.Price)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            }
    }



    public class Program
    {
        static void Main(string[] args)
        {
            Product p1=new Product { Id = 1 , Price = 34000 };
            Product p2 = new Product { Id = 2, Price = 35000 };

            int result = p1.CompareTo(p2);

            if (result == 1)
            {
                Console.WriteLine("HP  costs more than DELL");
            }
            else
            {
                Console.WriteLine("DELL costs more than HP");
            }

        }
    }
}
