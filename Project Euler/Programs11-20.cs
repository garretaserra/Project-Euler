using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Project_Euler
{
    class Class1
    {
        public void program11()
        {
            //Set numbers in array
            string s = "08 02 22 97 38 15 00 40 00 75 04 05 07 78 52 12 50 77 91 08 49 49 99 40 17 81 18 57 60 87 17 40 98 43 69 48 04 56 62 00 81 49 31 73 55 79 14 29 93 71 40 67 53 88 30 03 49 13 36 65 52 70 95 23 04 60 11 42 69 24 68 56 01 32 56 71 37 02 36 91 22 31 16 71 51 67 63 89 41 92 36 54 22 40 40 28 66 33 13 80 24 47 32 60 99 03 45 02 44 75 33 53 78 36 84 20 35 17 12 50 32 98 81 28 64 23 67 10 26 38 40 67 59 54 70 66 18 38 64 70 67 26 20 68 02 62 12 20 95 63 94 39 63 08 40 91 66 49 94 21 24 55 58 05 66 73 99 26 97 17 78 78 96 83 14 88 34 89 63 72 21 36 23 09 75 00 76 44 20 45 35 14 00 61 33 97 34 31 33 95 78 17 53 28 22 75 31 67 15 94 03 80 04 62 16 14 09 53 56 92 16 39 05 42 96 35 31 47 55 58 88 24 00 17 54 24 36 29 85 57 86 56 00 48 35 71 89 07 05 44 44 37 44 60 21 58 51 54 17 58 19 80 81 68 05 94 47 69 28 73 92 13 86 52 17 77 04 89 55 40 04 52 08 83 97 35 99 16 07 97 57 32 16 26 26 79 33 27 98 66 88 36 68 87 57 62 20 72 03 46 33 67 46 55 12 32 63 93 53 69 04 42 16 73 38 25 39 11 24 94 72 18 08 46 29 32 40 62 76 36 20 69 36 41 72 30 23 88 34 62 99 69 82 67 59 85 74 04 36 16 20 73 35 29 78 31 90 01 74 31 49 71 48 86 81 16 23 57 05 54 01 70 54 71 83 51 54 69 16 92 33 48 61 43 52 01 89 19 67 48";
            string[] input = new string[400];
            input = s.Split(Convert.ToChar(32));
            int[,] nums = new int[20, 20];
            int x = 0;
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    nums[j, i] = Convert.ToInt32(input[x]);
                    x++;
                }
            }
            int result = 0;
            //look for greatest numbers
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    int num = nums[i, j] * nums[i + 1, j] * nums[i + 2, j] * nums[i + 3, j];
                    Console.WriteLine(num);
                    if (num > result)
                        result = num;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    int num = nums[i, j] * nums[i, j + 1] * nums[i, j + 2] * nums[i, j + 3];
                    Console.WriteLine(num);
                    if (num > result)
                        result = num;
                }
            }
            for (int i = 3; i < 16; i++)
            {
                for (int j = 3; j < 16; j++)
                {
                    int num = nums[i, j] * nums[i + 1, j + 1] * nums[i + 2, j + 2] * nums[i + 3, j + 3];
                    Console.WriteLine(num);
                    if (num > result)
                        result = num;
                }
            }
            for (int i = 3; i < 16; i++)
            {
                for (int j = 3; j < 20; j++)
                {
                    int num = nums[i, j] * nums[i + 1, j - 1] * nums[i + 2, j - 2] * nums[i + 3, j - 3];
                    Console.WriteLine(num);
                    if (num > result)
                        result = num;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program12()
        {

            //generating triangle numbers
            UInt64[] tri = new UInt64[100000];
            tri[0] = 1;
            tri[1] = 3;
            for (UInt64 i = 3; i < Convert.ToUInt64(tri.Length); i++)
            {
                tri[i - 1] = (i * (i + 1)) / 2;
                Console.WriteLine(tri[i - 1]);
            }
            //finding divisors of square root
            UInt64 result = 0;
            int[] divisors = new int[tri.Length];
            for (int i = 0; i < divisors.Length; i++)
            {
                UInt64 temp = tri[i];
                for (UInt64 j = 1; j <= Convert.ToUInt64(Math.Sqrt(temp)); j++)
                {
                    if (temp % j == 0)
                    {
                        divisors[i]++;
                    }
                }
                divisors[i] += divisors[i];
                //correction for perfect square numbers
                if (Convert.ToInt32(Math.Sqrt(temp)) == Math.Sqrt(temp))
                {
                    divisors[i]--;
                }
                Console.WriteLine("num: " + tri[i] + " Div:" + divisors[i]);
                if (divisors[i] > 500)
                {
                    result = tri[i];
                    break;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program13()
        {
            UInt64 result = 0;
            string temp;
            UInt64[] nums = new UInt64[100];
            for (int i = 0; i < nums.Length; i++)
            {
                temp = Console.ReadLine();
                nums[i] = Convert.ToUInt64(temp.Substring(0, 15));
            }
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            string sum = result.ToString();
            sum = sum.Substring(0, 10);
            Console.WriteLine(sum);
            System.Threading.Thread.Sleep(10000);
        }
        public void program14()
        {

            int[] steps = new int[1000000];
            for (int i = 1; i < steps.Length; i++)
            {
                UInt64 temp = Convert.ToUInt64(i);
                for (int j = 0; j < 1000; j++)
                {
                    if (temp == 1)
                        break;
                    steps[i]++;
                    if (temp % 2 == 0)
                    {
                        temp = temp / 2;
                    }
                    else
                    {
                        temp = temp * 3 + 1;
                    }
                }
                if (steps[i] > 1000)
                    break;
                steps[i]++;
                Console.WriteLine("num: " + i + " steps: " + steps[i]);
            }
            int result = 0;
            int index = 0;
            for (int i = 0; i < steps.Length; i++)
            {
                if (steps[i] > result)
                {
                    result = steps[i];
                    index = i;
                }
            }
            Console.WriteLine(index);
            Console.ReadKey();
        }
        public void program15()
        {
            /* Binary word problem
             * If you assign 0 as going down and 1 as going right,
             * any path will be acombination of 20 zeros and 20 ones
             * to calculate all the posible combinations you need to
             * assign 20 zeros to 40 spaces and calc all possible combinations.
             * This is 40C20 using nCr, the result is 137846528820
             * 40!/(20! * (40-20)!)
             * 40!/(20! * 20!)
             * 137846528820
             */
            Console.WriteLine("137846528820");
            Console.ReadKey();
        }
        public void program16()
        {

            int[] nums = new int[350];
            nums[nums.Length - 1] = 2;
            int temp;
            for (int j = 0; j < 999; j++)
            {
                for (int i = 1; i < nums.Length; i++)
                {
                    temp = nums[i] * 2;
                    nums[i] = (temp % 10);
                    nums[i - 1] += (temp - (temp % 10)) / 10;
                }
                for (int k = 0; k < nums.Length; k++)
                {
                    if (nums[k] != 0)
                    {
                        while (k < nums.Length)
                        {
                            Console.Write(nums[k]);
                            k++;
                        }
                        break;
                    }

                }
                Console.WriteLine();
            }
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program17()
        {
            int[] let = new int[1001];
            let[0] = 0;
            let[1] = 3; //one
            let[2] = 3; //two
            let[3] = 5; //three
            let[4] = 4; //four
            let[5] = 4; //five
            let[6] = 3; //six
            let[7] = 5; //seven
            let[8] = 5; //eight
            let[9] = 4; //nine
            let[10] = 3; //ten
            let[11] = 6; //eleven
            let[12] = 6; //twelve
            let[13] = 7; //thirteen
            let[14] = 8; //fourteen
            let[15] = 7; //fifteen
            let[16] = 7; //sixteen
            let[17] = 10; //seventeen
            let[18] = 8; //eighteen
            let[19] = 8; //nineteen
            let[20] = 6; //twenty
            for (int i = 1; i < 30; i++)
            {
                let[i + 20] = let[20] + let[i];
            }
            let[30] = 6; //thirty
            for (int i = 1; i < 40; i++)
            {
                let[i + 30] = let[30] + let[i];
            }
            let[40] = 5; //forty
            for (int i = 1; i < 50; i++)
            {
                let[i + 40] = let[40] + let[i];
            }
            let[50] = 5; //fifty
            for (int i = 1; i < 60; i++)
            {
                let[i + 50] = let[50] + let[i];
            }
            let[60] = 5; //sixty
            for (int i = 1; i < 70; i++)
            {
                let[i + 60] = let[60] + let[i];
            }
            let[70] = 7; //seventy
            for (int i = 1; i < 80; i++)
            {
                let[i + 70] = let[70] + let[i];
            }
            let[80] = 6; //eighty
            for (int i = 1; i < 90; i++)
            {
                let[i + 80] = let[80] + let[i];
            }
            let[90] = 6; //ninety
            for (int i = 1; i < 100; i++)
            {
                let[i + 90] = let[90] + let[i];
            }
            let[100] = 10; //one hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 100] = let[100] + 3 + let[i];
            }
            let[200] = 10; //two hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 200] = let[200] + 3 + let[i];
            }
            let[300] = 12; //three hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 300] = let[300] + 3 + let[i];
            }
            let[400] = 11; //four hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 400] = let[400] + 3 + let[i];
            }
            let[500] = 11; //five hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 500] = let[500] + 3 + let[i];
            }
            let[600] = 10; //six hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 600] = let[600] + 3 + let[i];
            }
            let[700] = 12; //seven hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 700] = let[700] + 3 + let[i];
            }
            let[800] = 12; //eight hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 800] = let[800] + 3 + let[i];
            }
            let[900] = 11; //nine hundred
            for (int i = 1; i < 100; i++)
            {
                let[i + 900] = let[900] + 3 + let[i];
            }
            let[1000] = 11; //one thousand
            int result = 0;
            for (int i = 0; i < let.Length; i++)
            {
                result += let[i];
                Console.WriteLine(let[i]);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program18()
        {

            int[,] nums = new int[15, 15];
            string[] input = new string[15];
            string temp = "";
            for (int i = 0; i < 15; i++)
            {
                temp = Console.ReadLine();
                input = temp.Split(Convert.ToChar(" "));
                for (int j = 0; j < input.Length; j++)
                {
                    nums[i, j] = Convert.ToInt32(input[j]);
                }
            }
            for (int i = nums.GetLength(0) - 1; i > 0; i--)
            {
                for (int j = 0; j < nums.GetLength(1) - 1; j++)
                {
                    if (nums[i, j] > nums[i, j + 1])
                    {
                        nums[i - 1, j] += nums[i, j];
                    }
                    else
                    {
                        nums[i - 1, j] += nums[i, j + 1];
                    }
                }
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Console.Write(nums[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(nums[0, 0]);
            Console.ReadKey();
        }
        public void program19()
        {
            int[,] year = new int[102, 12];
            year[0, 0] = 0;
            int days = 0;
            for (int i = 0; i < 102; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    year[i, j] = days;
                    //31 days
                    if (j == 0 || j == 2 || j == 4 || j == 6 || j == 7 || j == 9 || j == 11)
                    {
                        days += 31;
                    }
                    //30 days
                    else if (j == 3 || j == 5 || j == 8 || j == 10)
                    {
                        days += 30;
                    }
                    else if (j == 1)
                    {
                        int temp = i + 1900;
                        bool leap = false;
                        if (temp % 4 == 0)
                            leap = true;
                        if (temp % 100 == 0)
                            leap = false;
                        if (temp % 400 == 0)
                            leap = true;
                        if (leap)
                        {
                            days += 29;
                        }
                        else
                        {
                            days += 28;
                        }
                    }
                }
            }
            int result = 0;
            for (int i = 1; i < 101; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    if (year[i, j] % 7 == 6)
                        result++;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public void program20()
        {
            BigInteger num = new BigInteger(1);
            for (int i = 1; i < 101; i++)
            {
                num = num * i;
            }
            BigInteger result = 0;
            while (num != 0)
            {
                result += num % 10;
                num /= 10;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
