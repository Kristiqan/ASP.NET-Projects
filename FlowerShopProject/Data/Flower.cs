using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public string ShippingAddress { get; set; }
        
        public DateTime ShippingDate { get; set; }  
    }
}
