using GameOfLife.Game;
using System;

namespace GameOfLife
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            int height;
            int width;
            int generations;
            do
            {
                Console.WriteLine("Enter height of game board");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out height)); ;

            do
            {
                Console.WriteLine("Enter width of game board");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out width));

            do
            {
                Console.WriteLine("Enter number of generations to run");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out generations));

            int run = 0;
            LifeGame generation = new LifeGame(height, width);

            while (run++ < generations)
            {
                Console.WriteLine($"Generation  {run}");
                generation.RenderAndGenerate();

                System.Threading.Thread.Sleep(2000);
                Console.Clear();
            }
        }

    }


}