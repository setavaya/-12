using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var m = InputNumber("m");
            var n = InputNumber("n");

            Console.WriteLine("Значение логического выражения: " + IsStatementTrue(m, n));
        }

        static int InputNumber(string numberName)
        {
            Console.WriteLine($"Введите число {numberName}");
            return int.Parse(Console.ReadLine());
        }

        static bool IsStatementTrue(int m, int n) =>
            m * n % 5 == 0 && (m + n) % 5 != 0;
    }
}