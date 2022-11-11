using System; //которая сообщает компилятору, где он должен искать классы (типы), не определенные в данном пространстве имен.

/*В объектно-ориентированном программировании ход 
выполнения программы определяется объектами. Объекты это экземпляры 
класса. Класс это абстрактный тип данных, определяемый пользователем ( 
программистом). */

namespace лаб_1
{
    class Types
    {
        static void Main(string[] args)
        {
            //Объявление и инициализация всех типов данных
            bool valueBool = false; //true или false (логические литералы). Представлен системным типом System.Boolean
            Console.WriteLine($"{valueBool.GetType()} = {valueBool}");

            byte valueByte = 123; //целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte
            Console.WriteLine($"{valueByte.GetType()} = {valueByte}");

            sbyte valueSbyte = 45; //целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte
            Console.WriteLine($"{valueSbyte.GetType()} = {valueSbyte}");

            short valueShort = 12345; //целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16 
            Console.WriteLine($"{valueShort.GetType()} = {valueShort}");

            ushort valueUshort = 55500; // целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16
            Console.WriteLine($"{valueUshort.GetType()} = {valueUshort}");

            int valueInt = 1241256; //целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32
            Console.WriteLine($"{valueInt.GetType()} = {valueInt}");

            uint valueUint = 3251252324; //целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32
            Console.WriteLine($"{valueUint.GetType()} = {valueUint}");

            long valueLong = 23462462346234342; //целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
                                                //Представлен системным типом System.Int64
            Console.WriteLine($"{valueLong.GetType()} = {valueLong}");

            ulong valueULong = 15235236234623462346; //целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
                                                     //Представлен системным типом System.UInt64
            Console.WriteLine($"{valueULong.GetType()} = {valueULong}");

            float valueFloat = 3.1456789234f; //число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.
                                              //Представлен системным типом System.Single
            Console.WriteLine($"{valueFloat.GetType()} = {valueFloat}");

            double valueDouble = 1.32523; //число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.
                                          //Представлен системным типом System.Double
            Console.WriteLine($"{valueDouble.GetType()} = {valueDouble}");

            decimal valueDecimal = 214121241; //десятичное дробное число. Если употребляется без десятичной запятой,
                                              //имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой
                                              //и занимает 16 байт. Представлен системным типом System.Decimal
            Console.WriteLine($"{valueDecimal.GetType()} = {valueDecimal}");

            char valueChar = 'A'; //одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char.
            Console.WriteLine($"{valueChar.GetType()} = {valueChar}");

            string valueString = "hi"; //хранит набор символов Unicode. Представлен системным типом System.String.
            Console.WriteLine($"{valueString.GetType()} = {valueString}");

            object valueObj = 213; //может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе
                                   //и 8 байт на 64-разрядной платформе. Представлен системным типом System.Object, который
                                   //является базовым для всех других типов и классов .NET.
            Console.WriteLine($"{valueObj.GetType()} = {valueObj}");

            var valueVar = 23; //принимает любое значение, но потом невозможно изменить
            Console.WriteLine(valueVar + " " + valueVar.GetType());
            valueVar = 100;
                //valueVar = 100.9;
            Console.WriteLine(valueVar + " " + valueVar.GetType());
                //valueVar = "Hi";

            dynamic valueDynamic = "Hi";
            Console.WriteLine(valueDynamic + " " + valueDynamic.GetType());
            valueDynamic = 93;
            Console.WriteLine(valueDynamic + " " + valueDynamic.GetType() + "\n");

            Console.WriteLine("\nВведите свою строку");
            string yourString = Console.ReadLine();
            Console.WriteLine($"Ваша строка - {yourString}");



            //Явные и неявные преоразования

            byte a = 4;
            int b = a + 70; //неявное

                //byte a = 4;
                //byte b = a + 70;  // ошибка

            byte c = 4;
            byte d = (byte)(c + 70); //явное

            ushort e = 4;
            byte f = (byte)e; // для сужающего преобразования

            int g = 4;
            int h = 6;
            byte i = (byte)(g + h);

            Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}," +
                              $"e = {e}, f = {f}, g = {g}, h = {h}, " +
                              $"i = {i}");

            Console.WriteLine(valueVar + " = " + valueVar.GetType());
            Console.WriteLine(valueVar + " = " + Convert.ToSingle(valueVar).GetType());

            int n = Convert.ToInt32("46");

            string dateString = "05/01/1996";
            Convert.ToDateTime(dateString);

            Console.WriteLine($"n = {n} и dateString = {dateString} и при конвертации " + Convert.ToDateTime(dateString));



            //Упаковка и распаковка значимых типов

            int price = 39;
            Object obj1 = price; // Упаковка
            int price2 = (int)obj1; // Распоковка



            //Неявно типизированная переменная

            var name = "Alex Erohin";
            var age = 26;
            var isProgrammer = true;

                // Определяем тип переменных
            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isProgrammerType = isProgrammer.GetType();

                // Выводим в консоль результаты
            Console.WriteLine($"Тип name: {nameType}");
            Console.WriteLine($"Тип age: {ageType}");
            Console.WriteLine($"Тип isProgrammer: {isProgrammerType}");
            Console.ReadLine();



            // Работа с nullable 

            int? a1 = 1;
            int? b2 = null;
            Console.WriteLine(a1 ?? 3); // 1
            Console.WriteLine(b2 ?? 3); // 3

            // var

            var hello = 2;
            Console.WriteLine(hello);
                //hello = "Привет"; - var определяет тип только при инициализации, потом изменить нельзя
        }
    }
}