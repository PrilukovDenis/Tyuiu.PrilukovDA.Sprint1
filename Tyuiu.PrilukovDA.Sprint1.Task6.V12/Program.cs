using Tyuiu.PrilukovDA.Sprint1.Task6.V12.Lib;


Console.WriteLine("Введите текст ");
string value = Convert.ToString(Console.ReadLine());

DataService ds = new DataService();

Console.WriteLine(ds.CheckLastWordRepetiton(value));
Console.ReadKey();