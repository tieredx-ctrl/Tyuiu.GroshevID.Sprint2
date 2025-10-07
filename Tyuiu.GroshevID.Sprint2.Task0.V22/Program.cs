using Tyuiu.GroshevID.Sprint2.Task0.V22.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int x = 3105;
        int y = 77;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.Title = "Спринт #2 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Операции сравнения                                                *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность операций не должна нарушаться) и арифметических      *");
        Console.WriteLine("* выражений, которая вернет логическую последовательность(массив):        *");
        Console.WriteLine("* (False, True, True, True, True, False),), при x = 3105, y = 77          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("X = " + x);
        Console.WriteLine("Y = " + y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i=0; i<6; i++)
        {
            Console.WriteLine(res[i]);
        }
    }
}