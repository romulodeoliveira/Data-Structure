using System;

namespace Exemple02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Arrays multidimensionais podem ser inicializadas especificando valores entre colchetes para cada linha.
            O array seguinte tem 2 linhas e cada linha tem 2 colunas:
            */

            string[,] frutas = new string[2, 2]
            {
                {"maçã", "banana"},
                {"goiaba", "uva"}
            };

            System.Console.WriteLine(frutas[0, 0]);
            System.Console.WriteLine(frutas[0, 1]);
            System.Console.WriteLine(frutas[1, 0]);
            System.Console.WriteLine(frutas[1, 1]);

            // Mas também podem ser inicializados não especificando valores entre colchetes:

            string[,] animais = new string[,] {
                {"gato", "cachorro"},
                {"passaro", "peixe"}
            };

            System.Console.WriteLine(animais[0, 0]);
            System.Console.WriteLine(animais[0, 1]);
            System.Console.WriteLine(animais[1, 0]);
            System.Console.WriteLine(animais[1, 1]);
        }
    }
}

/* Output:

maçã
banana
goiaba
uva
gato
cachorro
passaro
peixe

*/