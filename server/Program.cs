using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Здравствуйте! Добро пожаловать в программу.");
        string fio = "Shuvalova Alina";
        string group = "Group: ISP-231";
        DateTime now = DateTime.Now;
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1 — Показать ФИО");
            Console.WriteLine("2 — Показать группу");
            Console.WriteLine("3 — Показать дату");
            Console.WriteLine("4 — Выход");
            Console.Write("Выберите действие (1-4): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine($"ФИО: {fio}");
                    break;
                case "2":
                    Console.WriteLine($"Группа: {group}");
                    break;
                case "3":
                    Console.WriteLine($"Текущая дата и время: {now}");
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Выход из программы. До свидания!");
                    break;
                default:
                    Console.WriteLine("Некорректный ввод. Пожалуйста, выберите число от 1 до 4.");
                    break;
            }
        }
    }
}


