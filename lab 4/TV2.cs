using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public partial class News : Director
    {
        
        public News(string typeTV, string nameDirector, int episode) : base(typeTV, nameDirector)
        {
            this.Episode = episode;
        }
        public override void ToString()
        {
            Console.WriteLine("\nНовости");
            Console.WriteLine("Телеканал: " + TypeTV);
            Console.WriteLine("Режиссёр: " + NameDirector);
            Console.WriteLine("Выпуск: " + Episode);
        }
    }
}
