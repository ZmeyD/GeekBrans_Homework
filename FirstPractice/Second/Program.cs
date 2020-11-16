using System;

namespace Second
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Козлов Никита Сергеевич
            //Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
            Console.Write("Введите ваш вес (кг): ");
            m = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш рост (метр): ");
            h = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);
            Console.WriteLine($"Ваш индекс массы тела(ИМТ) =  {I}");

            Console.ReadLine();
        }
    }
}
