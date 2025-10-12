using Tyuiu.YachmenevaPV.Sprint2.Task1.V3.Lib;
{
    DataService ds = new DataService();
    int a = 185;
    int b = 316;
    int c = 134;
    int d = 134;
    bool[] res = new bool[6];
    res = ds.GetLogicOperations(a, b, c, d);

    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Логические операции.                                              *");
    Console.WriteLine("* Задание #1                                                              *");
    Console.WriteLine("* Вариант #3                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу из операций сравнений и логических операций, а также *");
    Console.WriteLine("* арифметических выражений, которая вернет логическую последовательность. *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("a = " + a);
    Console.WriteLine("b = " + b);
    Console.WriteLine("c = " + c);
    Console.WriteLine("d = " + d);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(res[i]);
    }
    Console.ReadKey();
}