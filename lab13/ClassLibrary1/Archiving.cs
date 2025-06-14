using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Archiving
    {

        public static void CompressFile(string inputFile)
        {
            string outputFile = Path.ChangeExtension(inputFile, ".gzar");
            using (FileStream inputStream = File.OpenRead(inputFile))
            using (FileStream outputStream = File.Create(outputFile))
            using (GZipStream compressionStream = new GZipStream(outputStream, CompressionMode.Compress))
            {
                inputStream.CopyTo(compressionStream);
            }
        }

        public static void DecompressFile(string inputFile, string outputFile)
        {
            using (FileStream inputStream = File.OpenRead(inputFile))
            using (FileStream outputStream = File.Create(outputFile))
            using (GZipStream decompressionStream = new GZipStream(inputStream, CompressionMode.Decompress))
            {
                decompressionStream.CopyTo(outputStream);
            }
        }
    }
}
