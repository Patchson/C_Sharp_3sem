using System;
using System.Diagnostics;
using System.Security.Cryptography;
using static lab_5.TvContainer;

// 1 - Телевизионная программа TV

namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArchiveController arch = new ArchiveController();
            Ad ad1 = new Ad("KFC", new Date(2002), 2);
            Ad ad2 = new Ad("iPhone", new Date(2007), 3);
            Movie movie1 = new Movie("Утомлённые солнцем",new Date(2012));
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
    }
}
