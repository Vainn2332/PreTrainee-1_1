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
                consoleCalculator.Set_a();
                consoleCalculator.SetOperation();
                consoleCalculator.Set_b();
                consoleCalculator.Calculate();
            }
        }
    }
}
