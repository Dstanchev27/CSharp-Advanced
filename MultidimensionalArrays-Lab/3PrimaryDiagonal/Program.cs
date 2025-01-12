namespace _3PrimaryDiagonal
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rows = n;
            int cols = n;

            int[,] matrix = new int[rows,cols];
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }

                sum += matrix[row, row];
            }

            Console.WriteLine(sum);
        }
    }
}
