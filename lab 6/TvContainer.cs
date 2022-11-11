using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    //Перечисление
    enum Operation
    {
        Add = 1,
        Delete,
        Display,
        SearchDate,
        ShowTime,
        CountAd

    }
    public struct Date
    {
        public int Year;
        public Date(int year)
        {
            this.Year = year;
        }
    }
    public class TvContainer
    {
        public List<TV> Archive;
        public TvContainer()
        {
            Archive = new List<TV>();
        }
        public void Delete(int index)
        {
            Archive.RemoveAt(index);
        }
        public void Add(TV item)
        {
            Archive.Add(item);
        }
        public void Display()
        {
            Console.WriteLine("Единиц контента:");
            foreach (TV item in Archive)
            {
                item.ToString();
                Console.WriteLine("----------------");
            }
        }

        public class ArchiveController : TvContainer
        {
            private int adCount = 0;

            //Число рекламных роликов
            public void CountAd()
            {
                for (int i = 0; i < Archive.Count; i++)
                {
                    if (Archive[i] is Ad)
                    {
                        adCount++;
                    }
                }
                /*if(adCount != 0) throw new */
                Console.WriteLine("\nКол-во рекламных роликов: " + adCount);
            }
            public void MovieDate(Date date)
            {
                
                Console.WriteLine("\nПоиск фильма по дате выпуска\nПоиск даты...   " + date.Year);
                for (int i = 0; i < Archive.Count; i++)
                {
                    if (Archive[i] is Movie)
                    {
                        if (Archive[i].Date.Year == date.Year)
                        {
                            Console.WriteLine("Найден объект с датой " + date.Year + ": " + Archive[i].Name);
                        }
                    }
                }
            }
            public void TimeAd(string name)
            {
                for (int i = 0; i < Archive.Count; i++)
                {
                    if (Archive[i] is Ad)
                    {
                        Ad temp = Archive[i] as Ad;
                        if (Archive[i].Name == name)
                        {
                            Console.WriteLine("\nПоиск даты...   " + name + "\nПродолжительность рекламы: " + temp.Time);
                        }
                    }
                }
            }
        }
    }
}
