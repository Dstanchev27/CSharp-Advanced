namespace _05AppliedArithmetics
{
    public class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Func<int[], int[]> add = Add;
            Func<int[], int[]> multiply = Multiply;
            Func<int[], int[]> subtract = Subtract;
            Action<int[]> print = Print;

            //Func<int[], int[]> add = nums => nums.Select(n => n + 1).ToArray();
            //Func<int[], int[]> multiply = nums => nums.Select(n => n * 2).ToArray();
            //Func<int[], int[]> subtract = nums => nums.Select(n => n - 1).ToArray();
            //Action<int[]> print = nums => Console.WriteLine(string.Join(" ", nums));

            string input = Console.ReadLine();

            while (input != "end")
            {
                switch (input)
                {
                    case "add":
                        {
                            numbers = add(numbers);
                            break;
                        }
                    case "multiply":
                        {
                            numbers = multiply(numbers);
                            break;
                        }
                    case "subtract":
                        {
                            numbers = subtract(numbers);
                            break;
                        }
                    case "print":
                        {
                            print(numbers);
                            break;
                        }
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }

        public static void Print(int[] obj)
        {
            Console.WriteLine(string.Join(" ", obj));
        }

        public static int[] Subtract(int[] arg)
        {
            List<int> result = new List<int>();

            foreach (var item in arg)
            {
                result.Add(item - 1);
            }

            return result.ToArray();
        }

        public static int[] Multiply(int[] arg)
        {
            List<int> result = new List<int>();

            foreach (var item in arg)
            {
                result.Add(item * 2);
            }

            return result.ToArray();
        }

        public static int[] Add(int[] arg)
        {
            List<int> result = new List<int>();

            foreach (var item in arg)
            {
                result.Add(item + 1);
            }

            return result.ToArray();
        }
    }
}
