namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            int count = 1;

            using (StreamReader inputReader = new StreamReader(inputFilePath))
            {
                using (StreamWriter outputStream = new StreamWriter(outputFilePath))
                {
                    while (!inputReader.EndOfStream)
                    {
                        string line = inputReader.ReadLine();
                        if (count % 2 == 0)
                        {
                            outputStream.WriteLine($"{line}");
                        }
                        count++;
                    }
                }
            }
        }
    }
}
