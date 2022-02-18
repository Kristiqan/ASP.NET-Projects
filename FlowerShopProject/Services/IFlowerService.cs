using FlowerShopProject.Data;
using System.Collections.Generic;

namespace FlowerShopProject.Services
{
    public interface IFlowerService
    {
        void AddFlower(Flower flowertoAdd);

        List<Flower> GetFlower();

        Flower GetById(int id);

        void EditPurchase(Flower flower);
    }
}
