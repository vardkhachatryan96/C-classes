using System;
using System.Collections.Generic;
using System.Threading;

namespace Lesson7
{
    public class PurchasedOrderProcessor
    {
        private readonly Queue<PurchasedOrder> ordersQueue;
        private readonly object lockObject;

        public PurchasedOrderProcessor(Queue<PurchasedOrder> ordersQueu, object lockObject)
        {
            this.ordersQueue = ordersQueu;
            this.lockObject = lockObject;
        }

        public void ProcessItem()
        {
            while (true)
            {
                var order = default(PurchasedOrder);
                lock (this.lockObject)
                {
                    if (this.ordersQueue.Count > 0)
                    {
                        order = this.ordersQueue.Dequeue();
                    }
                }
                if (order != default)
                {
                    Console.WriteLine($"CurrentThreadId {Thread.CurrentThread.ManagedThreadId} Processing item {order.ItemName}");
                    this.FindItem(order);
                    this.PackItem(order);
                    this.ShipItem(order);
                }
            }
        }

        private void FindItem(PurchasedOrder order)
        {
            Thread.Sleep(200);
            Console.WriteLine($"Item found {order.ItemName}");
        }

        private void PackItem(PurchasedOrder order)
        {
            Thread.Sleep(100);
            Console.WriteLine($"Item packed {order.ItemName}");
        }

        private void ShipItem(PurchasedOrder order)
        {
            Thread.Sleep(200);
            Console.WriteLine($"Item shiped {order.ItemName}");
        }

    }
}
