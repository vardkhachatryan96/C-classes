using Lesson7.DAL.Models;
using System.Collections.Generic;

namespace Lesson7
{
    class PurchasedOrdersProducer
    {
        private readonly IEnumerable<PurchasedOrder> orders;
        private readonly Queue<PurchasedOrder> ordersQueue;

        public PurchasedOrdersProducer(IEnumerable<PurchasedOrder> orders)
        {
            this.ordersQueue = new Queue<PurchasedOrder>();
            this.orders = orders;
        }

        public void Produce()
        {
            foreach (var order in this.orders)
            {
                this.ordersQueue.Enqueue(order);
            }
        }

        public Queue<PurchasedOrder> GetOrdersQueue()
        {
            return this.ordersQueue;
        }
    }
}
