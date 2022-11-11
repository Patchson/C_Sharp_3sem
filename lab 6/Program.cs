using OOP_Lab6;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using static lab_6.TvContainer;
using System.Diagnostics;

// 1 - Телевизионная программа TV

namespace lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x, y, z;
            x = 2;
            y = 2;
            z = x + y;
            Debug.Assert(z != 4, "Error");
            Console.WriteLine("Error");*/
            FileLogger fileLogger = new FileLogger();
            ConsoleLogger consoleLogger = new ConsoleLogger();
            try
            {
                ArchiveController arch = new ArchiveController();
                Ad ad1 = new Ad("KFC", new Date(2002), 2);
                Ad ad2 = new Ad("iPhone", new Date(2007), 3);
                Movie movie1 = new Movie("Утомлённые солнцем", new Date(2012));
                Movie movie2 = new Movie("Зловещие мертвецы", new Date(2004));

                arch.Add(ad1);
                arch.Add(ad2);
                arch.Add(movie1);
                arch.Add(movie2);

                arch.Display();
                arch.CountAd();
                arch.MovieDate(new Date(2002));
                arch.TimeAd("KFC");
            }
            catch (MyException ex)
            {
                fileLogger.WriteLog(ex);
            }
            finally { }
        }
    }
}
