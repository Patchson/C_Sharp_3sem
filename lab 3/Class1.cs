using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public partial class Set
    {
        public List<int> mySet;
        public Set(List<int> localSet)
        {

            this.mySet = localSet;
        }

        // Проверка на принадлежность
        public static bool operator >(Set set1, Set set2)
        {
            /*int amount1 = set1.mySet.Count;
            int amount2 = set2.mySet.Count;

            if (amount1 <= amount2)
            {
                Console.WriteLine("1 множество меньше 2");
                return false;
            }
            else
            {
                Console.WriteLine("1 множество больше 2");
                return true;
            }*/
            int[] full = new int[10];
            int count = 0;
            foreach (int i in set1.mySet)
            {
                foreach (int j in set2.mySet)
                {
                    if (i == j)
                    {
                        full[count++] = j;
                        Console.Write(j);
                    }
                }
            }
            foreach (int i in full)
            {
                Console.Write(i);
            }
            return true;
        }

        // Пересечение множеств
        public static Set operator *(Set set1, Set set2)
        {
            var concSet = new Set(new List<int>());
            foreach (var s in set1.mySet)
            {
                if (set2.mySet.Contains(s))
                {
                    concSet.mySet.Add(s);
                }
            }
            return concSet;
        }

        // Проверка на подмножество
        public static bool operator <(Set set1, Set set2)
        { // 1-ый параметр - подмножесто, 2-ой - множество
            int c = set1.mySet.Count;
            int counter = 0;
            foreach (var s in set1.mySet)
            {
                if (set2.mySet.Contains(s))
                {
                    counter++;
                }
            }
            if (counter == c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Print()
        {
            this.mySet.ForEach(i => Console.Write(i + " "));
            Console.WriteLine();
        }

        public static void SetTest()
        {
            var set1 = new Set(new List<int>() { 0, 1, 2, 3, 5, 6, 7, -9 });
            var set2 = new Set(new List<int>() { 1, 2, 3, 5, 7 });

            set1.Print();
            set2.Print();


            Console.WriteLine("Проверка на принадлежность");
            Console.WriteLine(set1 > set2);

            Console.WriteLine("Пересечение множеств: ");
            set1.Print();
            set2.Print();
            Console.WriteLine("Результат");
            var test = set2 * set1;
            test.Print();

            Console.WriteLine("Включает ли первое множество в себе второе");
            set1.Print();
            set2.Print();
            Console.WriteLine(set2 < set1);

            Console.WriteLine("Удаление положительных элементов из множества");
            set1.RemovePlus().Print();
        }
    }

    public static class StatisticOperation
    {
        public static string intString(this string str)
        {
            foreach (char i in str)
            {
                if(Char.IsDigit(i)) //относится ли символ Юникода к категории десятичных цифр
                {
                    Console.WriteLine($"{i} - первое число в строке");
                    break;
                }
            }
            return str;
        }

        public static Set RemovePlus(this Set set1)
        {
            var unplusSet = new Set(new List<int>());
            foreach (var s in set1.mySet)
            {
                if (s<0)
                {
                    unplusSet.mySet.Add(s);
                }
            }
            return unplusSet;
        }


        public static int Sum(Set set1, Set set2)
        {
            return set1.mySet.Count + set2.mySet.Count;
        }

        public static int Diff(Set set1)
        {
            return set1.mySet.Max() - set1.mySet.Min();
        }

        public static int Length(Set set1)
        {
            return set1.mySet.Count;
        }
    }
}

