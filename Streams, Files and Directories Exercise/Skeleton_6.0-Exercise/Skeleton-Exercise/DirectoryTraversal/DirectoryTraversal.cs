namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            var files = Directory.GetFiles(inputFolderPath);
            Dictionary<string, List<DirectoryFile>> extentionFiles = new Dictionary<string, List<DirectoryFile>>();
            StringBuilder stringBuilder = new StringBuilder();

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                // Get file size in bytes
                long fileSize = fileInfo.Length;

                // Get file extension
                string fileExtension = fileInfo.Extension;

                //Get file name
                string name = fileInfo.Name;

                if (!extentionFiles.ContainsKey(fileExtension))
                {
                    extentionFiles[fileExtension] = new List<DirectoryFile>();
                }

                extentionFiles[fileExtension].Add(new DirectoryFile() { Name = name, Size = fileSize / 1024M });
            }

            foreach (var extention in extentionFiles.OrderByDescending(x => x.Value.Count))
            {
                stringBuilder.AppendLine(extention.Key);
                foreach(var file in extention.Value.OrderBy(x => x.Name))
                {
                    stringBuilder.AppendLine($"--{file.Name} - {file.Size}");
                }
            }

            return stringBuilder.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using(StreamWriter streamWriter = new StreamWriter(desktopPath + reportFileName))
            {
                streamWriter.WriteLine(textContent);
            }
        }
    }
    public class DirectoryFile
    {
        public string Name { get; set; }
        public decimal Size { get; set; }

    }
}