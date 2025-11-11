
using Tyuiu.PrilukovDA.Sprint1.Task3.V18.Lib;

DataService ds = new DataService();

Console.WriteLine("Введите размеры стороны a ");
double a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите размеры стороны b ");
double b = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите размеры стороны c ");
double c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(ds.HowManySquares(a, b, c));
Console.ReadKey();
