using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            // б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.



            // пишу разные вариации операторов, чтобы было проще запомнить (конвертер, операция вывода переменных в консоль )
            Console.Write("Введите ваш рост (см): ");
            double h = double.Parse(Console.ReadLine());

            Console.Write("Введите ваш вес (кг): ");
            double m = Convert.ToDouble(Console.ReadLine());

            h = h / 100;

            double I = m /(h * h);
            Console.WriteLine($"Ваш индекс массы тела(ИМТ) =  {I}");

            double b = (h * 100) - 100; //Норма веса

            if (I < 20)
                Console.WriteLine("Ваш оптимальный вес = {0}, вам необходимо поправиться на {1} кг", b, m-b);
            else if (I > 25)
                Console.WriteLine("Ваш оптимальный вес = {0}, вам необходимо похудеть на {1} кг", b, b-m);
            else
                Console.WriteLine("Ваш оптимальный вес = {0}, все в порядке", b);

            Console.ReadKey();

           

        }
    }
}
