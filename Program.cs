using CounterWithEvents;
using System;

namespace HomeWork_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter { TargetValue = 55 };
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();
            counter.OnCount += handler1.ShowMessage;
            counter.OnCount += handler2.ShowMessage;

            counter.StartCounting();

        }
    }
}
