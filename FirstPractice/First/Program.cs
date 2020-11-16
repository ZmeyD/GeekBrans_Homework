using System;

class Program
{
    static void Main(string[] args)
    {
        //Козлов Никита Сергеевич
        //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        //а) используя склеивание;
        // б) используя форматированный вывод;
        //в) используя вывод со знаком $.

        Console.Write("Введите ваше имя: ");
        string Firstname = Console.ReadLine();

        Console.Write("Введите вашу фамилию: ");
        string Surname = Console.ReadLine();

        Console.Write("Введите ваш возраст: ");
        int Age = Convert.ToInt32 (Console.ReadLine());
         
        Console.Write("Введите ваш рост: ");
        int Height = int.Parse(Console.ReadLine());
         
        Console.Write("Введите ваш вес: ");
        int Weight = Convert.ToInt32(Console.ReadLine());

        // а
        Console.WriteLine(Firstname + " " + Surname + " " + Age.ToString() + " " + Height.ToString() + " " + Weight.ToString());


        // б
        Console.WriteLine(String.Format("Имя Фамилия - {0} {1}; Возраст: {2} Рост:{3} Вес: {4}", Firstname, Surname, Age, Height, Weight)); 
  
        // в
        Console.WriteLine($"Привет, {Firstname} {Surname}");
        Console.WriteLine($"Твой возраст = {Age} Рост = {Height} Вес = {Weight} "); 
        Console.ReadLine();
   
    }


  
}
