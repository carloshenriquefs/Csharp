using System;
using System.IO;

namespace MaiusculaLetraStreamWriter {
    class Program {
        static void Main (string[] args) {

            string sourcePath = @"c:\temp\file.txt";
            string targetPath = @"c:\temp\file1.txt";

            try {
                string[] lines = File.ReadAllLines (sourcePath);
                using (StreamWriter sw = File.AppendText (targetPath)) {
                    foreach (string line in lines) {
                        sw.WriteLine (line.ToUpper ());
                    }
                }
            } catch (IOException e) {
                Console.WriteLine ("Ocorreu um erro");
                Console.WriteLine (e.Message);
            }

        }
    }
}