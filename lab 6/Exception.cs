using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_Lab6
{
    public class MyException : System.Exception
    {
        public string ErrorClass { get; set; }
        public MyException(string message, string errorClass)
            : base(message)  // наследуем message от System.Exception
        {
            this.ErrorClass = errorClass;
        }
    }
    public class TimeException : MyException
    {
        public int Time { get; set; }
        public TimeException(string message, int errorTime)
            : base(message, "Error code 2: Uncorrect Time.\n")
        {
            this.Time = errorTime;
        }
    }
    public class DateException : MyException
    {
    
        public int Year { get; set; }
        public DateException(string message, int errorYear)
            : base(message, "Error code 1: Uncorrect date.\n")  // наследуем message и errorClass от MyException
        {
         
            this.Year = errorYear;
        }
    }
    public class SearchDateException : MyException
    {
        public int Year { get; set; }
        public SearchDateException(string message, int errorYear)
            : base(message, "Error code 3: Uncorrect year input for search.\n")
        {
            this.Year = errorYear;
        }
    }

    public class NameException : MyException
    {
        public string Name { get; set; }
        public NameException(string message, string errorName)
            : base(message, "Error code 4: Uncorrect name.\n")
        {
            this.Name = errorName;
        }
    }

    public class FileLogger
    {
        public FileLogger() { }
        public void WriteLog(MyException exception)
        {
            TimeException TimeEx = exception as TimeException;
            DateException DateEx = exception as DateException;
            SearchDateException SearchEx = exception as SearchDateException;
            NameException NameEx = exception as NameException;

            string filePath = @"D:\ucheba\3 sem\( C# ) Объектноориент. проектир. и\labs\lab 6\log.txt";
            using (StreamWriter streamWriter = new StreamWriter(filePath, true, System.Text.Encoding.Default)) { 
            streamWriter.WriteLine(DateTime.Now);
            if (DateEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", DateEx.ErrorClass, DateEx.Message, DateEx.Year); ;
            }
            if (TimeEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", TimeEx.ErrorClass, TimeEx.Message, TimeEx.Time);
            }
            if (SearchEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", SearchEx.ErrorClass, SearchEx.Message, SearchEx.Year);
            }
            if (NameEx != null)
            {
                streamWriter.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
            }
        }}
    }

    public class ConsoleLogger
    {
        public ConsoleLogger() { }
        public void WriteLog(MyException exception)
        {
            TimeException TimeEx = exception as TimeException;
            DateException DateEx = exception as DateException;
            SearchDateException SearchEx = exception as SearchDateException;
            NameException NameEx = exception as NameException;

            Console.WriteLine("\n" + DateTime.Now);
            if (DateEx != null)
            {
                Console.WriteLine("{0}{1} {2}", DateEx.ErrorClass, DateEx.Message, DateEx.Year); ;
            }
            if (TimeEx != null)
            {
                Console.WriteLine("{0}{1} {2}", TimeEx.ErrorClass, TimeEx.Message, TimeEx.Time);
            }
            if (SearchEx != null)
            {
                Console.WriteLine("{0}{1} {2}", SearchEx.ErrorClass, SearchEx.Message, SearchEx.Year);
            }
            if (NameEx != null)
            {
                Console.WriteLine("{0}{1} {2}", NameEx.ErrorClass, NameEx.Message, NameEx.Name);
            }
        }
    }
}