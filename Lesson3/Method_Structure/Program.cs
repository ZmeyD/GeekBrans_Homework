using System;

namespace Method_Structure
{

    struct Complex
    {
        public double a, b;


        public Complex(double re, double im)
        {
            a = re;
            b = im;
        }

        public override string ToString ()
            {
            return $"{a}+{b}i";
            }

        public Complex Multi(Complex a1, Complex a2)
        {
            return new Complex(re: (a1.a * a1.b) - (a2.a * a2.b),
                                im: (a2.a * a1.b) + (a1.a * a2.b));  //Формула верна, но почемуу-то вывод по калькулятору нне совпадает
            
            //im = x.im + im * x.re;
            //re = x.re - im * x.im;


        }
        public Complex Vich(Complex a1, Complex a2)
        {
            return new Complex(re: a1.a - a2.a, im: a1.b - a2.b);
        }

    }

    class MainClass
    {

        
        public static void Main(string[] args)
        {
            //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
            //б) Д  описать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
            //в) Добавить диалог с использованием switch демонстрирующий работу класса.

            Console.Write("Введите x1 : ");

            double c1 = double.Parse(Console.ReadLine());
            Console.Write("Введите x2 : ");
            double c2 = double.Parse(Console.ReadLine());

            Complex x1 = new Complex(c1, c2);

            Console.WriteLine(x1);


            Console.Write("Введите x3 : ");

            double с3 = double.Parse(Console.ReadLine());
            Console.Write("Введите x4 : ");

            double с4 = double.Parse(Console.ReadLine());

            Complex x2 = new Complex(re:с3, im: с4);

            Console.WriteLine(x2);

            Console.Write("Что будем делать: 1.Вычитание, 2.Произведение. Введите цифру: ");
            int ch = Int32.Parse(Console.ReadLine());
            var x3 = x1.Vich(x1,x2);
            var x4 = x2.Multi(x1,x2);

            switch (ch)
            {
                case 1: Console.WriteLine($"Вычитание = {x3}"); break;
                case 2: Console.WriteLine($"Произведение = {x4}"); break;
            }
           
        }
    }
}
