using System;
using System.Collections.Generic;

namespace SearchForString
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() 
            { "Василий",
              "Ренат",
              "Борис",
              "Евгений",
              "Роман"
            };

            StringSearcher stringSearcher = new StringSearcher();
            stringSearcher.OnSearch += OutputInConsole;
            stringSearcher.Search(names);
        }

        public static void OutputInConsole(string name, out bool retFlag)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{name} Поздравляем! Вы победитель лотереи!");
            Console.ResetColor();
            retFlag = true;
        }
    }
}
