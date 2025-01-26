namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int lineNumber = 0;
                string line;
                string result = "";

                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNumber % 2 == 0)
                    {
                        string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        string replacedLine = string.Join(" ", words.Reverse()).Replace("-", "@").Replace(",", "@").Replace(".", "@").Replace("!", "@").Replace("?", "@");
                        result += replacedLine + Environment.NewLine;
                    }

                    lineNumber++;
                }

                return result.TrimEnd();
            }
        }
    }
}