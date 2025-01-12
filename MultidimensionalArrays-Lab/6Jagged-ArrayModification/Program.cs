namespace _6Jagged_ArrayModification
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            }

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                string[] parts = command.Split();
                string action = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (row >= 0 && row < rows && col >= 0 && col < jaggedArray[row].Length)
                {
                    switch (action)
                    {
                        case "Add":
                            {
                                jaggedArray[row][col] += value;
                                break;
                            }
                        case "Subtract":
                            {
                                jaggedArray[row][col] -= value;
                                break;
                            }
                            default:
                            {
                                break;
                            }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            foreach (var row in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
