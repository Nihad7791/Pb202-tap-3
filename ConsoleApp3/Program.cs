using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {



        static void Main(string[] args)
        {
            //    Console.WriteLine(Test(5));
            // string name = " Hikmet Abbasov";
            //Console.WriteLine(Print(name));
            Console.WriteLine(Valuable(new int[] { 1, 2, 3, 4, 5, }));
            //Console.WriteLine(Print(21));
            // Console.WriteLine(Print(30, 40));
            //Console.WriteLine(Sum(25, 50));
            //Console.WriteLine(Simple(10));
            // Console.WriteLine(Array(new int[] { 1, 2, 3, 6, 10, 24 }));
        }
       

        #region opinion taks2
        public static int Print(int n, int m)
        {
            int count = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }

        #endregion

        #region task2
        public static int[] Valuable(int[] value)
        {
            int[] NewArray = { };
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = value[i] * value[i];
            }
            int[] tempArr = new int[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = tempArr [i];
            }

            return NewArray;
        }

        #endregion

            #region task1
            //public static int Test(int x)
            //{
            //    return x * x;
            //}

            #endregion
            #region task3
            // public static string Print(string s)
            //{
            //string newname = "";
            //for (int i = 0; i < s.Length; i++)
            //{
            //  if (s[i] != ' ')
            //  {
            //     newname += s[i];
            // }


            //}return newname;


            #endregion
            #region opinion task1
        public static string Print(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
                return "3 ve 7 bolunur";
            else
                return "3 ve 7 bolunmur";

        }
        #endregion
        #region opinion task3
        public static int Sum(int n, int m)
        {
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                }
            }
            return sum;
        }

        #endregion
        #region opinion task4
        public static string Simple(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                    if (count > 2)
                        Console.WriteLine("eded murekkebdir");
                }
                else
                    Console.WriteLine("eded sadedir");

            }
            return count.ToString();

        }

        #endregion
        #region opinion task5
        public static int Array(int[] num)
        {
            int sum = 0;
            foreach (var item in num)
            {
                if (item % 2 == 0)
                    sum += item;
            }
            return sum;

        }

        #endregion



    }
}















