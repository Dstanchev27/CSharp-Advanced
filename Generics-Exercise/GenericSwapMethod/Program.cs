namespace GenericSwapMethod
{
    public class StratUp
    {
        static void Main(string[] args)
        {
            //Задча 3

            //int n = int.Parse(Console.ReadLine());
            //List<Box<string>> boxes = new List<Box<string>>();

            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    boxes.Add(new Box<string>(input));
            //}

            //string[] swapIndexes = Console.ReadLine().Split();
            //int index1 = int.Parse(swapIndexes[0]);
            //int index2 = int.Parse(swapIndexes[1]);

            //Box<string>.Swap(boxes, index1, index2);

            //foreach (var box in boxes)
            //{
            //    Console.WriteLine(box);
            //}

            //Задача 4

            int n = int.Parse(Console.ReadLine());
            List<Box<int>> boxes = new List<Box<int>>();

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                boxes.Add(new Box<int>(input));
            }

            string[] swapIndexes = Console.ReadLine().Split();
            int index1 = int.Parse(swapIndexes[0]);
            int index2 = int.Parse(swapIndexes[1]);

            Box<int>.Swap(boxes, index1, index2);

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
