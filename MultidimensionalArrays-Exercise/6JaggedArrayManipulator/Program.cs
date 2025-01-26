namespace _6JaggedArrayManipulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            double[][] jaggedArray = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                jaggedArray[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();
            }

            for (int i = 0; i < rows - 1; i++)
            {
                if (jaggedArray[i].Length == jaggedArray[i + 1].Length)
                {
                    jaggedArray[i] = jaggedArray[i].Select(x => x * 2).ToArray();
                    jaggedArray[i + 1] = jaggedArray[i + 1].Select(x => x * 2).ToArray();
                }
                else
                {
                    jaggedArray[i] = jaggedArray[i].Select(x => x / 2).ToArray();
                    jaggedArray[i + 1] = jaggedArray[i + 1].Select(x => x / 2).ToArray();
                }
            }

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                var parts = command.Split();
                string action = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                double value = double.Parse(parts[3]);

                if (row >= 0 && row < rows && col >= 0 && col < jaggedArray[row].Length)
                {
                    if (action == "Add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }

            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
