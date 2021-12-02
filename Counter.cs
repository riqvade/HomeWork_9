using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterWithEvents
{
    public class Counter
    {
        public int TargetValue { get; init; }

        public delegate void MessageHandler(int count);
        public event MessageHandler OnCount;
        public void StartCounting()
        {
            //Random random = new Random();
            int resiltValue = 0;
            for (int i = 0; i < 100; i++)
            {
                if (i == TargetValue)
                {
                    resiltValue = i;
                }
            }
            OnCount.Invoke(resiltValue);
        }
    }
}
