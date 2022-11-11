using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontr
{
    class Shop
    {
        string[] strArr;
        int[] intArr;
        public int Lenght;

        public Shop(int Size)
        {
            strArr = new string[Size];
            intArr = new int[Size];
            Lenght = Size;
        }

        public int this[int index]
        {
            set
            {
                intArr[index] = value;
            }
            get
            {
                return intArr[index];
            }
        }

        /*public string this[string str]
        {
            set
            {
                strArr[] = value;
            }

            get
            {
                return strArr[index];
            }
        }*/
    }
}
