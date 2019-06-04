using System;
using System.IO;

namespace Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = "files";
            string sourceFile = "sliceMe.txt";
            string sourcePath = Path.Combine(sourceDirectory, sourceFile);
            int parts = 4;
            using (var streamRead = new FileStream(sourcePath, FileMode.Open))
            {
                long pieceSize = (long)Math.Ceiling((double)streamRead.Length / parts);

                for (int i = 0; i < parts; i++)
                {
                    long currentPieceSize = 0;
                    using (var streamCreate = new FileStream(Path.Combine(sourceDirectory,$"Part{i+1}.txt"), FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];
                        while (streamRead.Read(buffer,0,buffer.Length) == buffer.Length)
                        {
                            currentPieceSize += buffer.Length;
                            streamCreate.Write(buffer, 0, buffer.Length);
                            if (currentPieceSize >= pieceSize)
                            {
                                break;
                            }
                        }
                    }

                }
            }
        }
    }
}
