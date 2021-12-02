using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Ping
    {
        public delegate void PingHandler();
        public event PingHandler PingEvent;

        public string Name { get; init; }

        public void DoPing()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 1)
            {
                Thread.Sleep(500);
                Console.WriteLine("Ping сделал Pong");
                PingEvent?.Invoke();
            }
            else
            {
                Console.WriteLine("*******************");
                Console.WriteLine("Pong победил!");

                return;
            }
        }
    }
}
