using System;
using System.Collections.Generic;
using System.Text;

namespace Module10Practice
{
    class Calculate : ICalculate
    {
        ILogger Logger { get; }
        public Calculate(ILogger logger)
        {
            Logger = logger;
        }
        public int Sum(int a, int b)
        {
            Logger.Event("Метод Sum начал свою работу");           
            int c = a + b;
            Logger.Event("Метод Sum завершил свою работу");
            return c;
        }
    }

    public interface ICalculate
    {
        public int Sum(int a, int b);
    }
}
