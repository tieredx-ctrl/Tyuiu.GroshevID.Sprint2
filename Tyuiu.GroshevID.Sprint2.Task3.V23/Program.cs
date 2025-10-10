using Tyuiu.GroshevID.Sprint2.Task3.V23.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Грошев И. Д. | РППб-25-1";

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #23                                                             *");
        Console.WriteLine("* Выполнил: Грошев Илья Дмитриевич | РППб-25-1                            *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
        Console.WriteLine("* использованием вложенных оператор if-else, где пользователь вводит      *");
        Console.WriteLine("* значение переменной X с клавиатуры. Округлить полученное значение до    *");
        Console.WriteLine("* трех знаков после запятой                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Введите значение переменной X:");
        double x = Convert.ToDouble(Console.ReadLine());
        double res = ds.Calculate(x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Значение функции = " + res);

        Console.ReadKey();
    }
}