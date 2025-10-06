using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    internal class ConsoleCalculator
    {
        private double _a;
        private double _b;
        private char _operation;
        public double A { get => _a; }
        public void SetA()
        {
            Console.WriteLine("Введи 1-е число");
            if(!double.TryParse(Console.ReadLine(), out _a))
                throw new ArgumentException("Ошибка ввода первого числа!");            
        }
        public double B { get => _b;} 
        public void SetB()
        {
            Console.WriteLine("Введи 2-е число");
            if (!double.TryParse(Console.ReadLine(), out _b))
                throw new ArgumentException("Ошибка ввода второго числа!");
            
        }
        public void SetOperation()
        {
            Console.WriteLine("Введи операцию(+,-,/,*)");
            if (!char.TryParse(Console.ReadLine(), out _operation))
                throw new ArgumentException("Неверно введена операция!");
            if (!new char[] { '+','-','*','/'}.Contains(_operation))
                    throw new ArgumentException("Неверно введена операция!");             
        }
        public void Calculate()
        {
            switch (_operation)
            {
                case '+':
                    Console.WriteLine($"Результат {_a}+{_b}={_a + _b}");
                    break;
                case '-':
                    Console.WriteLine($"Результат {_a}-{_b}={_a - _b}");
                    break;
                case '*':
                    Console.WriteLine($"Результат {_a}*{_b}={_a * _b}");
                    break;
                case '/':
                    {
                        if (_b == 0)
                            throw new DivideByZeroException("На ноль делить нальзя!");
                        Console.WriteLine($"Результат {_a}/{_b}={_a / _b}");
                        break;
                    }
                    
            }
        }
    }
}
