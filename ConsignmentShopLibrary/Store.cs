using System.Collections.Generic;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }
        public decimal Profit { get; set; }

        public Store(string name)
        {
            Name = name;
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }

        public string ProfitDisplay()
        {
            return string.Format($"${Profit}");
        }
    }
}
