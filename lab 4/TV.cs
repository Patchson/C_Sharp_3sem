using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public interface NCount
    {
        public static short number = 0;
        void Count();
        void DoClone();
    }
    public abstract class TV
    {
        public abstract void ToString();
        private string typeTV;
        public string TypeTV
        {
            get { return typeTV; }
            set { typeTV = value; }
        }
        public TV(string typeTV)
        {
            this.TypeTV = typeTV;
        }
    }

    public class Director : TV
    {
        private string nameDirector;
        public string NameDirector
        {
            get { return nameDirector; }
            set { nameDirector = value; }
        }
        public Director(string typeTV, string nameDirector) : base(typeTV)
        {
            this.NameDirector = nameDirector;
        }
        public override void ToString()
        {
            Console.WriteLine("Телеканал: " + TypeTV);
            Console.WriteLine("Режиссёр: " + NameDirector);
        }
    }

    public abstract class Movie : Director, NCount
    {
        public void Count() {
            Console.WriteLine("Количество объектов: " + number);
        }
        private string nameMovie;
        public string NameMovie
        {
            get { return nameMovie; }
            set { nameMovie = value; }
        }
        public int number { get; set; }
        public Movie(string typeTV, string nameDirector, string nameMovie) : base(typeTV, nameDirector)
        {
            this.NameMovie = nameMovie;
            number++;
        }
        public override void ToString()
        {
            Console.WriteLine("Телеканал: " + TypeTV);
            Console.WriteLine("Режиссёр: " + NameDirector);
            Console.WriteLine("Название фильма: " + NameMovie); 
        }
        public abstract void DoClone();
    }

    public sealed class FunMovie : Movie, NCount
    {
        public int time;
        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public int number { get; set; }
        public FunMovie(string typeTV, string nameDirector, string nameMovie, int time) : base(typeTV, nameDirector, nameMovie)
        {
            this.Time = time;
            number++;
        }
        public override void ToString()
        {
            Console.WriteLine("\nХудожественный фильм");
            Console.WriteLine("Телеканал: " + TypeTV);
            Console.WriteLine("Режиссёр: " + NameDirector);
            Console.WriteLine("Название фильма: " + NameMovie);
            Console.WriteLine("Продолжительность: " + Time + " минут");
        }

        //методы от объекта
        public override int GetHashCode()       // Метод GetHashCode() позволяет возвратить некоторое числовое значение, соответствующее объекту или, как ещё говорят, его хэш-код
        {
            return TypeTV.GetHashCode();
        }

        public override bool Equals(object obj)  // Позволяет проверить два объекта на равенство, используя собственный алгоритм сравнения
        {
            if (obj.GetType() != this.GetType()) return false;

            Director dir = (Director)obj;
            return (this.NameDirector == dir.NameDirector);
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

    public partial class News : Director
    {
        private int episode;
        public int Episode
        {
            get { return episode; }
            set { episode = value; }
        }
        
    }
    public class Mult : Director
    {
        private string nameMult;
        public string NameMult
        {
            get { return nameMult; }
            set { nameMult = value; }
        }
        public Mult(string typeTV, string nameDirector, string nameMult): base(typeTV, nameDirector)
        {
            this.NameMult = nameMult;
        }
        public override void ToString()
        {
            Console.WriteLine("\nМультфильм");
            Console.WriteLine("Телеканал: " + TypeTV);
            Console.WriteLine("Режиссёр: " + NameDirector);
            Console.WriteLine("Название мультфильма: " + NameMult);
        }
    }
    public class Ad : Director
    {
        private string product;
        public string Product
        {
            get { return product; }
            set { product = value; }
        }
        public Ad(string typeTV, string nameDirector, string product) : base(typeTV, nameDirector)
        {
            this.Product = product;
        }
        public override void ToString()
        {
            Console.WriteLine("\nРеклама");
            Console.WriteLine("Телеканал: " + TypeTV);
            Console.WriteLine("Режиссёр: " + NameDirector);
            Console.WriteLine("Продукт: " + Product);
        }
    }

    public class Printer
    {
        public virtual void IAmPrinting(TV tv)
        {
            Console.WriteLine(tv.GetType().Name); //Тип объекта
        }
    }
}
