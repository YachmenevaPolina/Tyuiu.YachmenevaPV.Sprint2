using Tyuiu.YachmenevaPV.Sprint2.Task0.V21.Lib;
{
    DataService ds = new DataService();
    int x = 1705;
    int y = 775;
    bool[] res = new bool[6];
    res = ds.GetCompareOperations(x, y);

    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Добавление к решению итоговых проектов.                           *");
    Console.WriteLine("* Задание #0                                                              *");
    Console.WriteLine("* Вариант #21                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу сравнений и арифметических выражений, которая        *");
    Console.WriteLine("* вернёт логическую последовательность.                                   *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("X = " + x);
    Console.WriteLine("Y = " + y);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    for (int i = 0; i < 6; i++)
    {
        Console.WriteLine(res[i]);
    }
    Console.ReadKey();
}