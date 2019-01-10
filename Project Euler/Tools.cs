using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    class Tools
    {
        public static Boolean isPrime(int n)
        {
            if (n == 2)
                return true;
            if (n == 3)
                return true;
            if (n % 2 == 0)
                return false;
            if (n % 3 == 0)
                return false;

            int i = 5;
            int w = 2;

            while (i * i <= n) {
                if (n % i == 0)
                    return false;
            
                i += w;
                w = 6 - w;
             }

            return true;
        }
        public static int factorial(int n)
        {
            if (n < 0)
                return 0;
            else if (n == 0)
                return 1;
            else
                return n * factorial(n - 1);
        }
    }
}
