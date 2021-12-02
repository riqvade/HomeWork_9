using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterWithEvents
{
    class Handler2 : IHandler
    {
        public void ShowMessage(int value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Наконец-то 55 вперёд!");
            Console.ResetColor();
        }
    }
}
