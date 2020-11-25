using System;

namespace Application
{
    class MainClass
    {


        public static void Main()
        {
            int sum = 0;
            int num = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Sum: " + sum);

        }
    }
}
