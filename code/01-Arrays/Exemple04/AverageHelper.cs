using System;

namespace Exemple04
{
    public class AverageHelper
    {
        public double CalculateAverage(int[] values)
        {
            if (values.Length == 0)
            {
                throw new ArgumentException("O array precisa ter pelo menos um elemento!");
            }

            int sum = 0;
            foreach (int num in values)
            {
                sum += num;
            }
            return (double)sum / values.Length;
        }
    }
}