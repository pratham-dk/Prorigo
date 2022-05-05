using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prorigo_HomeWork.day04052022
{
    public class CourseLINQ
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Fees { get; set; }



    }

    public class Display
    {
        static void Main(string[] args)
        {
            List<CourseLINQ> cl = new List<CourseLINQ>()
        {
            new CourseLINQ{Id=4001,Name="C#",Fees=30000 },
             new CourseLINQ{Id=4002,Name="Java",Fees=25000 },
              new CourseLINQ{Id=4003,Name="Full stack",Fees=50000 },
               new CourseLINQ{Id=4004,Name="Python",Fees=15000 },
                new CourseLINQ{Id=4005,Name="AI",Fees=100000 },
        };

            /* var result = from c in  cl
                          where c.Name.Contains("Full")
                         select c;*/

            /* var result = from c in cl
                          where c.Fees>40000
                          select c;*/

            /*var result = from c in cl
                         orderby c.Name
                         select c;*/

            /*var result = from c in cl
                         where c.Id>=4002 && c.Id<=4004
                         select c;*/

            var result = from c in cl
                         where c.Name.StartsWith('J')
                         select c;

            foreach (CourseLINQ c in result)
            {
                Console.WriteLine($"{c.Id} {c.Name} {c.Fees}");
            }
        }
    }
}
