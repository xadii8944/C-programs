using System;

public class LandPerimeter
{
    public static int Calculate(string[] map)
    {
        int perimeter = 0;

        for (int i = 0; i < map.Length; i++)
        {
            for (int j = 0; j < map[i].Length; j++)
            {
                if (map[i][j] == 'X')
                {
                    int neighbors = 0;

                    // Sprawdzamy sąsiadów: górnego, dolnego, lewego i prawego
                    if (i > 0 && map[i - 1][j] == 'X') neighbors++;
                    if (i < map.Length - 1 && map[i + 1][j] == 'X') neighbors++;
                    if (j > 0 && map[i][j - 1] == 'X') neighbors++;
                    if (j < map[i].Length - 1 && map[i][j + 1] == 'X') neighbors++;

                    // Obliczamy obwód dla danego pola lądu
                    perimeter += 4 - neighbors;
                }
            }
        }

        return perimeter;
    }
}

public class Program
{
    static void Main(string[] args) //Podaj kształty wysp. X ląd, O woda
    {
        string[] map = {
             "XOOO",
             "XOXO",
             "XOXO",
             "OOXX",
             "OOOO"
        };


        int totalPerimeter = LandPerimeter.Calculate(map);
        Console.WriteLine("Total land perimeter: " + totalPerimeter);
    }
}
