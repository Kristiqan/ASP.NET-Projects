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


        public List<Flower> GetFlower()
        {
            return db.Flowers.ToList();
        }



    }
}
