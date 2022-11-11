using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace kontr
{
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1-а");
            Console.WriteLine("Введите строку содержащую буквы о и д");
            string str = Console.ReadLine();
            Console.WriteLine(str.Replace("о", "а").Replace("д", "дж"));

            Console.WriteLine("Задание 1-б");
            int[,] arr = new int[8,8];
            string showArr = "";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if(j % 2 != 0)
                    {
                        arr[i, j] = 0;
                    }
                    else
                    {
                        arr[i, j] = 1;
                    }
                    showArr += arr[i, j];
                }
                showArr += "\n";
            }
            Console.WriteLine(showArr);


            Console.WriteLine("Задание 2");
            Shop arr1 = new Shop(Size: 8);
            Random rand = new Random();

            for (int i = 0; i < arr1.Lenght; i++)
            {
                arr1[i] = rand.Next(1, 100);
                Console.Write("{0}\t", arr1[i]);
            }
        }
    }
}
