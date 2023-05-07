using System;

namespace Exemple05
{
    public class ParamArray
    {
        public int AddElements(params int[] arr)
        {
            int sum = 0;

            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }
    }
}