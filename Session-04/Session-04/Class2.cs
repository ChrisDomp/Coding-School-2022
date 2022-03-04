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
            int sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;
            return sum;
        }
        public Int64 CalcProd(int n)
        {
            Int64 prod = 1;
            for (int i = 1; i <= n; i++)
                prod *= i;
            return prod;
            
        }
    }
}
