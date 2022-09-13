using System;

namespace hellorussia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор v2.0");
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите операцию над числами (+, -, *, /):");
            var enter = Console.ReadKey();
            char key = enter.KeyChar;
            if ((key == '+') || (key == '-') || (key == '*') || (key == '/'))
            {
                Console.WriteLine("");
                Console.WriteLine("Введите второе число:");
                int b = int.Parse(Console.ReadLine());


                if (key == '+')
                {
                    Console.WriteLine(a + b);
                }
                else if (key == '-')
                {
                    Console.WriteLine(a - b);
                }
                else if (key == '*')
                {
                    Console.WriteLine(a * b);
                }
                else if (key == '/')
                {
                    if (b != 0)
                    {
                        Console.WriteLine(a / b);
                    }
                    else {
                        Console.WriteLine("На ноль делить нельзя");
                    }

                }
            }
        
        
        
        
        }
    }
}
