using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch.day04052022
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string City { get; set; }

        public double Salary { get; set; }

        public string Dept { get; set; }
    }

    public class Display2
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>()
            {
                new Employee { Id = 1101, Name = "Prashant", City = "Nagpur", Salary =60000, Dept = "Law" },
                 new Employee { Id = 1102, Name = "Prathamesh", City = "Pune", Salary = 45000, Dept = "Development" },
                  new Employee { Id = 1103, Name = "Sakshi", City = "Mumbai", Salary = 25000, Dept = "PR" },
                   new Employee { Id = 1104, Name = "Manav", City = "Delhi", Salary = 30000, Dept = "Marketing" },
                    new Employee { Id = 1105, Name = "Sonam", City = "Indor", Salary = 50000, Dept = "HR" },
                     new Employee { Id = 1106, Name = "Prashant", City = "Nagpur", Salary = 23000, Dept = "Law" },
                      new Employee { Id = 1107, Name = "Ronny", City = "Pune", Salary = 23000, Dept = "Law" },
                       new Employee { Id = 1108, Name = "Komal", City = "Nagpur", Salary = 23000, Dept = "Law" },
                        new Employee { Id = 1109, Name = "Ketan", City = "Pune", Salary = 40000, Dept = "Law" },
                         new Employee { Id = 1110, Name = "amol", City = "Chandigarh", Salary = 33000, Dept = "Law" },
            };

            /* var result1 = from e in empList
                           where e.Salary > 45000
                           select e;*/

            /*var result1 = from e in empList
                          orderby e.Name
                          select e;*/

            /* var result1 = from e in empList
                           where e.City.Contains("Mumbai")
                           select e;
 */
            /*var result1 = from e in empList
                          where e.Dept == "HR"
                          select e;*/

            /*var result1 = from e in empList
                         orderby e.Salary descending
                          select e;*/

            /* var result1 = from e in empList
                           where e.Name.StartsWith('a') || e.Name.StartsWith('K')
                           select e;*/

            var result1 = from e in empList
                          where e.City == "Pune" && e.Salary < 35000
                          select e;


            foreach (Employee e in result1)
            {
                Console.WriteLine($"{e.Id} {e.Name} {e.City} {e.Salary} {e.Dept}");
            }
        }
    }
}