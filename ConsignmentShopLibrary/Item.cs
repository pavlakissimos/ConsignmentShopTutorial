
namespace ConsignmentShopLibrary
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }

        public string Display
        {
            get
            {
                return string.Format($"{Title} - {Price}");
            }
        }

        public Item(string title, string description, decimal price, bool paymentDistributed, Vendor owner)
        {
            Title = title;
            Description = description;
            Price = price;
            PaymentDistributed = paymentDistributed;
            Owner = owner;
        }
    }
}
