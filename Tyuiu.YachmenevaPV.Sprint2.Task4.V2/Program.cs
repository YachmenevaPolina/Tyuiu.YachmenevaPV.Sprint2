using Tyuiu.YachmenevaPV.Sprint2.Task4.V2.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Тернарный оператор.                                               *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #2                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая вычисляет требуемое значение с              *");
    Console.WriteLine("* использованием тернарного оператора, где пользователь вводит значение   *");
    Console.WriteLine("* переменных х, у с клавиатуры, если х > y + 3.                           *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите значение переменной Х: ");
    double x = Convert.ToDouble(Console.ReadLine()); 

    Console.WriteLine("Введите значение переменной Y: ");
    double y = Convert.ToDouble(Console.ReadLine());
    double res = ds.Calculate(x, y);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Значение функции = " + res);

    Console.ReadKey();

}