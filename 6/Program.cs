using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CountPi(4));  
            Console.WriteLine(CountPi(15)); 
            Console.WriteLine(CountPi(3));  
            Console.WriteLine(CountPi(16)); 
        }
        static double CountPi(int n)
        {
            if (n < 4 || n > 15)
            {
                return -1;
            }

            double pi = 0.0;
            for (int i = 0; i < n; i++)
            {
                pi += Math.Pow(-1, i) / (2 * i + 1);
            }
            pi *= 4;

            return pi;
        }
    }
}
