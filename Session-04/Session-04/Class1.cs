using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_04
{
    internal class Class1
    {
        public Class1()
        {

        }
        public string ReverseStringFor(string s)
        {
            string reversedString = string.Empty;
            //if (s != null)  
            for (int i = 0; i < s.Length; i++)
            {
                 reversedString += s[s.Length - i - 1]; 
            }
            return reversedString;
        }

    }
}
