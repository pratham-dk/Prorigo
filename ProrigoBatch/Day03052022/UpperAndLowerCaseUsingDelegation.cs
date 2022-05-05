using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch.Day03052022
{
    public delegate void stringDel(string s);
   public class CC
    {
        public void UpperCase(string s1)
        {
            Console.WriteLine(s1.ToUpper());    
        }
        public void LowerCase(string s1)
        {
            Console.WriteLine(s1.ToLower()); 
        }
    }

    public class Disp3
    {
        static void Main(string[] args)
        {
           CC c = new CC();
            stringDel s = new stringDel(c.UpperCase);
            s += new stringDel(c.LowerCase);

            Delegate[] list = s.GetInvocationList();

            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("Helllo");
            }

        }
    }
}
