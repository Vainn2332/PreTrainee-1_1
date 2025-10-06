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
            while(true)
            {               
                ConsoleCalculator consoleCalculator = new ConsoleCalculator();
                try
                {
                    consoleCalculator.SetA();
                    consoleCalculator.SetOperation();
                    consoleCalculator.SetB();
                    consoleCalculator.Calculate();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
