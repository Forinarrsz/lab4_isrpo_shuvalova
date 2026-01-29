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
        }
    }
}