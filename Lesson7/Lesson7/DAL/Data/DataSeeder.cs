using Lesson7.DAL;
using Lesson7.DAL.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlineStore.DAL.Data
{
    public class DataSeeder
    {
        public static void Initialize()
        {
            using var context = new OnlineStoreDbContext();

            if (!context.PurchasedOrders.Any())
            {
                var orders = new List<PurchasedOrder>()
                {
                    new PurchasedOrder { ItemId = 1, ItemName = "Item1", Count = 2, DeliveryAddress = "Address1" },
                    new PurchasedOrder { ItemId = 2, ItemName = "Item2", Count = 3, DeliveryAddress = "Address2" },
                    new PurchasedOrder { ItemId = 3, ItemName = "Item3", Count = 2, DeliveryAddress = "Address3" },
                    new PurchasedOrder { ItemId = 4, ItemName = "Item4", Count = 1, DeliveryAddress = "Address3" },
                    new PurchasedOrder { ItemId = 5, ItemName = "Item5", Count = 1, DeliveryAddress = "Address4" },
                    new PurchasedOrder { ItemId = 6, ItemName = "Item6", Count = 5, DeliveryAddress = "Address5" }
                };
                context.PurchasedOrders.AddRange(orders);
                context.SaveChanges();
            }
        }
    }
}
