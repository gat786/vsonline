using System;
using System.Threading;
using System.Threading.Tasks;

namespace workspace
{
    class Program
    {
        // this is the Main method
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello World");
            Console.WriteLine(addition(5, 5));
            
            var t1 = new Task(() =>
            {
                for (int i = 0; i < 50; i++)
                {
                    Console.WriteLine($"Printing from the thread {i}");
                }
            });
            
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine($"Printinf from the Main thread");

            }
            //starting the thread
            t1.Start();



        }

        public static int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        


    }
}
