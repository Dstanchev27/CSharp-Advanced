namespace _3MaximalSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = dimensions[0], cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var rowValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rowValues[j];
                }
            }

            int maxSum = int.MinValue;
            int[,] bestSubMatrix = new int[3, 3];

            for (int i = 0; i <= rows - 3; i++)
            {
                for (int j = 0; j <= cols - 3; j++)
                {
                    int currentSum = 0;
                    int[,] currentSubMatrix = new int[3, 3];

                    for (int subRow = 0; subRow < 3; subRow++)
                    {
                        for (int subCol = 0; subCol < 3; subCol++)
                        {
                            currentSubMatrix[subRow, subCol] = matrix[i + subRow, j + subCol];
                            currentSum += currentSubMatrix[subRow, subCol];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestSubMatrix = currentSubMatrix;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(string.Join(" ", Enumerable.Range(0, 3).Select(j => bestSubMatrix[i, j])));
            }
        }
    }
}
