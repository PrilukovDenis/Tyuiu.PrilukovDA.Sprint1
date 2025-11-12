using Tyuiu.PrilukovDA.Sprint1.Task7.V5.Lib;
Console.Title = "Спринт #1 | Выполнил: Прилуков Д.А. | НТм-24-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
Console.WriteLine("* Задание #7                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнил: Иванов Евгений Олегович | ПИНб-25-1                           *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("*Написать консольную программу на C#                                      *");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("*                                                                         *");

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("***************************************************************************");
Console.WriteLine("***********         ln|cos(x)|                                             *");
Console.WriteLine("*********** z =   ---------------                                          *");
Console.WriteLine("***********         ln(1 + x^2)                                            *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите x");
double x = Convert.ToDouble(Console.ReadLine());
DataService ds = new DataService();

Console.WriteLine("* ВЫВОД:                                                        *");
Console.WriteLine(ds.Calculate(x));
Console.ReadLine();
