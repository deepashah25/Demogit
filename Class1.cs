using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThinkQ
{
    class DemoThread
    {
        static void m1()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i+Thread.CurrentThread.Name);
               
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Good Afternoon ...Welcomeee");
            Thread t1 = new Thread(m1);
            Thread t2 = new Thread(m1);
            t1.Name = "OM";
            t2.Name = "Ram";
            t1.Start();
            t2.Start();
            for(int i=11;i<=20;i++)
            {
                Console.WriteLine("main"+i);
            }
            Console.WriteLine("main ends");

        }
    }
}
