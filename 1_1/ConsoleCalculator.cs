using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    internal class ConsoleCalculator
    {
        private double a;
        private double b;
        private char operation;
        public double A { get => a; }
        public void Set_a()
        {
            Console.WriteLine("Введи 1-е число");
            try
            {
                double a = double.Parse(Console.ReadLine());
                this.a = a;
            }
            catch
            {
                throw new ArgumentException("Ошибка ввода первого числа!");
            }
        }
        public double B { get => b;} 
        public void Set_b()
        {
            Console.WriteLine("Введи 2-е число");
            try
            {
                double b = double.Parse(Console.ReadLine());
                this.b = b;
            }
            catch
            {
                throw new ArgumentException("Ошибка ввода второго числа!");
            }
        }
        public void SetOperation()
        {
            Console.WriteLine("Введи операцию(+,-,/,*)");
            try
            {
                char operation = char.Parse(Console.ReadLine());
                this.operation = operation;
                if (!new char[] { '+','-','*','/'}.Contains(operation))
                    throw new ArgumentException("Неверно введена операция!");
            }
            catch
            {
                throw new ArgumentException("Неверно введена операция!");
            }       
        }
        public void Calculate()
        {
            switch (operation)
            {
                case '+':
                    Console.WriteLine($"Результат {a}+{b}={a + b}");
                    break;
                case '-':
                    Console.WriteLine($"Результат {a}-{b}={a - b}");
                    break;
                case '*':
                    Console.WriteLine($"Результат {a}*{b}={a * b}");
                    break;
                case '/':
                    {
                        if (b == 0)
                            throw new DivideByZeroException("На ноль делить нальзя!");
                        Console.WriteLine($"Результат {a}/{b}={a / b}");
                        break;
                    }
                    
            }
        }
    }
}
