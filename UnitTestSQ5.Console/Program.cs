using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestSQ5.Service;

namespace UnitTestSQ5.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = MathFunc.Sum(10, 20);
            System.Console.WriteLine("Sum value={0}",sum);
            System.Console.ReadLine();
        }
    }
}
