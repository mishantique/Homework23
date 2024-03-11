using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"В методе Main цикл находится на {i} элементе");
                Thread.Sleep(1000);
            }
            Console.WriteLine("Main завершил работу");
            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                Thread.Sleep(600);
            }
            Console.WriteLine($"Метод Factorial завершил работу: {fact}");
            
        }

        static async void FactorialAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
