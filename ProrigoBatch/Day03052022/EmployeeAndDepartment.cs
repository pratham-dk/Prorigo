using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch.Day03052022
{
    public class Employee
    {
        public string Name { get; set; }
        public string City { get; set; }
       
    }

    public class Department
    {
        public int Dept_id { get; set; }
        public string Dept_name { get; set; }

        public List<Employee> Emp = new List<Employee>();
    }

    public class Disp1
    {
        static void Main(string[] args)
        {
            List<Department> dept = new List<Department>() 
            { 
                new Department{Dept_id = 1 , Dept_name = "Law" , Emp={
                       new Employee{Name = "Ajay " , City = "Mumbai"},
                       new Employee{Name = "Vijay " , City = "Nagpur"} } ,
                              },
             new Department{Dept_id = 2 , Dept_name = "IT" , Emp={
                       new Employee{Name = "Sunil" , City = "Delhi"},
                       new Employee{Name = "Akash " , City = "Benglor"} } ,
                           }
            
            
            };

            foreach(Department p1 in dept)
            {
                Console.WriteLine(p1.Dept_id + " " + p1.Dept_name);
                foreach(Employee p2 in p1.Emp)
                {
                    Console.WriteLine($"\t {p2.Name} {p2.City}" );
                }
                {

                }
            }
        }
   }

}