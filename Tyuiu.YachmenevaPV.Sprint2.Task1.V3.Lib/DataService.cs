﻿using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YachmenevaPV.Sprint2.Task1.V3.Lib
{
    public class DataService : ISprint2Task1V3
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a + 132 > b) | (c < d);
            res[1] = (a > b) & (c < d);
            res[2] = (a == b) || (c != d);
            res[3] = (a > b) && (c == d);
            res[4] = !(res[0]);
            res[5] = (a < b) ^ (c == d);

            return res;
        }
    }
}
