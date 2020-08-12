using Lesson7.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lesson7.DAL
{
    class PurchasedOrdersRepository
    {
        public IEnumerable<PurchasedOrder> GetAllPurchases()
        {
            using var context  = new OnlineStoreDbContext();
            return context.PurchasedOrders.Select(s => new PurchasedOrder 
            { 
                Id = s.Id,
                ItemId = s.ItemId,
                ItemName = s.ItemName,
                Count = s.Count,
                DeliveryAddress = s.DeliveryAddress
            }).ToList();
        }
    }
}
