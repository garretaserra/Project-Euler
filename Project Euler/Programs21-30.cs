using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Project_Euler
{
    class Programs21_30
    {

        public void program21()
        {
            //find amicable
            int sumAmicable = 0;
            for (int i = 220; i < 10000; i++)
            {
                //find sum of divisors
                int sumDivisors = 0;
                for (int j = 1; j < i / 2 + 1; j++)
                {
                    if (i % j == 0)
                    {
                        sumDivisors += j;
                    }
                }
                //find sum od fivisors2
                int sumDivisors2 = 0;
                for (int k = 1; k < sumDivisors / 2 + 1; k++)
                {
                    if (sumDivisors % k == 0)
                    {
                        sumDivisors2 += k;
                    }
                }
                if (sumDivisors2 == i && i != sumDivisors)
                {
                    sumAmicable += i;
                    Console.WriteLine("{0} and {1} are amicable", i, sumDivisors);
                }
            }
            Console.WriteLine("Sum of amicable is: " + sumAmicable);
            Console.ReadKey();
        }
        public void program22()
        {
            Console.WriteLine("Reading names...");
            StreamReader sr = new StreamReader("p022_names.txt");
            string[] namesStrArr = new string[6000];
            String namesStr = sr.ReadToEnd();
            namesStrArr = namesStr.Replace("\"", "").Split(',');

            Console.WriteLine("Sorting names...");
            List<string> namesList = new List<string>(namesStrArr);
            namesList.Sort();

            Console.WriteLine("Counting Scores...");
            int score = 0;
            for (int i = 0; i < namesList.Count; i++)
            {
                int sumLetters = 0;
                string name = namesList[i];
                for (int j = 0; j < name.Length; j++)
                {
                    sumLetters += name[j] - 64;
                }
                score += sumLetters * (i + 1);
            }
            Console.WriteLine("THe total score is: " + score);
            Console.ReadKey();
        }
        public void program23()
        {
            Console.WriteLine("Finding abundant numbers");
            List<int> abundant = new List<int>();
            for (int i = 2; i < 28123; i++)
            {
                int sumdiv = 0;
                for (int j = 1; j < i / 2 + 1; j++)
                {
                    if (i % j == 0)
                    {
                        sumdiv += j;
                    }
                }
                if (sumdiv > i)
                {
                    abundant.Add(i);
                }
            }

            int sumNoAbundant = 0;
            for (int i = 1; i < 28123; i++)
            {
                Boolean sum = false;
                for (int j = 0; j < abundant.Count && abundant[j] <= i && sum == false; j++)
                {
                    for (int k = 0; k < abundant.Count && abundant[k] <= i && sum == false; k++)
                    {
                        int suma = abundant[k] + abundant[j];
                        if (i < suma)
                        {
                            break;
                        }
                        if (i == suma)
                        {
                            sum = true;
                        }
                    }
                }
                if (!sum)
                {
                    sumNoAbundant += i;
                    Console.WriteLine(i + " isn't the sum of 2 abundant numbers");
                }
            }

            Console.WriteLine(sumNoAbundant);
            Console.ReadKey();
        }
        public void program24()
        {
            List<UInt64> nums = new List<UInt64>();
            int cont = 0;
            string numstr = "";
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    if (b == a)
                        continue;

                    for (int c = 0; c < 10; c++)
                    {
                        if (c == a || c == b)
                            continue;
                        for (int d = 0; d < 10; d++)
                        {
                            if (d == a || d == b || d == c)
                                continue;
                            for (int e = 0; e < 10; e++)
                            {
                                if (e == a || e == b || e == c || e == d)
                                    continue;
                                for (int f = 0; f < 10; f++)
                                {
                                    if (f == a || f == b || f == c || f == d || f == e)
                                        continue;
                                    for (int g = 0; g < 10; g++)
                                    {
                                        if (g == a || g == b || g == c || g == d || g == e || g == f)
                                            continue;
                                        for (int h = 0; h < 10; h++)
                                        {
                                            if (h == a || h == b || h == c || h == d || h == e || h == f || h == g)
                                                continue;
                                            for (int i = 0; i < 10; i++)
                                            {
                                                if (i == a || i == b || i == c || i == d || i == e || i == f || i == g || i == h)
                                                    continue;
                                                for (int j = 0; j < 10; j++)
                                                {
                                                    if (j == a || j == b || j == c || j == d || j == e || j == f || j == g || j == h || j == i)
                                                        continue;
                                                    numstr = a.ToString() + b.ToString() + c.ToString() + d.ToString() + e.ToString() + f.ToString() + g.ToString() + h.ToString() + i.ToString() + j.ToString();
                                                    //nums.Add(Convert.ToUInt64(numstr));
                                                    cont++;
                                                    Console.WriteLine(cont + "    " + numstr);
                                                    if (cont == 1000000)
                                                        goto end;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        end:
            Console.WriteLine("Result: " + numstr);
            Console.ReadKey();
        }
        public void program25()
        {
            BigInteger prevnum = 1;
            BigInteger currnum = 0;
            BigInteger nextnum = 0;
            int count = 1;
            while (true)
            {
                nextnum = currnum + prevnum;
                Console.WriteLine(count + " " + nextnum);
                if (nextnum.ToString().Length >= 1000)
                    break;
                prevnum = currnum;
                currnum = nextnum;

                count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
        public void program27()
        {
            int maxA = 0;
            int maxB = 0;
            int maxN = 0;
            for (int a = -999; a < 1000; a++)
            {
                for (int b = -1000; b <= 1000; b++)
                {
                    //Console.WriteLine("Checking a = " + a + " and b = " + b);
                    for (int n = 0; ; n++)
                    {
                        if (Tools.isPrime(Math.Abs(n * n + a * n + b)))
                        {
                            //Console.WriteLine(n + "^2+" + a + "*" + n + b + "="+(n * n + a * n + b).ToString()+" Is Prime");
                            //Console.ReadKey();
                        }
                        else
                        {
                            //Console.WriteLine(n + "^2+" + a + "*" + n + b + "=" + (n * n + a * n + b).ToString()+" Is not Prime");
                            //Console.ReadKey();
                            if (maxN < n)
                            {
                                maxN = n;
                                maxA = a;
                                maxB = b;
                                //Console.WriteLine("New maximum, n = " + n + " with a = " + a + " and b = " + b);
                            }
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("max a = " + maxA + " and max b = " + maxB + " with n max = " + maxN);
            Console.Write("a*b=" + maxA * maxB);
            Console.ReadKey();
        }
        public void program28()
        {
            int total = 1;
            int compte = 1;
            for (int i = 2; i <= 1000; i += 2)
            {
                for (int j = 0; j < 4; j++)
                {
                    compte += i;
                    total += compte;
                }
            }
            Console.WriteLine("Total: " + total);
            Console.ReadKey();
        }
        public void program29()
        {
            List<BigInteger> list = new List<BigInteger>();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    BigInteger temp = BigInteger.Pow(i, j);
                    if (!list.Contains(temp))
                    {
                        Console.WriteLine("Adding: " + temp + " a: " + i + " b: " + j);
                        list.Add(temp);
                    }
                }
            }
            Console.WriteLine("Total sequence: " + list.Count);
            Console.ReadKey();
        }
        public void program30()
        {
            int total = 0;
            for (int i = 2; i < 10000000; i++)
            {
                List<int> digits = new List<int>();
                int j = i;
                while (j > 0)
                {
                    digits.Add(j % 10);
                    j /= 10;
                }
                int sum = 0;
                for (int l = 0; l < digits.Count; l++)
                {
                    sum += (int)Math.Pow(digits[l], 5);
                }
                if (sum == i)
                {
                    total += i;
                    Console.WriteLine("Number found: " + i);
                }

            }
            Console.WriteLine("Total Number: " + total);
            Console.ReadKey();
        }

    }
}
