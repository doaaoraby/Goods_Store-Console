using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods_store.Constants
{
    internal class Const
    {
        public static string path = Directory.GetCurrentDirectory();
        public static string outputFolder = path + @"\output\";
        public static string inputFolder = path + @"\input\";
        public static string logFolder=path + @"\logs\";
    }
}
