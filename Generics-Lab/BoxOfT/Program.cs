namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();

            box.Add("x");
            box.Add("x");
            box.Add("x");
            box.Add("x");

            Console.WriteLine(box.Remove());
        }
    }
}
