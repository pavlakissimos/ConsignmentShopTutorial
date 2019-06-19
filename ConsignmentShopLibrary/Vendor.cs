
namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }

        public Vendor(string firstName, string lastName, double commision)
        {
            FirstName = firstName;
            LastName = lastName;
            Commission = commision;
        }
    }
}
