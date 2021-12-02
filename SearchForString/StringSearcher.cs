using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForString
{
    class StringSearcher
    {
        public delegate void SearchHandler(string message, out bool retFlag);
        public event SearchHandler OnSearch;

        public void Search(List<string> names)
        {
            bool retFlag;
            Random random = new Random();

            for(int i = 0; i < names.Count; i++)
            {
                int randomNumber = random.Next(0, names.Count);
                OnSearch.Invoke(names[randomNumber], out retFlag);
                if (retFlag == true)
                {
                    return;
                }
            }
        }
    }
}
