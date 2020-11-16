using System;

namespace Fourth
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Козлов Никита Сергеевич
            //Написать программу обмена значениями двух переменных:


            //а) с использованием третьей переменной;
            Console.Write("x = ");

            int x = int.Parse(Console.ReadLine());

            Console.Write("y = ");

            int y = int.Parse(Console.ReadLine());


            int z = x;        // В t запоминаем значение a
            x = y;           // В a записываем b
            y = z;


            Console.Write($"Извините, но теперь переменная x = {x}, переменная y = {y} ");


            Console.WriteLine("Еще разок...");
            //б) *без использования третьей переменной.
            Console.Write("a = ");

            int a = int.Parse(Console.ReadLine());

            Console.Write("b = ");

            int b = int.Parse(Console.ReadLine());

            
            a = a + b;
            b = a - b;
            a = a - b;


            Console.Write($"Извините, но теперь переменная a = {a}, переменная b = {b} ");



            Console.ReadLine();

        }
    }
}
