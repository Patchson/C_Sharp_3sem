using System;
using System.Net;
using System.Xml.Linq;

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
    public partial class Car //Частичные классы (partial classes) – конструкция, которая позволяет определить один класс в нескольких файлах.
    {
        const string about = "Этот класс об автомобилях!";

        private static int count; //Ключевое слово static - объявление константы или типа неявно является членом static.
                                  //На член static невозможно ссылаться через экземпляр, а можно только через имя типа. 

        private readonly Guid id;
        private string mark;
        private string model;
        private string year;
        private string color;
        private ulong price;
        private ulong register;

        // Свойства

        public Guid Id { get => id; }
        public string Mark { get => mark; set { mark = value; } }
        public string Model { get => model; set { model = value; } }
        public string Year { get => year; set { year = value; } }
        public string Color { get => color; set { color = value; } }
        public ulong Price { get => price; set { price = value; } }
        public ulong Register { get => register; set { register = value; } }

        //Конструкторы
        // с параметрами
        public Car(Guid id, string mark, string model, string year, string color, ulong price, ulong register)
        {
            this.id = id;
            this.mark = mark;
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
            this.register = register;
            Car.count++;
        }

        // без параметров
        public Car()
        {
            mark = "BMW";
            model = "Expromt";
            year = "2001";
            color = "белый";
            price = 1111111;
            register = 88727319918;
        }

        // с параметрами по умолчанию
        public Car(Guid id, string year, string color, ulong price, ulong register, string mark = "BMW", string model = "Expromt")
        {
            this.id = id;
            this.mark = mark;
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
            this.register = register;
        }

        // статический

        //Статический конструктор используется для инициализации
        //любых статических данных или для выполнения определенного действия,
        //которое требуется выполнить только один раз. 
        //static Car()
        //{
        //    Console.WriteLine("Ваши данные:");
        //}


        // закрытый
        //Закрытые конструкторы используются, чтобы не допустить
        //создания экземпляров класса при отсутствии полей или методов экземпляра
        /*private Car(Guid id, string mark)
        {
            this.id = id;
            this.mark = mark;
        }*/
        // предотвращает создание объекта класса из-вне. Используется в синглтонах и фабриках.


        public override string ToString() // переопределение метода ToString
        {
            return $"ID: {this.id}\n" +
                    $"Марка: {this.mark}\n" +
                    $"Модель: {this.model}\n" +
                    $"Год выпуска: {this.year}\n" +
                    $"Цвет: {this.color}\n" +
                    $"Цена: {this.price} рублей\n" +
                    $"Регистрационный номер: {this.register}\n";
        }

        //метод вывода возраста машины
        public static int GetAge(int year)
        {
            return DateTime.Now.Year - year;
        }

        //метод вызова информации о классе
        public static string GetInfoAboutClass()
        {
            return about;
        }
    }


}
