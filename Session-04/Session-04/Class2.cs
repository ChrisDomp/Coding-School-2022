using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class2
    {
        public Class2()
        {

        }
        public int CalcSum(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("N must be positive");
                return 0;
            }

            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;
            return sum;
        }
        public Int64 CalcProd(int n)
        {
            if (n <= 0)
            {
                Console.WriteLine("N must be positive");
                return 0;
            }
            Int64 prod = 1;
            for (int i = 1; i <= n; i++)
                prod *= i;
            if (prod ==0)//prod > INT64.Max.Value
            {
                prod = Int64.MaxValue;
                Console.WriteLine("Prod > MAX");
            }
               
            return prod;
            
        }
    }
}
