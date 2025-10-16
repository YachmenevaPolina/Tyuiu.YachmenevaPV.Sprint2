﻿using Tyuiu.YachmenevaPV.Sprint2.Task7.V14.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
    Console.WriteLine("* Задание #7                                                              *");
    Console.WriteLine("* Вариант #14                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая запрашивает исходные данные и вычисляет,    *");
    Console.WriteLine("* находятся ли точка с координатами X, Y в заштрихованной области.        *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите значение переменной Х: ");
    double x = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите значение переменной Y: ");
    double y = Convert.ToDouble(Console.ReadLine());

    bool res = ds.CheckDotInShadedArea(x, y);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    if (res) { Console.WriteLine("Точка находится в заштрихованной области"); }
    else { Console.WriteLine("Точка не находится в заштрихованной области"); }

    Console.ReadKey();
}