using Lesson7.DAL.Models;
using System.Collections.Generic;

namespace Lesson7
{
    class PurchasedOrdersProducer
    {
        readonly object lockObject;
        private readonly IEnumerable<PurchasedOrder> orders;
        private readonly Queue<PurchasedOrder> ordersQueue;

        public PurchasedOrdersProducer(IEnumerable<PurchasedOrder> orders, object lockObject)
        {
            this.lockObject = lockObject;
            this.ordersQueue = new Queue<PurchasedOrder>();
            this.orders = orders;
        }

        public void Produce()
        {
            foreach (var order in this.orders)
            {
                lock (lockObject)
                {
                    this.ordersQueue.Enqueue(order);
                }
            }
        }

        public Queue<PurchasedOrder> GetOrdersQueue()
        {
            return this.ordersQueue;
        }
    }
}
