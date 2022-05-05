using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prorigo_HomeWork.day03052022
{
    public delegate void bankDel();
    public class BankEvent
    {

        int bal = 5000;
        public int Bal
        {
            get { return bal; }
        }
       
        public event bankDel myEvent;
        public event bankDel myEvent1;
        public void WithDraw(int a)
        {
           
            if (bal == a)
                myEvent();

            if (bal < a)
            {
                myEvent1();
                return;
            }
            
            
            bal -= a;
            Console.WriteLine($"Balance After Withdraw is : {bal}");

        }
    }

    public class BankDisp
    {
        static void Error1()
        {
            Console.WriteLine("Your Balance is Zero After Withdrawl");
        }
        static void Error2()
        {
            Console.WriteLine("Balance is low , you can not withdraw");
        }
        static void Main(string[] args)
        {
            BankEvent be = new BankEvent();

            Console.WriteLine($"Your Balance is : {be.Bal}");
            Console.WriteLine("Enter Amount to be withdrawn");
            int wd  = Convert.ToInt32(Console.ReadLine());  
         
            be.myEvent += new bankDel(Error1);
            be.myEvent1 += new bankDel(Error2);
            
            be.WithDraw(wd);
            

        }
    }
}
