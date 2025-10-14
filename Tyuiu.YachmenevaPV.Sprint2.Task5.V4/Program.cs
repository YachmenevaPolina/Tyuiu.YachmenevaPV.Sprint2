using Tyuiu.YachmenevaPV.Sprint2.Task5.V4.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Оператор switch.                                                  *");
    Console.WriteLine("* Задание #5                                                              *");
    Console.WriteLine("* Вариант #4                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
    Console.WriteLine("* требуемое значение и возвращает результат.                              *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    
    Console.WriteLine("Введите номер масти: ");
    int numCard = Convert.ToInt32(Console.ReadLine());

    string res;
    if ((numCard < 1) || (numCard > 4))
    {
        res = "Введено неверное значение!";
    }
    else
    {
        res = "Это масть - " + ds.FindCardSuit(numCard);
    }
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine(res);

    Console.ReadKey();
}