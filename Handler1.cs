using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterWithEvents
{
    class Handler1 : IHandler
    {
        public void ShowMessage(int value)
        {
            Console.WriteLine("Уже 55 пора действовать!");
        }
    }
}
