﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
      public static int Add(int a, int b)
        {
            return a + b;
        }
        public static double Add(double a, double b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool isTrue)
        {
            var sum = a + b;

            if (isTrue == true && sum > 1)
            {
                return $"{sum} dollars";
            }
            else if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isTrue == true && sum < 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return string.Empty;
            }
               
           
        }

    }
}
