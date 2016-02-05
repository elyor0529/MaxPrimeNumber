using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPrimeNumber
{
    /// <summary>
    /// Prime number calculation tool
    /// </summary>
    public class CalculateTool
    {
        private readonly TimeSpan _time;
        private readonly IList<long> _primes = new List<long>();

        /// <summary>
        /// do extract prime numbers
        /// </summary>
        private void ExtractPrimes(long n)
        {
            //start ticket
            var startTime = Environment.TickCount;

            for (var k = 2; k <= n; k++)
            {

                //end ticket
                var endTime = Environment.TickCount;

                //stop counter
                if (endTime - startTime > _time.Milliseconds)
                    break;

                var isPrime = true;

                foreach (var prime in _primes)
                {
                    if (prime * prime > k)
                    {
                        break;
                    }
                    else if (k % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    _primes.Add(k);

            } 
        }

        /// <summary>
        /// Calculated time
        /// </summary>
        /// <param name="time"></param>
        public CalculateTool(TimeSpan time)
        {
            _time = time;
        }

        /// <summary>
        /// Find max prime number
        /// </summary>
        /// <param name="n">Counter to this number</param>
        /// <returns></returns>
        public long FindMaxPrime(long n)
        {
            //check
            if (n < 2)
                throw new Exception("N>=2");

            //extract
            ExtractPrimes(n);

            //max number
            var max = _primes.Max();

            return max;
        }

    }
}
