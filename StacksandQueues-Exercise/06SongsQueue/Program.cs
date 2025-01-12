namespace _06SongsQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            var songs = Console.ReadLine().Split(", ");
            Queue<string> songsQueue = new Queue<string>(songs);

            while (songsQueue.Count > 0)
            {
                string command = Console.ReadLine();

                if (command.StartsWith("Play"))
                {
                    songsQueue.Dequeue();
                }
                else if (command.StartsWith("Add"))
                {
                    string song = command.Substring(4);

                    if (songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song);
                    }
                }
                else if (command.StartsWith("Show"))
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
