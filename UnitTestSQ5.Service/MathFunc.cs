using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSQ5.Service
{
    public class MathFunc
    {
        public static int Sum(int v1, int v2) => v1 + v2;

        public static double Fatorial(int v)
        {
            if (v <= 1)
            {
                return 1;
            }
            else
            {
                return v * Fatorial(v - 1);
            }
        }
    }
}
