using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7
{
    public class PurchasedOrderProdecer
    {
        private readonly Queue<PurchasedOrder> ordersQueue;
        private readonly object lockObject;

        public PurchasedOrderProdecer(object lockObject)
        {
            this.lockObject = lockObject;
            this.ordersQueue = new Queue<PurchasedOrder>();
        }

        public void Produce()
        {
            while (true)
            {
                var newOrder = this.GenerateOrder();
                lock (this.lockObject)
                {
                    this.ordersQueue.Enqueue(newOrder);
                }
            }
        }

        private PurchasedOrder GenerateOrder()
        {
            Random rnd = new Random();
            var itemNum = rnd.Next(1, 1000);
            return new PurchasedOrder { ItemId = itemNum, ItemName = $"ItemName{itemNum}", DeliveryAddress = $"Address{itemNum}" };
        }

        public IEnumerable<PurchasedOrder> GetOrders()
        {
            return this.ordersQueue;
        }
    }
}
