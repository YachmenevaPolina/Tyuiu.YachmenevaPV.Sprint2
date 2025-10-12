using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YachmenevaPV.Sprint2.Task2.V24.Lib
{
    public class DataService : ISprint2Task2V24
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if 
        ((y== 3 && x >= 4 && x <= 12) ||
        (y == 4 && x >= 4 && x <= 12) ||
        (y == 5 && x >= 6 && x <= 10) ||
        (y == 6 && x >= 6 && x <= 10) ||
        (y == 7 && x >= 6 && x <= 10) ||
        (y == 8 && x >= 6 && x <= 10) ||
        (y == 9 && x >= 4 && x <= 12) ||
        (y == 10 && x >= 4 && x <= 12) ||
        (y == 11 && x >= 2 && x <= 10) )
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
