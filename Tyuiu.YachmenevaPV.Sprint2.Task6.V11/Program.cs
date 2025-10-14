using Tyuiu.YachmenevaPV.Sprint2.Task6.V11.Lib;
{
    DataService ds = new DataService();
    Console.Title = "Спринт #2 | Выполнила: Ячменёва П. В. | РППб-25-1";
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* Спринт #2                                                               *");
    Console.WriteLine("* Тема: Получение результата из switch.                                   *");
    Console.WriteLine("* Задание #6                                                              *");
    Console.WriteLine("* Вариант #11                                                              *");
    Console.WriteLine("* Выполнила: Ячменёва Полина Викторовна | РППб-25-1                       *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* УСЛОВИЕ:                                                                *");
    Console.WriteLine("* Написать программу, которая использует оператор switch, вычисляет       *");
    Console.WriteLine("* требуемое значение и возвращает результат.                              *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
    Console.WriteLine("***************************************************************************");

    Console.Write("Введите год: ");
    int g = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите месяц: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите день: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine(ds.FindDateOfNextDay(g, m, n));



    Console.ReadKey();
}
