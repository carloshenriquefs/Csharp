using System;
using System.IO;

namespace PathString
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\myfolder\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: "+Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: "+Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: "+Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: "+Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithouExtension: "+Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: "+Path.GetExtension(path));
            Console.WriteLine("GetFullPath: "+ Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: "+Path.GetTempPath());
        }
    }
}
