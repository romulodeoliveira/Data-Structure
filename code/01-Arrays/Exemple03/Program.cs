using System;

namespace Exemple03
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][,] frutas = new string[3][,]
            {
                new string[,] { {"Maçã", "Banana", "Laranja"}, {"Abacaxi", "Morango", "Uva"}, {"Mamão", "Maracujá", "Tangerina"} },
                new string[,] { {"Manga", "Limão"}, {"Pera", "Melancia"}, {"Jaca", "Pitaya"} },
                new string[,] { {"Kiwi", "Cereja"}, {"Caqui", "Framboesa"} }
            };

            int a = 0;
            int b = 0;

            while (a < frutas.Length)
            {
                b = 0;

                while (b < frutas[a].GetLength(0))
                {
                    int c = 0;

                    while (c < frutas[a].GetLength(1))
                    {
                        System.Console.WriteLine($"Elemento[{a}][{b}, {c}] - {frutas[a][b, c]}");

                        c++;
                    }

                    b++;
                }

                a++;
            }
        }
    }
}


/* Output:

Elemento[0][0, 0] - Maçã
Elemento[0][0, 1] - Banana
Elemento[0][0, 2] - Laranja
Elemento[0][1, 0] - Abacaxi
Elemento[0][1, 1] - Morango
Elemento[0][1, 2] - Uva
Elemento[0][2, 0] - Mamão
Elemento[0][2, 1] - Maracujá
Elemento[0][2, 2] - Tangerina
Elemento[1][0, 0] - Manga
Elemento[1][0, 1] - Limão
Elemento[1][1, 0] - Pera
Elemento[1][1, 1] - Melancia
Elemento[1][2, 0] - Jaca
Elemento[1][2, 1] - Pitaya
Elemento[2][0, 0] - Kiwi
Elemento[2][0, 1] - Cereja
Elemento[2][1, 0] - Caqui
Elemento[2][1, 1] - Framboesa

*/