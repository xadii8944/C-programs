using System;

public static class Program
{
    public static long factorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        else
        {
            return n * factorial(n - 1);
        }
    }

    static void Main(string[] args)
    {
        int liczba = 4; //Podaj liczbe
        long wynik = factorial(liczba);
        Console.WriteLine("Silnia z {0} wynosi {1}", liczba, wynik);
    }
}
