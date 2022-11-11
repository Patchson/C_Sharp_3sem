using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konnr_lab
{
    internal class Date
    {
        private int year;
        

        //Свойства
        public int Year { get { return year; } }
        public int Month { get; set; }
        public int Day { get; set; }

        public Date(int year, int month, int day)
        {
            this.year = year;
            Month = month;
            Day = day;
        }

        public static Date operator %(Date date,int i)
        {

            return new Date(date.Year, date.Month, date.Day);
            /*if (i == 1)
            {
            }
            else if (i == 2)
            {
                return new Date(date.Year, date.Month, date.Day);
            }
            else
            {
                return;
            }*/
        }

        public string Equals(Date date1, Date date2)
        {
            Console.WriteLine("Большее число");
            if (date1.Year == date2.Year)
            {
                if(date1.Month == date2.Month)
                {
                    if (date1.Day == date2.Day)
                    {
                        return $"даты равны";
                    }
                    else if (date1.Day > date2.Day)
                    {
                        return $"{date1} - больше чем {date2}";
                    }
                    else
                    {
                        return $"{date2} - больше чем {date1}";
                    }
                }
                else if (date1.Month > date2.Month)
                {
                    return $"{date1} - больше чем {date2}";
                }
                else
                {
                    return $"{date2} - больше чем {date1}";
                }
            }
            else if (date1.Year > date2.Year)
            {
                return $"{date1} - больше чем {date2}";
            }
            else
            {
                return $"{date2} - больше чем {date1}";
            }

        }
    }
}
