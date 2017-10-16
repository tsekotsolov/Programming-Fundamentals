using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] primes = new bool[n + 1];    // [1, n]
            for (int i = 0; i <= n; i++)
                primes[i] = true;
            primes[0] = primes[1] = false;
            for (int i = 2; i < n; i++)
            {
                if (primes[i])
                    for (int p = 2 * i; p <= n; p += i)
                        primes[p] = false;
            }
            for (int i = 0; i <= n; i++)
            {
                if (primes[i])
                    Console.Write("{0} ", i);
            }
        }
    }
}
