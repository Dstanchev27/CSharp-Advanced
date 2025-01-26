namespace LineNumbers
{
    using System;
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            int rownumber = 0;

            using(StreamReader inputReader = new StreamReader(inputFilePath))
            {
                while(!inputReader.EndOfStream)
                {
                    string line = inputReader.ReadLine();

                    Console.WriteLine($"{++rownumber}. {line}");
                }
            }
        }
    }
}
