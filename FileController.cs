using System;
using System.IO;
using System.Text;

namespace Test_Task
{
    class FileController
    {
        public string FileText { get; set; }
        public static string FileFullPath { get; set; }
        public static string DirectoryName { get; set; }
        public static string FileName { get; set; }

        public static void Create_File() {

            ConsoleColorOutput.Output_Yellow("Enter directory name");
            DirectoryName = Console.ReadLine();

            Directory.CreateDirectory($@"C:\{DirectoryName}");

            ConsoleColorOutput.Output_Yellow("Enter file name");
            FileName = Console.ReadLine();

            FileFullPath = $@"C:\{DirectoryName}\{FileName}.txt";

            using (FileStream fs = File.Create(FileFullPath))
            {
                byte[] info = new UTF8Encoding(true).GetBytes($"This file is created dynamically.");
                fs.Write(info, 0, info.Length);
            }

            ConsoleColorOutput.Output_Green($"File created with path : {FileFullPath}");
        }

        public static string Read_File(string _path) 
        {
            string _fileText;

            using (FileStream fs = File.OpenRead(_path))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                _fileText = Encoding.Default.GetString(array);
            }

            return _fileText;
        }
    }
}
