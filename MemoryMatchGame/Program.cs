using System;
using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        int rows = 3;
        int cols = 2;

        int asciiStart = 62;
        char[] grid = new char[rows * cols];

        for (int i = 0; i < grid.Length; i++)
            grid[i] = Convert.ToChar(asciiStart + i / 2);

        Random rand = new Random();
        rand.Shuffle(grid);

        string[] playingGrid = new string[rows * cols];

        for (int i = 0; i < playingGrid.Length; i++)
            playingGrid[i] = (i + 1).ToString();


        int matches = 0;
        bool gameWon = false;

        while (!gameWon)
        {
            PrintPlayingGrid();
            int choice1 = GetValidChoice("Please select your first card.", playingGrid, rows, cols);
            playingGrid[choice1 - 1] = grid[choice1 - 1].ToString();
            Console.Clear();

            PrintPlayingGrid();
            int choice2 = GetValidChoice("Please enter your second card.", playingGrid, rows, cols, choice1);
            playingGrid[choice2 - 1] = grid[choice2 - 1].ToString();
            Console.Clear();

            PrintPlayingGrid();

            if (grid[choice1 - 1] == grid[choice2 - 1])
            {
                Console.WriteLine("Match!");
                matches++;

                if (matches == rows * cols / 2)
                    gameWon = true;
            }
            else
            {
                Console.WriteLine("No match...");
                playingGrid[choice2 - 1] = choice2.ToString();
                playingGrid[choice1 - 1] = choice1.ToString();
            }

            Thread.Sleep(1000);
            Console.Clear();
        }

        Console.WriteLine("Congratulations, you win!");

        int GetValidChoice(string prompt, string[] playingGridLocal, int rowsLocal, int colsLocal, int? otherChoice = null)
        {
            int max = rowsLocal * colsLocal;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                if (choice < 1 || choice > max)
                {
                    Console.WriteLine($"Enter a number between 1 and {max}.");
                    continue;
                }

                if (otherChoice.HasValue && choice == otherChoice.Value)
                {
                    Console.WriteLine("You must choose a different card.");
                    continue;
                }

                // If the playing grid slot no longer equals its original number, it's already revealed/matched
                if (playingGridLocal[choice - 1] != choice.ToString())
                {
                    Console.WriteLine("That card is already revealed. Choose another.");
                    continue;
                }

                return choice;
            }
        }

        void PrintPlayingGrid()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                    Console.Write(playingGrid[cols * i + j] + " | ");
                Console.WriteLine();
            }
        }
    }
}

static class RandomExtensions
{
    public static void Shuffle<T>(this Random rnd, T[] array)
    {
        if (array == null) throw new ArgumentNullException(nameof(array));
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rnd.Next(i + 1);
            T tmp = array[j];
            array[j] = array[i];
            array[i] = tmp;
        }
    }
}