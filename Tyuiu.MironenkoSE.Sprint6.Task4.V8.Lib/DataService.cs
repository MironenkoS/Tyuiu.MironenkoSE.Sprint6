using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.MironenkoSE.Sprint6.Task4.V8.Lib
{
    public class DataService : ISprint6Task4V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = 0;
            int len = Math.Abs(startValue) + Math.Abs(stopValue) + 1;
            double[] array = new double[len];
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x + 2 != 0)
                {
                    double y = (Math.Sin(x) + (Math.Cos(x) + 1) / (2 - x) + 2 * x);
                    y = Math.Round(y, 2);
                    array[count] = y;
                    count++;
                }
                else
                {
                    double y = 0;
                    array[count] = y;
                    count++;
                }

            }
            return array;
        }
    }
}