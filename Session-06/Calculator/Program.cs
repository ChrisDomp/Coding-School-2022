﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calc
    {
        static void Main(string[] args)
        {
            
        }

        public Calc()
        {
          
        }
        public double Compute(float num1,float num2,int operation)
        {
            switch (operation)
            {
                case 0: 
                    return num1 + num2;
                case 1:
                        return num1 - num2;
                case 2: 
                    return num1 * num2;
                case 3:
                    return num1 / num2;
                case 4:
                    return Math.Pow(num1,num2);
                case 5:
                    return Math.Sqrt(num1);
                default:
                    return 0; 
                    
            }

        }
    }
}
