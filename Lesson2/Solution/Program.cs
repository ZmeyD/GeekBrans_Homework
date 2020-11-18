using System;

namespace Solution
{
    class MainClass
    {

        //Козлов Никита Сергеевич
        //1.	Написать метод, возвращающий минимальное из трёх чисел. 
        static int Mini(int a, int b, int c)
        {
            int min;

            if (c < b && c < a)

                min = c;

            else if (b < a)

                min = b;

            else

                min = a;

            return min;

        }

        public static void Main(string[] args)
        {
            
            Console.Write("Введите переменную a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите переменную b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Введите переменную c: ");
            int c = int.Parse(Console.ReadLine());

            
            Console.WriteLine($"Минимальным было число: " + Mini(a, b, c));

        }

        
    }
}
