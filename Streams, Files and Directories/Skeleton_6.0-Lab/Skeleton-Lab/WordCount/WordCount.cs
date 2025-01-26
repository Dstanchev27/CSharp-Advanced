namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            string[] words = File.ReadAllLines(wordsFilePath);
            Dictionary<string, int> wordCounts = words.ToDictionary(word => word.ToLower(), word => 0);

            string[] lines = File.ReadAllLines(textFilePath);
            foreach (string line in lines)
            {
                string[] textWords = line
                    .ToLower()
                    .Split(new char[] { ' ', '.', ',', '!', '?', '-', '\'', ';', ':' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in textWords)
                {
                    if (wordCounts.ContainsKey(word))
                    {
                        wordCounts[word]++;
                    }
                }
            }

            var sortedWordCounts = wordCounts.OrderByDescending(pair => pair.Value);

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var pair in sortedWordCounts)
                {
                    writer.WriteLine($"{pair.Key} - {pair.Value}");
                }
            }
        }
    }
}
