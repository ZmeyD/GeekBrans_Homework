using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Козлов Н.с.
            //4.Реализовать метод проверки логина и пароля.На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел(Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while  ограничить ввод пароля тремя попытками. 

            int at = 0;

            while (at < 3)
            {
                if (at != 0)
                {
                    Console.Clear();
                    Console.Write("Логин или пароль введены неверно\n");
                    Console.WriteLine($"Использована {at} из 3");
                    if (at == 2)
                    {
                        Console.Write("ВНИМАНИЕ. Последний шанс\n");
                    }
                }
                Console.Write("Введите логин: ");
                string log = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string pas = Console.ReadLine();
                if (log == "root" && pas == "GeekBrains")
                {
                    Console.Write("Успешная авторизация");
                    break;
                }
                else
                {
                    at++;
                }


            }
        }
    }
}
