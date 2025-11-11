using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PrilukovDA.Sprint1.Task3.V18.Lib
{
    public class DataService : ISprint1Task3V18
    {
        public double HowManySquares(double a, double b, double c)
        {
            double horCount = Math.Floor(a / c);
            double vertCount = Math.Floor(b / c);
            return Math.Round(horCount * vertCount, 3);
        }
    }
}
