namespace homeWork
{
    class Programm
    {
        static void Main()
        {
            //Лабораторная раблта 4.1
            Console.WriteLine("Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9 февраля (високосный год не учитывать)");
            Console.WriteLine("ввведите номер дня, вы узнаете, день месяца");
            int day;
            if (!int.TryParse(Console.ReadLine(), out day))
            {
                Console.WriteLine("данные введены неверно");
            }
            else
            {
                Console.WriteLine(new DateTime(2005, 1, 1).AddDays(day % 365 - 1).ToString("M", new System.Globalization.CultureInfo("ru-RU")));
            }
            // Лабораторная работк 4.2
            Console.WriteLine("Упражнение 4.2 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца. Например, число 40 соответствует 9 февраля (високосный год не учитывать)");
            Console.WriteLine("ввведите номер дня(от 1 до 365), вы узнаете, день месяца");
            if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 365)
            {
                Console.WriteLine("данные введены неверно");
            }
            else
            {
                Console.WriteLine(new DateTime(2005, 1, 1).AddDays(day - 1).ToString("M", new System.Globalization.CultureInfo("ru-RU")));
            }
            // Домашняя работк 4.1
            Console.WriteLine("Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год (високосный или нет). Год вводится с экрана. (Год високосный, если он делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный год. Однако, если он делится без остатка на 400, это високосный год.)");
            Console.WriteLine("ввведите номер дня(от 1 до 365) и год(от 1 до 9999), вы узнаете, день месяца");
            int year;
            if (!int.TryParse(Console.ReadLine(), out day) || day < 1 || day > 365 || !int.TryParse(Console.ReadLine(), out year) || year < 1 || year > 9999)
            {
                Console.WriteLine("данные введены неверно");
            }
            else
            {
                Console.WriteLine(new DateTime(year, 1, 1).AddDays(day - 1).ToString("M", new System.Globalization.CultureInfo("ru-RU")));
            }
        }
    }
}