using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.YachmenevaPV.Sprint2.Task5.V4.Lib
{
    public class DataService : ISprint2Task5V4
    {
        public string FindCardSuit(int value)
        {
            string res;
            switch(value)
            {
                case 1:
                    res = "Пики";
                    break;
                case 2:
                    res = "Трефы";
                    break;
                case 3:
                    res = "Бубны";
                    break;
                case 4:
                    res = "Червы";
                    break;
                default:
                    throw new ArgumentException($"Масть должна быть от 1 до 4. Знчение {value}");
            }
            return res;
        }
    }
}
