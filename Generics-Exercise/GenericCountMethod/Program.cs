namespace GenericCountMethod
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Задача 5

            //int n = int.Parse(Console.ReadLine());
            //List<Box<string>> boxes = new List<Box<string>>();

            //for (int i = 0; i < n; i++)
            //{
            //    string input = Console.ReadLine();
            //    boxes.Add(new Box<string>(input));
            //}

            //string elementToCompare = Console.ReadLine();
            //int result = Box<string>.CountGreaterThan(boxes, elementToCompare);

            //Console.WriteLine(result);

            //Задача 6

            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                boxes.Add(new Box<double>(input));
            }

            double elementToCompare = double.Parse(Console.ReadLine());
            int result = Box<double>.CountGreaterThan(boxes, elementToCompare);

            Console.WriteLine(result);
        }
    }
}
