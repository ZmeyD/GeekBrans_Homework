using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Написать метод подсчета количества цифр числа.
            Console.Write("Введите любой длинны число: ");
            long a = long.Parse(Console.ReadLine());

		
				Console.WriteLine("Сумма цифр = " + Count(a));
			}


			static int Count(long a) // нерекурсивный метод
			{
				int s = 0;
				while (a > 0)                 
				{
					a /= 10;          
					s++;             
				}
				return s;                    
			
		}



		}
    }

