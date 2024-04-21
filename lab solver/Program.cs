using System;

public class MazeSolver
{
    public string mazeRunner(int[,] maze, string[] directions)
    {
        // Pozycja startowa
        int startX = -1, startY = -1;
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                if (maze[i, j] == 2)
                {
                    startX = i;
                    startY = j;
                    break;
                }
            }
            if (startX != -1 && startY != -1)
                break;
        }

        // Ustaw pozycję startową
        int posX = startX;
        int posY = startY;

        foreach (string direction in directions)
        {
            switch (direction)
            {
                case "N":
                    posX--;
                    break;
                case "S":
                    posX++;
                    break;
                case "E":
                    posY++;
                    break;
                case "W":
                    posY--;
                    break;
            }

            // Sprawdź czy nowa pozycja gracza mieści się w granicach labiryntu
            if (posX < 0 || posX >= maze.GetLength(0) || posY < 0 || posY >= maze.GetLength(1))
            {
                return "Dead";
            }

            // Sprawdź co znajduje się na nowej pozycji
            int cellValue = maze[posX, posY];
            if (cellValue == 1)
            {
                return "Dead";
            }
            else if (cellValue == 3)
            {
                return "Finish";
            }
        }

        return "Lost";
    }

    static void Main(string[] args)
    {
        MazeSolver solver = new MazeSolver();

        int[,] maze = {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 0, 0, 0, 0, 0, 3 },
            { 1, 0, 1, 0, 1, 0, 1 },
            { 0, 0, 1, 0, 0, 0, 1 },
            { 1, 0, 1, 0, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1 },
            { 1, 2, 1, 0, 1, 0, 1 }
        };

        string[] directions = { "N", "N", "N", "N", "N", "E", "E", "E", "E", "E" };

        string result = solver.mazeRunner(maze, directions);
        Console.WriteLine("Result: " + result);
    }
}
