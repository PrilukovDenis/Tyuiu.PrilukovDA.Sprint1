using Tyuiu.PrilukovDA.Sprint1.Task1.V16.Lib;

DataService data = new DataService();

Console.Write("Введите первое значение: ");
double x = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе значение: ");
double y = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье значение: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(data.Calculate(x, y, a));
Console.ReadKey();
