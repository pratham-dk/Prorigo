using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProrigoBatch.Multithreading
{
    internal class Multi_
    {
        public class MyThread1
        {
            public void Run()
            {
                lock (this) // this ref to the current thread
                {
                    Thread t = Thread.CurrentThread;
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(t.Name);
                        Console.WriteLine(i);
                        Thread.Sleep(500); // ms
                    }
                }

            }
            public void Run2()
            {
                Thread t = Thread.CurrentThread;
                for (int i = 10; i >= 1; i--)
                {
                    Console.WriteLine(t.Name);
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
            }
        }

        class SynchronizationDemo
        {
            static void Main(string[] args)
            {
                MyThread1 myThread = new MyThread1();
                MyThread1 myThread2 = new MyThread1();
                // Thread class is used to create thread
                // Start() is used to start the exe of method
                // method ref hold by ThreadStart delegate
                Thread first = new Thread(new ThreadStart(myThread.Run));
                Thread second = new Thread(new ThreadStart(myThread.Run));
                Thread third = new Thread(new ThreadStart(myThread.Run2));
                second.Priority = ThreadPriority.Lowest;
                first.Priority = ThreadPriority.AboveNormal;
                third.Priority = ThreadPriority.Highest;

                first.Name = "First Thread";
                second.Name = "Second Thread";
                third.Name = "Third Thread";

                first.Start();// exe the method
                              //first.Join(); // it will block other threads exec till complets its own exe
                second.Start();
                // third.Start();
            }
        }
    }
}
