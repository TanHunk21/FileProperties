using System;
using System.Collections.Generic;
using System.IO;

namespace FileProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good Afternoon");
            {
                //to get files only
                string rootpath = @"C:\Users\opilane\samples";
                string[] files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
                List<string> lines = new List<string>();


                foreach(string file in files)
                {
                    Console.WriteLine(file);
                    //get file objects
                    var fileData = new FileInfo(file);
                    string fileName = fileData.Name;
                    string fileDirectory = fileData.DirectoryName;
                    long fileSize = fileData.Length;

                    //Console.WriteLine($"File name: {fileName}; location {fileDirectory}; Size {fileSize}");
                    string line= $"File name: {fileName}; location {fileDirectory}; Size: {fileSize} bytes";
                    lines.Add(line);

                }
                string fileDataPatch = @"C:\Users\opilane\samples\FileData.txt";
                File.WriteAllLines(fileDataPatch, lines);
            }
            
        }
    }
}
