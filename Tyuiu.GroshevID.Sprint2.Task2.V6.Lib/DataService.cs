﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GroshevID.Sprint2.Task2.V6.Lib
{
    public class DataService : ISprint2Task2V6
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3 && x <= 5 && y >= 3 && y <= 7)
                || (x >= 6 && x <= 9 && y >= 5 && y <= 10)
                || (x >= 3 && x <= 12 && y == 11)
                || (x >= 7 && x <= 10 && y == 12)
                || (x == 9 && y >= 3 && y <= 4)
                || (x == 10 && y >= 5 && y <= 7))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
