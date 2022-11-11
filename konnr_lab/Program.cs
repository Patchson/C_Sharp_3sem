using System;
using System.Collections.Generic;

namespace konnr_lab
{
    class Program
    {
        //Наличие числа в строке
        static void strNumb(string str,int value)
        {
            if(str.Contains(value.ToString()))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        static void doubArr()
        {
            double[,] arr = new double[5,5];
            Random rand = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i,j] = rand.Next(-100,100);
                    Console.WriteLine(arr[i,j]);
                    Console.WriteLine("\t");
                }
                Console.WriteLine("\n");
            }
        }

        static void weekArr()
        {
            string[] arr = { "пн", "вт", "ср", "чт", "пт", "сб", "вс" };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void lightStr(string str,int amount, int pos)
        {
            if (str.Length < amount + pos)
            {
                Console.WriteLine("мало символов");
                return;
            }
            else
            {
                str = str.Substring(pos, amount);
                Console.WriteLine(str);
            }
        }

        static void testList()
        {
            List<string> people = new List<string>() { "Tom", "Bob", "Sam" };

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        public void Print()
        {
            foreach (var dates in date)
            {
                Console.WriteLine(dates);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("5-Задание1-a");
            string str1 = Console.ReadLine();
            strNumb(str1,123);

            Console.WriteLine("5-Задание1-б");
            doubArr();

            Console.WriteLine("6-Задание1-а");
            ushort valUshor;
            Console.WriteLine(System.UInt16.MaxValue);

            Console.WriteLine("6-Задание1-б");
            weekArr();

            Console.WriteLine("7-Задани1-а");
            string str2 = Console.ReadLine();
            lightStr(str2,3,5);

            Console.WriteLine("7-Задание1-б");
            testList();

            Console.WriteLine("5-Задание2");
            Date date1 = new Date(2002, 02, 12);
            Date date2 = new Date(2003, 03, 13);
            date1.Equals(date1,date2);
            var test = date1 % 1;
            test.Print();
            Console.WriteLine();
        }
    }


}