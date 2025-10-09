using Tyuiu.GroshevID.Sprint2.Task2.V6.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры     *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной      *");
        Console.WriteLine("* области.                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение X:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение Y:");
        int y = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        if (res) Console.WriteLine("Точка находится в заштрихованной области");
        else Console.WriteLine("Точка не находится в заштрихованной области");

        Console.ReadKey();
    }
}