using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    class Programs1_10
    {
        public void program1()
        {
            int z = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 5 == 0 | i % 3 == 0)
                {
                    z = z + i;
                }
            }
            Console.WriteLine(z);
        }
        public void program2()
        {
            ulong[] fib = new ulong[50];
            fib[0] = 1;
            fib[1] = 2;
            for (int i = 2; i < fib.Length; i++)
            {
                fib[i] = fib[i - 1] + fib[i - 2];
            }
            ulong z = 0;
            for (int i = 0; i < fib.Length; i++)
            {
                if (fib[i] < 4000000 && fib[i] % 2 == 0)
                {
                    Console.WriteLine(fib[i]);
                    z = z + fib[i];
                }
            }
            Console.WriteLine(z);
        }
        public void program3()
        {
            ulong z = 600851475143;
            for (ulong i = 2; i < 1000000; i++)
            {
                if (z == i)
                    break;
                while (z % i == 0)
                {
                    Console.WriteLine(z);   //Write the prime factors
                    z = z / i;
                }
            }
            Console.WriteLine(z);
            Console.ReadKey();
        }
        public void program4()
        {
            int z, y = 0;
            int c = 0; //index of palindromes found
            bool found = false;
            int[] nums = new int[100000]; //vector with palindromes
            for (int i = 999; i > 1; i--)
            {
                for (int j = i; j > 1; j--)
                {
                    Console.WriteLine(i + "   " + j);
                    z = i * j;
                    y = i * j;
                    string num = z.ToString();
                    for (int x = 0; x < (num.Length / 2); x++)
                    {
                        if (num.Substring(x, 1) != num.Substring(num.Length - x - 1, 1))
                        {
                            found = false;
                            break;
                        }
                        else
                            found = true;
                    }
                    if (found == true)
                    {
                        nums[c] = y;
                        c++;
                    }
                }
            }
            int result = 0;
            //find highest
            for (int i = 0; i < nums.Length; i++)
            {
                if (result < nums[i])
                {
                    result = nums[i];
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program5()
        { /*20=5*2*2-
              19=19-
              18=3*3*2-
              17=17-
              16=2*2*2*2
              15=5*3
              14=7*2-
              13=13-
              12=3*2*2
              11=11-
              10=5*2
              9=3*3*3
              8=2*2*2
              7=7
              6=3*2
              5=5
              4=2*2
              3=3
              2=2
              1=1
              */
            ulong result = 20 * 19 * 18 * 17 * 14 * 13 * 11;
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program6()
        {
            ulong x = 0;
            ulong y = 0;
            for (ulong i = 1; i <= 100; i++)
            {
                x = x + i * i;
            }
            for (ulong i = 1; i <= 100; i++)
            {
                y = y + i;
            }
            y = y * y;
            ulong result = y - x;
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program7()
        {
            ulong[] primes = new ulong[10001];
            primes[0] = 2;
            primes[1] = 3;
            primes[2] = 5;
            int n = 2;
            bool found = false;
            for (ulong i = 6; n < 10000; i++)
            {
                for (int j = n; j >= 0; j--)
                {
                    if (i % primes[j] == 0)
                    {
                        found = false;
                        break;
                    }
                    else
                    {
                        found = true;
                    }
                }
                if (found)
                {
                    Console.WriteLine(i);
                    primes[n + 1] = i;
                    n++;
                }
            }
            Console.WriteLine(primes[10000]);
            Console.ReadKey();
        }
        public void program8()
        {
            string z = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            UInt64[] nums = new UInt64[1000];
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 1;
            }
            for (int i = 0; i < z.Length - 12; i++)
            {
                for (int j = i; j < 13 + i; j++)
                {
                    nums[i] = nums[i] * Convert.ToUInt64(z.Substring(j, 1));
                }
                Console.WriteLine(nums[i]);
            }
            UInt64 r = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > r)
                    r = nums[i];
            }
            Console.WriteLine(r);
            Console.ReadKey();
        }
        public void program9()
        {
            int result = 0;
            for (int a = 1; a < 1000 && result == 0; a++)
            {
                for (int b = 1; b < 1000 && result == 0; b++)
                {
                    for (int c = 1; c < 1000 && result == 0; c++)
                    {
                        if (a + b + c != 1000)
                            continue;
                        Console.WriteLine("a=" + a + " b=" + b + " c=" + c);
                        if (a * a + b * b == c * c)
                            result = a * b * c;
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program10()
        {
            UInt64[] primes = new UInt64[10000000];
            primes[0] = 2;
            primes[1] = 3;
            primes[2] = 5;
            int x = 2;
            bool found = false;
            for (UInt64 i = 6; i < 2000000; i++)
            {
                for (int j = 0; j < x + 1; j++)
                {
                    if (i % primes[j] == 0)
                    {
                        found = false;
                        break;
                    }
                    else
                        found = true;
                }
                if (found)
                {
                    Console.WriteLine(i);
                    primes[x + 1] = i;
                    x++;
                }
            }
            UInt64 result = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                result += primes[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
