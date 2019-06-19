
namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }

        public Vendor(string firstName, string lastName, double commision)
        {
            FirstName = firstName;
            LastName = lastName;
            Commission = commision;
        }

        public string Display
        {
            get
            {
                return string.Format($"{FirstName} {LastName} - {PaymentDue}");
            }
        }
    }
}
