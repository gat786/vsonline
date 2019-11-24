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
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Printing from the thread {i}");
                }
            });

            var t2 = new Task(() =>{
                for(int i = 0; i < 10; i++){
                    Console.WriteLine("Printing from the other thread {i}");
                }
            });
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Printing from the Main thread {i}");

            }
            //starting the thread
            t1.Start();
            t2.Start();
            t2.Wait();
            t1.Wait();
            Console.WriteLine("Exiting the program");



        }

        public static int addition(int num1, int num2)
        {
            return num1 + num2;
        }

        


    }
}
