using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Создать класс Car: id, Марка, Модель, Год выпуска, Цвет,
    Цена, Регистрационный номер. Свойства и конструкторы
    должны обеспечивать проверку корректности. Добавить
    метод вывода возраста машины.
    Создать массив объектов. Вывести:
    a) список автомобилей заданной марки;
    b) список автомобилей заданной модели, которые
    эксплуатируются больше n лет;
*/

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Car.GetInfoAboutClass());

            Car car1 = new Car(Guid.NewGuid(), "BMW", "Pro", "1999", "Зелёный", 100, 36232532529);

            Car car2 = new Car();

            Car[] cars = new Car[7];
            cars[0] = new Car(Guid.NewGuid(), "BMW", "Exited", "1998", "Белый", 1340000, 26439);
            cars[1] = new Car(Guid.NewGuid(), "Lada", "Priora", "1991", "Чёрный", 100000, 14256);
            cars[2] = new Car(Guid.NewGuid(), "Lada", "Kalina", "1993", "Белый", 500000, 1223145);
            cars[3] = new Car(Guid.NewGuid(), "Mercedes", "Hott", "2003", "Белый", 50000, 6432);
            cars[4] = new Car(Guid.NewGuid(), "Mercedes", "Iron", "1995", "Чёрный", 870000, 162423);
            cars[5] = car1;
            cars[6] = car2;

            Console.WriteLine("Выберите марку автомобиля:\n");
            string mark = Console.ReadLine().ToLower();

            Console.WriteLine("\t\t\tСписок автомобилей заданной марки:\n");
            foreach (Car car in cars)
            {
                if (car.Mark.ToLower() == mark)
                    Console.WriteLine(car.ToString());
                else
                    continue;
            }

            Console.WriteLine("Введите модель:\n");
            string model = Console.ReadLine();
            Console.WriteLine("Введите колличество лет эксплуатации:\n");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tсписок автомобилей заданной модели, которые эксплуатируются больше " + year + " лет:\n");
            foreach (Car car in cars)
            {
                if (car.Model.ToLower() == model && ( Car.GetAge(int.Parse(car.Year)) ) >= year)
                    Console.WriteLine(car.ToString());
                else
                    continue;
            }

            // Анонимный тип
            //Анонимные типы позволяют создать объект с некоторым набором свойств без определения класса.
            var anonimuscustomer = new { mark = "BMW", model = "Pro", price = 1033 };
            Console.WriteLine(anonimuscustomer.ToString());
        }
    }
}
