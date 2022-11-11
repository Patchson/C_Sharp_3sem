using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public interface NCount
    {
        public static short number = 0;
        void Count();
        void DoClone();
    }
    public abstract class TV : NCount
    {
        public Date Date;
        public abstract void ToString();
        public void Count()
        {
            Console.WriteLine("Количество объектов: " + number);
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int number { get; set; }
        public TV(string name)
        {
            this.Name = name;
            number++;
        }
        public abstract void DoClone();
    }

    public class Movie : TV, NCount
    {
        private int year;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int number { get; set; }
        public Movie(string Name, Date date) : base(Name)
        {
            Date = date;
            number++;
        }
        public override void ToString()
        {
            Console.WriteLine("Название фильма: " + Name);
            Console.WriteLine("Год выпуска: " + Date.Year);
        }
        void NCount.DoClone()
        {
            Console.WriteLine("Одноименный метод интерфейса");
        }
        public override void DoClone()
        {
            Console.WriteLine("Одноименный метод абстрактного класса");
        }
    }
    
    public class Ad : TV, NCount
    {
        private int year;
        private int time;
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public Ad(string Name, Date date, int time) : base(Name)
        {
            Date=date;
            Time = time;
            number++;
        }
        public override void ToString()
        {
            Console.WriteLine("\nРеклама");
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Год выпуска: " + Date.Year);
            Console.WriteLine("Продолжительность: " + Time);
        }
        void NCount.DoClone()
        {
            Console.WriteLine("Одноименный метод интерфейса");
        }
        public override void DoClone()
        {
            Console.WriteLine("Одноименный метод абстрактного класса");
        }
    }
}
