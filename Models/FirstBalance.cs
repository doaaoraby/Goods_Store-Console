using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goods_store.Models
{
    internal class FirstBalance
    {
        [Index(0)]
        public int GoodId { get; set; }
        [Index(1)]
        public int FrstBalance { get; set; }
    }
}
