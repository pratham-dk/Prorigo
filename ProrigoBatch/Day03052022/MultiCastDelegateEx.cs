using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch.Day03052022
{
    public delegate int myDel(int a,int b);
    public  class Calculation
    {
       
        public int Add(int a , int b)
        {
            return a + b;
        }
        public int sub(int a,int b)
        {
            return a - b;
        }
        public int mul(int a,int b)
        {
            return a * b;
        }
    }

    public class Disp2
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            myDel md = new myDel(calc.Add);

            md += new myDel(calc.sub);
            md +=new myDel(calc.mul);

            Delegate[] list = md.GetInvocationList();

            foreach(Delegate d in list)
                {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(45,32));
               }

        }

    }


}
