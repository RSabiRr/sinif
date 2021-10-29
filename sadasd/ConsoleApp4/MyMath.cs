using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class MyMath
    {
        public decimal say(decimal a, decimal pow)
        {
            decimal r = 1;
            for (int i = 0; i < pow; i++)
            {
                r *= a;
            }
            return r;
        }
    }
}
