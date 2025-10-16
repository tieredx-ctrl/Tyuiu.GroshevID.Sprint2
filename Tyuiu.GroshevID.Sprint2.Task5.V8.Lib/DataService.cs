using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GroshevID.Sprint2.Task5.V8.Lib
{
    public class DataService : ISprint2Task5V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {
            string res;

            if (m == 1 && n == 1)
            {
                return "1 января - предыдущий день не определен";
            }

            if (n > 1) n -= 1;
            else
            {
                m -= 1;
                switch (m)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        n = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        n = 30;
                        break;
                    case 2:
                        n = 28;
                        break;
                    default:
                        throw new ArgumentException($"Месяц должен быть от 1 до 12. Значение {m}");
                }
            }

            string[] monthNames = {
                "", "января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря"
            };

            res = $"{n} {monthNames[m]}";

            return res;
        }
    }
}