using System;

namespace Exemple05
{
    class Program
    {
        static void Main(string[] args)
        {
            ParamArray app = new ParamArray();
            int sum = app.AddElements(1, 2, 3, 4, 5);

            Console.WriteLine("A soma é: {0}", sum);
        }
    }
}