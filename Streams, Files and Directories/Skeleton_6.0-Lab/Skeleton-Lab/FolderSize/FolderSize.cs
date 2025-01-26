namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            double totalSize = CalculateFolderSize(folderPath) / 1024.0;

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{totalSize:F8} KB");
            }
        }

        private static long CalculateFolderSize(string folderPath)
        {
            long totalSize = 0;

            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                totalSize += fileInfo.Length;
            }

            string[] subfolders = Directory.GetDirectories(folderPath);
            foreach (string subfolder in subfolders)
            {
                totalSize += CalculateFolderSize(subfolder);
            }

            return totalSize;
        }
    }
}
