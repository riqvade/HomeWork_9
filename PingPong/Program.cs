using System;

namespace PingPong
{
    class Program
    {
        static void Main(string[] args)
        {
            Ping ping = new Ping { Name = "Ping" };
            Pong pong = new Pong { Name = "Pong" };

            ping.PingEvent += pong.DoPong;
            pong.PongEvent += ping.DoPing;

            PlayGame(ping, pong);
        }

        public static void PlayGame(Ping ping, Pong pong)
        {
            Random random = new Random();
            int number = random.Next(0, 1);
            if(number == 0)
            {
                ping.DoPing();
            }
            else
            {
                pong.DoPong();
            }
        }
    }
}