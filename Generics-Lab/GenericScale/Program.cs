namespace GenericScale
{
    public class Program
    {
        static void Main(string[] args)
        {
            EqualityScale<int> intScale = new EqualityScale<int>(5, 5);
            Console.WriteLine(intScale.AreEqual());

            EqualityScale<string> stringScale = new EqualityScale<string>("Hello", "World");
            Console.WriteLine(stringScale.AreEqual());
        }
    }
}
