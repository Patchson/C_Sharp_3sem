using System;

namespace Tuple
{
    class Tuple
    {
        static void Main(string[] args)
        {
            var tuple1 = (18, "Кузнецов", 'м', "Кузнецов", 2004);

            Console.Write(tuple1.Item1 + " " + tuple1.Item2 + " " + tuple1.Item4);

            (var ar, var br) = ("2001", 2002);
            Console.WriteLine($"\n{ar} {br}" + "\n");

            var First = (ar, br);
            var Second = (ar, br);

            Console.WriteLine(First == Second);

        }
    }
}
