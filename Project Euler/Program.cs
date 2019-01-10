using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.IO;
using System.Linq;

namespace Project_Euler
{
    class Program
    {
        public void Program31()
        {
            int count = 0;
            for (int a = 0; a <= 1; a++) //200
            {
                for (int b = 0; b <= 2; b++) //100
                {
                    for (int c = 0; c <= 4; c++) //50
                    {
                        for (int d = 0; d <= 10; d++) //20
                        {
                            int num = a * 200 + b * 100 + c * 50 + d * 20;
                            if (num > 200)
                                break;
                            for (int e = 0; e <= 20; e++) //10
                            {
                                num = a * 200 + b * 100 + c * 50 + d * 20 + e * 10;
                                if (num > 200)
                                    break;
                                for (int f = 0; f <= 40; f++) //5
                                {
                                    num = a * 200 + b * 100 + c * 50 + d * 20 + e * 10 + f * 5;
                                    if (num > 200)
                                        break;
                                    for (int g = 0; g <= 100; g++) //2
                                    {
                                        num = a * 200 + b * 100 + c * 50 + d * 20 + e * 10 + f * 5 + g * 2;
                                        if (num > 200)
                                            break;
                                        for (int h = 0; h <= 200; h++) //1
                                        {
                                            num = a * 200 + b * 100 + c * 50 + d * 20 + e * 10 + f * 5 + g * 2 + h;
                                            if (num == 200)
                                            {
                                                count++;
                                            }
                                            else if (num > 200)
                                                break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Count: " + count);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int count = 0;
            for(int i = 10; i<10000000; i++)
            {
                int sum = 0;
                int num = i;
                while (num > 0)
                {
                    sum += Tools.factorial(num % 10);
                    num /= 10;
                }
                if(sum == i)
                {
                    count += i;
                    Console.WriteLine("Number " + i);
                }
            }
            Console.WriteLine("Total number " + count);
            Console.ReadKey();
        }

    }
}
