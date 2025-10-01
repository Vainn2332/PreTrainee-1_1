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
        public double Get_a() => a;
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
                throw new Exception("Ошибка ввода первого числа!");
            }
        }
        public double Get_b() => b;
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
                throw new Exception("Ошибка ввода второго числа!");
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
                    throw new Exception("Неверно введена операция!");
            }
            catch
            {
                throw new Exception("Неверно введена операция!");
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
                            throw new Exception("На ноль делить нальзя!");
                        Console.WriteLine($"Результат {a}/{b}={a / b}");
                        break;
                    }
                    
            }
        }
    }
}
