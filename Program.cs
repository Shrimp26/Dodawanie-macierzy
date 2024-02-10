using System;

//Dane są dwie macierze 10 × 10 o nazwach a i b. 
//Napisz program, który dodaje obie macierze: c = a + b.

class DodawanieMacierzy
{
    static void Main()
    {
        int[,] a = new int[10, 10];
        int[,] b = new int[10, 10];

        WypelnijMacierz(a, 1);
        WypelnijMacierz(b, 2);

        int[,] c = DodajMacierze(a, b);

        Console.WriteLine("Macierz a: ");
        WyswietlMacierz(a);
        Console.WriteLine("\n Macierz b: ");
        WyswietlMacierz(b);
        Console.WriteLine("\n Macierz c = a + b: ");
        WyswietlMacierz(c);
        Console.ReadKey();
    }

    static void WypelnijMacierz(int[,] macierz, int wartosc)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                macierz[i, j] = wartosc;
            }
        }
    }

    static int[,] DodajMacierze(int[,] a, int[,] b)
    {
        int[,] c = new int[10, 10];
        for (int i = 0;i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                c[i, j] = a[i, j] + b[i, j];
            }
        }

        return c;
    }

    static void WyswietlMacierz(int[,] macierz)
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0;j < 10; j++)
            {
                Console.WriteLine(macierz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
