using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rental_App_V1._0.Models
{
    internal class Item
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Image Image { get; set; }

        public string ImageAddress {  get; set; }

        public Item(int id, string name, string description, int price, int quantity, Image image, string imageAddress)
        {
            ItemID = id;
            ItemName = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            Image = image;
            ImageAddress = imageAddress;
        }


    }
}
