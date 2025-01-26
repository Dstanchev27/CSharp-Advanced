namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] firstFileLines = File.ReadAllLines(firstInputFilePath);
            string[] secondFileLines = File.ReadAllLines(secondInputFilePath);

            int maxLength = Math.Max(firstFileLines.Length, secondFileLines.Length);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                for (int i = 0; i < maxLength; i++)
                {
                    if (i < firstFileLines.Length)
                    {
                        writer.WriteLine(firstFileLines[i]);
                    }

                    if (i < secondFileLines.Length)
                    {
                        writer.WriteLine(secondFileLines[i]);
                    }
                }
            }
        }
    }
}