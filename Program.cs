using System;
using System.Threading;

namespace ThinkQ
{
    class Program

    { 
        static void m1()
        {
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(  "Good Afternoon ...Welcomeee");
            m1();
            Console.WriteLine("main ends");
        }
    }
}
