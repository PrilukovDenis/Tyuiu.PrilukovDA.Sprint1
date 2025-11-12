using Tyuiu.PrilukovDA.Sprint1.Task5.V2.Lib;

double temp = Convert.ToDouble(Console.ReadLine());
DataService ds = new DataService();

Console.WriteLine(ds.FahrenheitToСelsius(temp));
Console.ReadKey();