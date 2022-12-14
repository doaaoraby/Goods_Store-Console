using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Goods_store.Models;
using System.Text.Json;
using Newtonsoft.Json;
using System.Text;

namespace Goods_store.Services
{
    internal class GenerateFiles
    {
        public void writeInFiles(List<Goods> lines)
        {

            string path = Directory.GetCurrentDirectory();
            var outputFolder = path + @"\output\";
            if (!Directory.Exists(outputFolder))
            {
                Directory.CreateDirectory(outputFolder);
            }
            
            lines =lines.OrderBy(x => x.GoodId).ToList() ;
            var csv = new StringBuilder();
            for (int i=0;i< lines.Count;i++)
            {
                if (i==0)
                {
                    csv.AppendLine(lines[i].GoodId + ";" + lines[i].TransactionId + ";" + lines[i].TransactionDate + ";" + lines[i].Amount + ";" + lines[i].Direction + ";" + lines[i].Comments);
                }
                else if(i== lines.Count-1)
                {
                    csv.AppendLine(lines[i].GoodId + ";" + lines[i].TransactionId + ";" + lines[i].TransactionDate + ";" + lines[i].Amount + ";" + lines[i].Direction + ";" + lines[i].Comments);
                    File.WriteAllText(outputFolder + lines[i - 1].GoodId.ToString() + ".csv", csv.ToString());
                }
                else
                {
                    if (lines[i].GoodId == lines[i-1].GoodId)
                    {
                        csv.AppendLine(lines[i].GoodId + ";" + lines[i].TransactionId + ";" + lines[i].TransactionDate + ";" + lines[i].Amount + ";" + lines[i].Direction + ";" + lines[i].Comments);
                    }
                    else
                    {
                        File.WriteAllText(outputFolder +lines[i - 1].GoodId.ToString()+ ".csv", csv.ToString());
                        csv = new StringBuilder();
                        csv.AppendLine(lines[i].GoodId + ";" + lines[i].TransactionId + ";" + lines[i].TransactionDate + ";" + lines[i].Amount + ";" + lines[i].Direction + ";" + lines[i].Comments);
                    }
                }
            }
        }
    }
}
