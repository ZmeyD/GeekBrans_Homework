using System;

namespace _task
{




    class Program
    {
        static int value;
        
        static int GetValue()
        {
            int a = 0;
            int result = 0;

            do
            {
                Console.Write("Введите числа, выходом будет число 0: ");
                result = int.Parse(Console.ReadLine());
                if (result > 0 && result % 2 == 1)
                    a += result;
            }
            while (result != 0);

            return a;
        }
     
        static void Main()
        {
            
            value = GetValue();
            Console.WriteLine("Сумма положительны и нечетных = ", value);
            
        }
    }



}
