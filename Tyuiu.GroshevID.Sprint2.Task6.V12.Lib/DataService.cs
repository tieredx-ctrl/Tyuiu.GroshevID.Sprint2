using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GroshevID.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            if (n > 1)
            {
                return $"{g}.{m}.{n - 1}";
            }

            return m switch
            {
                1 => $"{g - 1}.12.31",
                3 => $"{g}.2.29",
                2 or 4 or 6 or 8 or 9 or 11 => $"{g}.{m - 1}.31",
                5 or 7 or 10 or 12 => $"{g}.{m - 1}.30",
                _ => throw new ArgumentException("Некорректный номер месяца")
            };
        }
    }
}
