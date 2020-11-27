using System;

namespace _task
{
    //Козлов Н.С. - единственный варинт с методом, который быстро пришел в голову.

    //С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
    class Program
    {
        static int value;

        //Проверка, что вводят не 0
        static bool Check(int x)
        {
            bool a;

            a = false;

            if (x == 0)
                a = true;

            return a;
        }

        public static void Main()
        {
            
            

            int x = 0;
            int res = 0;


            Console.Write("Введите числа, выходом будет число 0: ");

            do
            {
                
                x = int.Parse(Console.ReadLine());

                if (x > 0 && x % 2 == 1)

                    res += x;
            }
            while (Check(x) != true);

            Console.WriteLine("Сумма положительны и нечетных = " + res);

        }
    }



}
