using Lesson7.DAL;
using Lesson7.DAL.Models;
using Lesson7.Extend;
using OnlineStore.DAL.Data;
using System;
using System.Threading;

namespace Lesson7
{
    internal class ConsoleHost
    {
        private readonly PurchasedOrdersRepository _purchasedOrdersRepository;

        public ConsoleHost()
        {
            this._purchasedOrdersRepository = new PurchasedOrdersRepository();
        }

        internal void Run()
        {
            // init some data
            DataSeeder.Initialize();

            var allOrders = this._purchasedOrdersRepository.GetAllPurchases();

            foreach (var order in allOrders)
            {
                Thread t = new Thread(new ParameterizedThreadStart(ProcessItem));
                t.Start(order);
            }
        }

        public void ProcessItem(object order)
        {
            this.FindItem(order.As<PurchasedOrder>());
            this.PackItem(order.As<PurchasedOrder>());
            this.ShipItem(order.As<PurchasedOrder>());
        }

        public void FindItem(PurchasedOrder order)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Item found {order.ItemName}.");
        }

        public void PackItem(PurchasedOrder order)
        {
            Thread.Sleep(1000);
            Console.WriteLine($"Item packed {order.ItemName}.");
        }

        public void ShipItem(PurchasedOrder order)
        {
            Thread.Sleep(2000);
            Console.WriteLine($"Item shiped {order.ItemName}.");
        }
    }
}