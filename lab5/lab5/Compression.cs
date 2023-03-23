using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace lab5
{
    internal class Compression
    {
        public static void CopressDirectory(DirectoryInfo directory)
        {
            List<Task> compressedFiles = new List<Task>();
            foreach (var file in directory.GetFiles())
                compressedFiles.Add(Task.Factory.StartNew(() => CompressFile(file)));
            Task.WaitAll(compressedFiles.ToArray());
            MessageBox.Show("Directory "+ directory.Name + " has been compressed correctly");
        }

        public static void CompressFile(FileInfo file)
        {
            if(file.Extension != ".gz")
            {
                FileStream fileStream = file.OpenRead();
                FileStream compressedFileStream = File.Create(file.FullName + ".gz");
                GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress);
                fileStream.CopyTo(compressionStream);
                fileStream.Close();
                compressionStream.Close();
                compressedFileStream.Close();
                
            }
        }

        public static void DecompressDirectory(DirectoryInfo directory)
        {
            List<Task> decompressedFiles = new List<Task>();
            foreach (var file in directory.GetFiles())
                if(file.Extension == ".gz")
                    decompressedFiles.Add(Task.Factory.StartNew(() => DecompressFile(file)));
            Task.WaitAll(decompressedFiles.ToArray());
            MessageBox.Show($"Directory "+directory.Name + " has been decompressed correctly");
        }

        private static string NameOfFileWithoutExtension(string fileNameWithExt)
        {
            string[] fileNameParts = fileNameWithExt.Split('.');
            fileNameParts[fileNameParts.Length - 1] = fileNameParts[fileNameParts.Length-2];
            fileNameParts[fileNameParts.Length - 2] = ".";
            string fileName = "";
            foreach (string fileNamePart in fileNameParts)
                fileName += fileNamePart;
            return fileName;
        }

        public static void DecompressFile(FileInfo file)
        {

            FileStream compressedFile = file.OpenRead();
            string fileName = NameOfFileWithoutExtension(file.FullName);
                
            FileStream decompressedFileStream = File.Create(fileName);
            GZipStream decompressionStream = new GZipStream(compressedFile, CompressionMode.Decompress);
            decompressionStream.CopyTo(decompressedFileStream);

            decompressedFileStream.Close();
            decompressionStream.Close();
            compressedFile.Close();
            
        }
    }
}
