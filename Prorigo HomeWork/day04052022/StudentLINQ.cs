using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorigo_HomeWork.day04052022
{
    public class StudentLINQ
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public double Percentage { get; set; }

        public string Branch { get; set; }
    }

    public class Display1
    {
        static void Main(string[] args)
        {
            List<StudentLINQ> studlist = new List<StudentLINQ>()
            {
                new StudentLINQ{Rollno=1,Name="Abhay",Percentage=80,Branch="Electronics"},
                new StudentLINQ{Rollno=2,Name="Rakesh",Percentage=40,Branch="Commerce"},
                new StudentLINQ{Rollno=3,Name="Mohit",Percentage=60,Branch="Civil"},
                new StudentLINQ{Rollno=4,Name="Aksah",Percentage=75,Branch="Mechanical"},
                new StudentLINQ{Rollno=5,Name="Swapnil",Percentage=65,Branch="Instrumentation"},
            };

            /* var result = from sl in studlist
                          orderby sl.Name descending
                          select sl;*/

            /* var result = from sl in studlist
                         where sl.Branch.Contains("Instrumentation")
                          select sl;*/

            /*var result = from sl in studlist
                         where sl.Name.StartsWith('A') || sl.Name.StartsWith('R')
                         select sl;*/

            /* var result = from sl in studlist
                          where sl.Percentage>60
                          select sl;*/

            var result = from sl in studlist
                         where sl.Rollno%2!=0
                         select sl;

            foreach (StudentLINQ sl in result)
            {
                Console.WriteLine($"{sl.Rollno} {sl.Name} {sl.Percentage} {sl.Branch}");
            }
            
        }
    }
}
