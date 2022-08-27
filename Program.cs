using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using System.IO;
using Goods_store.Models;
using Newtonsoft.Json;
using System.Text;
using System.Web.Script.Serialization;
using Goods_store.Services;

namespace Goods_store
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter path of your file");
            Console.WriteLine("(Don't forget to put the name of your drive in CAPS followed by ':\\' and the extension of your file after file name)");

            var filePath =Console.ReadLine();
            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine();//to skip first 2 lines 
                reader.ReadLine();
                string path = Directory.GetCurrentDirectory();
                var readFile= new ReadFile();
                var generateFiles = new GenerateFiles();
                (List<FirstBalance>fb,StreamReader sr)=readFile.readFirstBalance(reader);
                StreamReader sRead=readFile.readSeparationLines(sr);
                List<Goods> readLines =readFile.readInputFile(sRead);
                //var files=generateFiles.gnrateFiles(fb);
                generateFiles.writeInFiles(readLines);
            }
            Console.ReadLine();
        }
    }
}
