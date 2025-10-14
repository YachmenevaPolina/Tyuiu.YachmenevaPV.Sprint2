using Tyuiu.YachmenevaPV.Sprint2.Task3.V2.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Вложенные операторы if - else.                                    *");
    Console.WriteLine("* Задание #3                                                              *");
    Console.WriteLine("* Вариант #2                                                             *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с    *");
    Console.WriteLine("* использованием вложенных операторов if-else, где пользователь вводит    *");
    Console.WriteLine("* значение перменной Х с клавиатуры.                                      *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Введите значение переменной Х: ");
    double x = Convert.ToDouble(Console.ReadLine());
    double res = ds.Calculate(x);

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    Console.WriteLine("Значение функции = " + res);

    Console.ReadKey();
}
