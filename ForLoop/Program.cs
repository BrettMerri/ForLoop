using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Console.Write("Enter number of seconds: ");
            input = int.Parse(Console.ReadLine());
            Console.Clear();
            for (int i=input; i >= 1; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.WriteLine("Time is up!");
        }
    }
}
