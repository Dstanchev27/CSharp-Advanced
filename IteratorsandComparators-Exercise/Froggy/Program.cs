namespace Froggy
{
    class StartUp
    {
        static void Main()
        {
            List<int> stoneNumbers = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            Lake lake = new Lake(stoneNumbers);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
