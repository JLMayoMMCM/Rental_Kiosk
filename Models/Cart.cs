
namespace Rental_App_V1._0.Models
{
    internal class Cart
    {
        public int ItemId { get; set; }

        public string StudentId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        public int RentPerDay { get; set; }

        public string ItemImage { get; set; }

        public int NoOfRentDays { get; set; }

        public int TotalPrice { get; set; }


        public Cart()
        {
            ItemId = 0;
            StudentId = null;
            Name = null;
            Category = null;
            RentPerDay = 0;
            ItemImage = null;
            NoOfRentDays = 0;
            TotalPrice = 0;
        }

        public Cart(int itemID, string studentID, string name, string category, int rentPerDay, int NoOfRentDay, string itemImage, int TotalRentCost)
        {
            ItemId = itemID;
            StudentId = studentID;
            Name = name;
            Category = category;
            RentPerDay = rentPerDay;
            NoOfRentDays = NoOfRentDay;
            ItemImage = itemImage;
            TotalPrice = TotalRentCost;
        }
    }
}
