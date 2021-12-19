using System;
using System.Collections.Generic;

namespace Delegate
{
    class Program
    {
        /*public delegate bool Check(int num);*/
        //public delegate void ChangeWords(string str);
        //public delegate int Print(string str);
        static void Main(string[] args)
        {
            /*Console.WriteLine(Sum(ChechkOdd,1,2,3,4,5,5,6,7));*/

            //List<int> nums = new List<int>();

            //ChangeWords words = StringUpper;
            //words += delegate (string s)
            // {
            //     Console.WriteLine(s.ToLower());
            // };

            //words += s => Console.WriteLine(s.ToUpper());
            //words("sAlam");

            //List<int> nums = new List<int> { 4, 5, 6, 7, 8, 9,5, 10 };
            //var list = nums.FindAll(x => x > 5);
            //var list1 = nums.FindLastIndex(x=>x>5);
            //Console.WriteLine(list1);
            //foreach (var member in list)
            //{
            //    Console.WriteLine(member);
            //}

            //List<int> nums2 = new List<int> { 4, 6, 8, 5, 4, 42, 2 };

            //var v = nums2.FindAll(x=>x>5);

            //foreach (var num in v)
            //{
            //    Console.WriteLine(num);
            //}

            //Console.WriteLine(nums2.FindAll(x => x > 5));

            Action<string> words = StringLower;
            words("Bextiyar");

            //Print print = StrLength;
            //Console.WriteLine(print("Said"));
            Func<string, int> print = StrLength;
            Console.WriteLine(StrLength("Baxtiyar"));

        }

        public static int StrLength(string s)
        {
            return s.Length;
        }


        public static bool Test(int n)
        {
            return n > 5;
        }
        //Equal to 
        public static bool Test1(int n) => n > 5;

        public static void StringUpper(string up)
        {
            Console.WriteLine(up.ToUpper());
        }

        public static void StringLower(string low)
        {
            Console.WriteLine(low.ToLower());
        }

        public static bool ChechkOdd(int num)
        {
            return num % 2 != 0;
        }

        public static bool ChechkEven(int num)
        {
            return num % 2 == 0;

        }
        public static bool CheckNum(int num)
        {
            return num > 5;
        }
        public static int Sum(Predicate<int> num1,params int[] nums)
        {
            var sum = 0;
            foreach (var num in nums)
            {
                if (num1(num))
                {
                    sum += num;
                }
            }
            return sum;

        }

        public static int Sum1(List<int> list, params int[] nums)
        {
            var sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }

    }
}
