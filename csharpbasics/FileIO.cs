using System;
using System.IO;
namespace FileDirectoryHandling
{
    public class FileIO
    {
        public void LearnFileReading()
        {
            string fileContent =File.ReadAllText("Test.txt");//or give absolute path if file not present in project
            Console.WriteLine(fileContent);
        }
        public void LearnFileWriting()
        {
            File.WriteAllText("A.txt", "I am new just created");
        }
        public void LearnFileInfo()
        {
            FileInfo fileInfo = new FileInfo("A.txt");
            var x =fileInfo.Length;
            var y =fileInfo.CreationTime;
            var z =fileInfo.DirectoryName;

            Console.WriteLine($" File Size:{x} bytes");
            Console.WriteLine($" Created:{y}");
            Console.WriteLine($" Directory:{z}");

        }
        internal void LearnDirectory()
        {
            Directory.CreateDirectory("ABC");
            File.WriteAllText($"ABC", "this is my own file");
        }
        internal void LearnDirectoryInfo()
        {
            string folderpath =@"C:\Documents\Rupesh.Sanjel";
            DirectoryInfo directory =new DirectoryInfo(folderpath);
            var files = directory.GetFiles();
             Console.WriteLine("File count: " + files.Length);
        }


    }
}