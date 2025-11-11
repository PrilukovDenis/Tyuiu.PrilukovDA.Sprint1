using Tyuiu.PrilukovDA.Sprint1.Task2.V6.Lib;

DataService ds = new DataService();

Console.Write("Введите расстояние в метрах ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ds.ConvertMToKm(x));
Console.ReadKey();
