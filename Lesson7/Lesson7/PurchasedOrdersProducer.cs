using Lesson7.DAL.Models;
using System.Collections.Generic;
using System.Threading;

namespace Lesson7
{
    class PurchasedOrdersProducer
    {
        readonly object lockObject;
        private readonly Queue<PurchasedOrder> ordersQueue;
        private static int itemNum;

        public PurchasedOrdersProducer(object lockObject)
        {
            this.lockObject = lockObject;
            this.ordersQueue = new Queue<PurchasedOrder>();
        }

        public void Produce()
        {
            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    var newOrder = this.GenerateOrder(itemNum++);
                    lock (lockObject)
                    {
                        this.ordersQueue.Enqueue(newOrder);
                    }
                }
                Thread.Sleep(5000);
            }
        }

        private PurchasedOrder GenerateOrder(int orderNum)
        {
            return new PurchasedOrder { ItemId = orderNum, ItemName = $"Item{orderNum}", Count = 2, DeliveryAddress = $"Address{orderNum}" };
        }

        public IEnumerable<PurchasedOrder> GetOrdersQueue()
        {
            return this.ordersQueue;
        }
    }
}
