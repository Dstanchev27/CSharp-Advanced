namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            List<string> newLines = new();

            int lineNumber = 1;
            foreach (var line in lines)
            {
                int lettersCount = line.Count(char.IsLetter);
                int punctuationCount = line.Count(char.IsPunctuation);
                newLines.Add($"Line {lineNumber}: {line} ({lettersCount})({punctuationCount})");
                lineNumber++;
            }

            File.WriteAllLines(outputFilePath, newLines);

            //using (StreamWriter writer = new StreamWriter(outputFilePath))
            //{
            //    int linenumber = 1;

            //    foreach (var line in lines)
            //    {
            //        int letterscount = line.Count(char.IsLetter);
            //        int punctuationcount = line.Count(char.IsPunctuation);

            //        writer.WriteLine($"line {linenumber}: {line} ({letterscount})({punctuationcount})");
            //        linenumber++;
            //    }
            //}
        }
    }
}