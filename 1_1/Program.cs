using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    internal class Program
    {    
        static void Main(string[] args)
        {
            for(; ; )
            {
                Console.WriteLine("Введи 1-е число");
                try
                {
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи 2-е число");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введи операцию(+,-,/,*)");
                    char operation = char.Parse(Console.ReadLine());
                    switch (operation)
                    {
                        case '+':Console.WriteLine($"Результат{a}+{b}={a + b}");
                            break;
                        case '-':Console.WriteLine($"Результат{a}-{b}={a - b}");
                            break;
                        case '*':Console.WriteLine($"Результат{a}*{b}={a * b}");
                            break;
                        case '/':Console.WriteLine($"Результат{a}/{b}={a / b}");
                            break;
                        default: throw new Exception();
                    }
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Делить на ноль нельзя!!");
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода данных!");
                }

            }
        }
    }
}
