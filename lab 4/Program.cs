using System;
using System.Security.Cryptography;

// 1 - Телевизионная программа TV

namespace lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            FunMovie movie1 = new FunMovie("ТНТ", "Кирилл Кузнецов", "Побег из Минска", 180);
            FunMovie movie2 = new FunMovie("СТС", "Ридли Скотт", "Свой", 209);
            News news = new News("СТС", "Кирилл Кузнецов", 312);
            Mult mult = new Mult("ТНТ", "Кевин Файги", "Стражи мстителей");
            Ad ad = new Ad("СТС", "Тимур Бекмамбетов", "Комунарка");
            movie1.ToString();
            movie2.ToString();
            news.ToString();
            mult.ToString();
            ad.ToString();

            //IS
            object Is = movie1;
            if (Is is FunMovie)
            {
                Console.WriteLine("\nОбъект принадлежит классу FunMovie");
            }
            else
            {
                Console.WriteLine("\nОбъект не принадлежит классу FunMovie");
            }

            //AS
            Director dir = new Director("СТС", "Куликов");
            News As = dir as News;
            if (As == null) Console.WriteLine("\nПреобразование прошло не успешно.");
            else As.ToString();

            //EQUALS
            if (movie1.Equals(movie2))
                Console.WriteLine("\nФильмы идентичны\n");
            else Console.WriteLine("\nФильмы не идентичны\n");

            //PRINTER
            TV[] tv1 = { movie1, movie2, news, mult, ad }; // массив, содержащий ссылки на разнотипные объекты классов
            Printer printer = new Printer(); // создание объекта класса Printer
            foreach (var item in tv1)
            {
                Console.WriteLine("Тип объекты: ");
                printer.IAmPrinting(item);
            }
            Console.ReadKey();
        }
    }
}
