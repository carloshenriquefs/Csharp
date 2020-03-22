using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\file.txt";
            FileStream fs = null;
            StreamReader sr = null;
            try{
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch(IOException e)
            {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }
            finally{
                if(sr != null) sr.Close();
                if(fs != null) fs.Close();
            }
        }
    }
}
