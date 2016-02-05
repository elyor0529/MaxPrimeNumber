using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPrimeNumber.Cmd
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = (long)int.MaxValue;
            var time = new TimeSpan(0, 0, 30);
            var tool = new CalculateTool(time);
            var maxPrimeNumber = tool.FindMaxPrime(n);

            Console.WriteLine("[0..{1}] range in find max prime number {0} by {2} sek elapsed!", maxPrimeNumber, n, time.Seconds);

            Console.ReadKey();
        }
    }
}
