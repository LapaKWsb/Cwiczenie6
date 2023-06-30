using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tablica = new int[10, 10];

        int liczba = 1;
        int kierunek = 1;
        int i = 0;
        int j = 0;

        while (liczba <= 100)
        {
            tablica[i, j] = liczba;

            if (kierunek == 1)
            {
                j++;
                if (j == 10 || tablica[i, j] != 0)
                {
                    j--;
                    i++;
                    kierunek = 2;
                }
            }
            else if (kierunek == 2)
            {
                i++;
                if (i == 10 || tablica[i, j] != 0)
                {
                    i--;
                    j--;
                    kierunek = 3;
                }
            }
            else if (kierunek == 3)
            {
                j--;
                if (j == -1 || tablica[i, j] != 0)
                {
                    j++;
                    i--;
                    kierunek = 4;
                }
            }
            else if (kierunek == 4)
            {
                i--;
                if (i == -1 || tablica[i, j] != 0)
                {
                    i++;
                    j++;
                    kierunek = 1;
                }
            }

            liczba++;
        }

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write(tablica[row, col] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
