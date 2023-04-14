using System;

namespace Exemple01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[10];
            // Nesse caso, a variável n é um array que recebe 10 inteiros

            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 1;
            }
            // Inicializa os elementos do array n

            for (int j = 0; j < 10; j++)
            {
                System.Console.WriteLine($"Elemento[{j + 1}] = {n[j]}");
            }
            // Printa os elementos do array na tela
        }
    }
}

/* output:
Elemento[1] = 1
Elemento[2] = 2
Elemento[3] = 3
Elemento[4] = 4
Elemento[5] = 5
Elemento[6] = 6
Elemento[7] = 7
Elemento[8] = 8
Elemento[9] = 9
Elemento[10] = 10
*/