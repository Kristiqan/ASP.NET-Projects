using FlowerShopProject.Data;
using FlowerShopProject.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerShopProject.Services
{
    public class FlowerService : IFlowerService
    {
        private readonly FlowerShopDbContext db;

        public FlowerService(FlowerShopDbContext db)
        {
            this.db = db;
        }

        public void AddFlower(Flower flowertoAdd)
        {
            db.Flowers.Add(flowertoAdd);
            db.SaveChanges(); 
        }

        public void EditPurchase(Flower flowertoEdit)
        {
            var flower = this.GetById(flowertoEdit.Id);

            flower.FlowerName = flowertoEdit.FlowerName;
            flower.FlowerFamily = flowertoEdit.FlowerFamily;
            flower.Quantity = flowertoEdit.Quantity;
            flower.ShippingAddress = flowertoEdit.ShippingAddress;
            flower.ShippingDate = flowertoEdit.ShippingDate;

            db.SaveChanges();
        }


        public List<Flower> GetFlower()
        {
            return db.Flowers.ToList();
        }

        public Flower GetById(int id)
        {
            return this.db.Flowers.FirstOrDefault(x => x.Id == id);
        }

       
    }
}
