using System;

namespace GameOfLife.Game
{
    public class LifeGame
    {
        private int height;
        private int width;
        private bool[,] cells;
        public LifeGame(int h, int w)
        {
            this.height = h;
            this.width = w;
            cells = new bool[h, w];
            CreateField();
        }
        public void RenderAndGenerate()
        {
            RenderBoard();
            Generate();
        }
        private void Generate()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    int numOfLivingNeighbors = GetCellNeighbours(i, j);

                    cells[i, j] = (numOfLivingNeighbors == 3 || numOfLivingNeighbors == 2);

                }
            }
        }
        private int GetCellNeighbours(int x, int y)
        {
            int livingNeighbours = 0;

            for (int i = x - 1; i < x + 2; i++)
            {
                for (int j = y - 1; j < y + 2; j++)
                {
                    if (!((i < 0 || j < 0) || (i >= height || j >= width)))
                    {
                        if (cells[i, j])
                        { livingNeighbours++; }
                    }
                }
            }
            return livingNeighbours;
        }
        private void RenderBoard()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(cells[i, j] ? "x" : ".");
                    if (j == width - 1) Console.WriteLine("\r");
                }
            }
            Console.SetCursorPosition(0, Console.WindowTop);
        }
        private void CreateField()
        {
            Random generator = new Random();
            int number;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    number = generator.Next(2);
                    cells[i, j] = number != 0;
                }
            }
        }
    }

}
