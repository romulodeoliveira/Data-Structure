using System;

namespace Exemple04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 20, 30, 40, 100 };
            AverageHelper helper = new AverageHelper();
            double average = helper.CalculateAverage(nums);
            Console.WriteLine("A média de valor é: {0}", average);
        }
    }
}