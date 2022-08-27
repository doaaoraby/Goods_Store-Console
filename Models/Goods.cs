using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods_store.Models
{
    internal class Goods
    {
        [Index(0)]
        public int GoodId { get; set; }

        [Index(1)]
        public int TransactionId { get; set; }

        [Index(2)]
        public string TransactionDate { get; set; }

        [Index(3)]
        public string Amount { get; set; }
        [Index(4)]
        public string Direction { get; set; }
        [Index(5)]
        public string Comments { get; set; }
    }
}
