using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    public abstract class Director
    {
        public abstract void ToString();
        private string nameDirector;
        public string NameDirector
        {
            get { return nameDirector; }
            set { nameDirector = value; }
        }
        public Director(string nameDirector)
        {
            this.NameDirector = nameDirector;
        }
    }
    public class News : Director
    {
        private int episode;
        public int Episode
        {
            get { return episode; }
            set { episode = value; }
        }
        public News(string nameDirector, int episode) : base(nameDirector)
        {
            this.Episode = episode;
        }
        public override void ToString()
        {
            Console.WriteLine("\nНовости");
            Console.WriteLine("Режиссёр: " + NameDirector);
            Console.WriteLine("Выпуск: #" + Episode);
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
        public Mult(string nameDirector, string nameMult) : base(nameDirector)
        {
            this.NameMult = nameMult;
        }
        public override void ToString()
        {
            Console.WriteLine("\nМультфильм");
            Console.WriteLine("Режиссёр: " + NameDirector);
            Console.WriteLine("Название мультфильма: " + NameMult);
        }
    }
    public class Printer
    {
        public virtual void IAmPrinting(Director director)
        {
            Console.WriteLine(director.GetType().Name); //Тип объекта
        }
    }
}
