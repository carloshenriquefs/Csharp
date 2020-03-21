using System;
using System.IO;

namespace File_FileInfo
{
    class Program
    {
        //DUPLICAR UM ARQUIVO: atraves do FILEINFO
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file.txt";
            string targetPath = @"c:\temp\file1.txt";

            try
            {
                FileInfo file = new FileInfo(sourcePath);
                file.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(var line in lines)
                {
                    Console.WriteLine(line);
                } 
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
