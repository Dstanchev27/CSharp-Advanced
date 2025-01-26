namespace _1DiagonalDifference
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = ReadMatrix(n);

            int primaryDiagonalSum = CalculatePrimaryDiagonalSum(matrix, n);
            int secondaryDiagonalSum = CalculateSecondaryDiagonalSum(matrix, n);

            int difference = Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

            Console.WriteLine(difference);
        }

        static int[,] ReadMatrix(int n)
        {
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }

            return matrix;
        }

        static int CalculatePrimaryDiagonalSum(int[,] matrix, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }

        static int CalculateSecondaryDiagonalSum(int[,] matrix, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, n - 1 - i];
            }
            return sum;
        }
    }
}
