using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class3
    {
        public Class3()
        {

        }
        public void GetPrimeNums(int n)
        {
            Console.WriteLine($"Prime numbers between 1 and {n} are: ");
            
            for (int i = 1; i <= n; i++)//maybe from i = 2
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if ( i%j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                    Console.Write($"{i} ");
            }
        }
    }
    
}
