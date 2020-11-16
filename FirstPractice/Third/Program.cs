using System;

namespace Third
{
    class MainClass
    {
        

            //Козлов Никита Сергеевич
            // а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
            //по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            // б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
            static double abc(int x1, int y1, int x2, int y2)
            {
                double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                return r;
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Введите координаты x1,y1: ");
                int x1 = Convert.ToInt32(Console.ReadLine());
                int y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координаты x2,y2: ");
                int x2 = Convert.ToInt32(Console.ReadLine());
                int y2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Расстояние между точками с координатами =" + abc(x1, y1, x2, y2));
            }

       
    }
}
