using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PingPong
{
    class Pong
    {
        public delegate void PongHandler();
        public event PongHandler PongEvent;

        public string Name { get; init; }

        public void DoPong()
        {
            Random rnd = new Random();
            int magicNumber = rnd.Next(0, 10);
            if (magicNumber > 1)
            {
                Thread.Sleep(500);
                Console.WriteLine("Pong сделал Ping");
                PongEvent?.Invoke();
            }
            else
            {
                Console.WriteLine("Ping победил");

                return;
            }
        }
    }
}