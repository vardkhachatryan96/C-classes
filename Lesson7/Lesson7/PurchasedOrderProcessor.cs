using Lesson7.DAL.Models;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Lesson7
{
    class PurchasedOrderProcessor
    {
        readonly object lockObject;

        private readonly Queue<PurchasedOrder> ordersQueue;

        public PurchasedOrderProcessor(Queue<PurchasedOrder> ordersQueue, object lockObject)
        {
            this.ordersQueue = ordersQueue;
            this.lockObject = lockObject;
        }

        public void ProcessItem()
        {
            while (true)
            {
                PurchasedOrder order;
                if (ordersQueue.Count == 0)
                {
                    break;
                }
                lock (lockObject)
                {
                    order = ordersQueue.Dequeue();
                }
                Console.WriteLine($"Processing item: {order.ItemName}");
                this.FindItem(order);
                this.PackItem(order);
                this.ShipItem(order);
            }
        }

        private void FindItem(PurchasedOrder order)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Item found {order.ItemName}.");
        }

        private void PackItem(PurchasedOrder order)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Item packed {order.ItemName}.");
        }

        private void ShipItem(PurchasedOrder order)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Item shiped {order.ItemName}.");
        }
    }
}
