using System;

namespace Application
{
    class MainClass
    {
        //Козлов Н.С.
        //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        static bool IsGood(int x)
        {
            int i = x;
            int sum = 0;

            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            return i % sum == 0; ////возвращает в любом случае trur

        }

        public static void Main(string[] args)
        {
            DateTime start = DateTime.Now;


            int k = 0;
            Console.WriteLine(IsGood(11));

            for (int i = 10; i < 20; i++)

                if (IsGood(i))
                {
                    k++;
                    Console.WriteLine("{0} {1}", k, i);
                }

            Console.WriteLine(k);



            Console.WriteLine("Время выполнения программы: ");
            Console.WriteLine(DateTime.Now - start);
            Console.ReadKey();
        }
    }
}
