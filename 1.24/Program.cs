using System;

namespace _1._24
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x;

            Console.WriteLine("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Второе число: ");
            x = Convert.ToInt32(Console.ReadLine());

            a = Math.Sqrt((2 * +Math.Sin(3 * a)) / 3.56);
            x = 3.2 + Math.Sqrt(1 + x) / (5 * x);

            Console.WriteLine($"Результат а) = {a}  ");
            Console.WriteLine($"Результат х) = {x}  ");
        }
    }

}
