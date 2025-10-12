using Tyuiu.YachmenevaPV.Sprint2.Task2.V24.Lib;
{
    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Оператор if - полная и короткая форма записи.                     *");
    Console.WriteLine("* Задание #2                                                              *");
    Console.WriteLine("* Вариант #24                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает целые значения с клавиатуры и   *");
    Console.WriteLine("* вычисляет находится ли точка с координатами X и Y в этой области.       *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");
    
    Console.WriteLine("Введите значение переменной X: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите значение переменной Y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    DataService ds = new DataService();
    bool res = ds.CheckDotInShadedArea(x, y);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    if (res)
    {
        Console.WriteLine("Точка находится в закрашенной области");
    }
    else
    {
        Console.WriteLine("Точка не находится в закрашенной области");
    }
    Console.ReadKey();
}
