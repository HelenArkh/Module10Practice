using System;

namespace Module10Practice
{
    class Program
    {
        static ILogger logger { get; set; }
        static void Main(string[] args)
        {
            //реалезуем интерфейс ILogger при помощи класса Logger
            logger = new Logger();

            var sum = new Calculate(logger);

            try
            {
                Console.WriteLine("Введите первое число:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                int b = Convert.ToInt32(Console.ReadLine());

                int c = sum.Sum(a, b);
                Console.WriteLine(c);

            }
            catch (Exception ex)
            {
                if (ex is FormatException) Console.WriteLine("Введенное значение не является целым числом!");
                else Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Конец работы программы");
            }            
        }
    }
    public interface ILogger
    {

        void Event(string message);
        void Error(string message);

        void Write() { Console.WriteLine("Hello!"); }
    }

    //класс Logger, который будет реализовывать интерфейс ILogger
    public class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ошибка: {message}");
        }

        void ILogger.Event(string message)
        {
            ///добавим изменение цвета консоли
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Событие: {message}");
        }
    }
}
