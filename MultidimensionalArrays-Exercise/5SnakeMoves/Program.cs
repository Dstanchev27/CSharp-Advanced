namespace _5SnakeMoves
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0], cols = dimensions[1];
            char[,] matrix = new char[rows, cols];

            string snake = Console.ReadLine();
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = snake[index];
                        index = (index + 1) % snake.Length;
                    }
                }
                else
                {
                    for (int j = cols - 1; j >= 0; j--)
                    {
                        matrix[i, j] = snake[index];
                        index = (index + 1) % snake.Length;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
