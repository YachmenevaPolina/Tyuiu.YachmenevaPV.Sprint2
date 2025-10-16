using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YachmenevaPV.Sprint2.Task7.V14.Lib
{
    public class DataService : ISprint2Task7V14
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            bool inside = Math.Pow(x, 2) + Math.Pow(y, 2) <= 1;
            bool between = (y <= x) && (y >= -x);

            if (inside && between) {res = true;}
            else {res = false;}
            return res;
        }
    }
}
