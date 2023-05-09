using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZayavkaZaKoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой числа: ");
            int n = int.Parse(Console.ReadLine());
            Koren calculator = new Koren();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Въведи число {i+1}: ");
                int number = int.Parse(Console.ReadLine());
                double squareRoot = calculator.Calculate(number);
                Console.WriteLine($"Корена на числото [{number}] е [{squareRoot}]");
            }
        }
    }
}
