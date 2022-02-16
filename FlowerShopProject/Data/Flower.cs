using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerShopProject.Data
{
    public class Flower
    {
        public int Id { get; set; }

        public string FlowerName { get; set; }

        public string  FlowerFamily { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public string Photo { get; set; }

        public DateTime ShippingDate { get; set; }

        public string Suggestions { get; set; }
    }
}
