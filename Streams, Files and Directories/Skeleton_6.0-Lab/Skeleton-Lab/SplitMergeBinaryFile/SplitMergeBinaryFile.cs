namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            using (FileStream inputFileStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            {
                long totalSize = inputFileStream.Length;
                long partOneSize = totalSize / 2 + (totalSize % 2 == 1 ? 1 : 0);
                long partTwoSize = totalSize - partOneSize;

                byte[] buffer = new byte[1024];
                int bytesRead;

                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Create, FileAccess.Write))
                {
                    long bytesWritten = 0;
                    while (bytesWritten < partOneSize && (bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        long bytesToWrite = Math.Min(bytesRead, partOneSize - bytesWritten);
                        partOneStream.Write(buffer, 0, (int)bytesToWrite);
                        bytesWritten += bytesToWrite;
                    }
                }

                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Create, FileAccess.Write))
                {
                    while ((bytesRead = inputFileStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        partTwoStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (FileStream outputFileStream = new FileStream(joinedFilePath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                using (FileStream partOneStream = new FileStream(partOneFilePath, FileMode.Open, FileAccess.Read))
                {
                    while ((bytesRead = partOneStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputFileStream.Write(buffer, 0, bytesRead);
                    }
                }

                using (FileStream partTwoStream = new FileStream(partTwoFilePath, FileMode.Open, FileAccess.Read))
                {
                    while ((bytesRead = partTwoStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        outputFileStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}