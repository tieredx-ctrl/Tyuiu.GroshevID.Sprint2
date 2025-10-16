using Tyuiu.GroshevID.Sprint2.Task6.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами:         *");
        Console.WriteLine("* g (год), m (порядковый номер месяца) и n (число). По заданным g, n и m  *");
        Console.WriteLine("* определить дату предыдущего дня. Заданный год является високосным.      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите год:");
        int g = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер месяца:");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите номер дня:");
        int n = Convert.ToInt32(Console.ReadLine());

        string res;

        if ((m < 1) || (m > 12))
        {
            res = "Введено неверное значение!";
        }
        else
        {
            res = "Дата предыдущего дня: " + ds.FindDateOfPreviousDay(g, m, n);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(res);

        Console.ReadKey();
    }
}