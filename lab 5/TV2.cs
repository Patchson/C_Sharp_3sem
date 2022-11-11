using lab_5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_5
{
    public partial class Movie : TV, NCount
    {
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
}
