using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab_3
{
    internal class Class2
    {
        public class Prodaction
        {
            public Guid ID;
            public string Organization;

            public Prodaction()
            {
                ID = Guid.NewGuid();
                Organization = "ASTU";
            }
        }

        public Prodaction myProdaction = new Prodaction();

        public class Developer
        {
            public string Name;
            public Guid ID;
            public string Department;

            public Developer()
            {
                Name = "Kirill";
                ID = Guid.NewGuid();
                Department = "2";
            }
        }

        public Developer myDeveloper = new Developer();

        public static class Date
        {
            public static DateTime date = new DateTime(2021, 10, 24);
        }
    }
}
