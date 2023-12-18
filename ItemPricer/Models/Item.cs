using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace ItemPricer.Models
{
    [Table("item_basic")]
    public class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public string SortName { get; set; }
        public int StackSize { get; set; }
        public int AH { get; set; }
        public int NoSale { get; set; }
        public int SalePrice { get; set; }

    }
}
