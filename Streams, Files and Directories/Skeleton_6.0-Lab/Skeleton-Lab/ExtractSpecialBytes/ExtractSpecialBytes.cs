namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
            HashSet<byte> specialBytes = new HashSet<byte>();
            using (StreamReader specialBytesReader = new StreamReader(bytesFilePath))
            {
                while (!specialBytesReader.EndOfStream)
                {
                    byte currentSpecialByte = byte.Parse(specialBytesReader.ReadLine());
                    specialBytes.Add(currentSpecialByte);
                }
            }

            using (FileStream inputStream = new FileStream(binaryFilePath, FileMode.Open, FileAccess.Read))
            {
                using (FileStream outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024];
                    int readBytes;

                    while ((readBytes = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        List<byte> specialBuffer = new List<byte>();

                        for (int i = 0; i < readBytes; i++)
                        {
                            if (specialBytes.Contains(buffer[i]))
                            {
                                specialBuffer.Add(buffer[i]);
                            }
                        }

                        if (specialBuffer.Count > 0)
                        {
                            outputStream.Write(specialBuffer.ToArray(), 0, specialBuffer.Count);
                        }
                    }
                }
            }
        }
    }
}
