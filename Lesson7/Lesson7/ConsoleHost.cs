using Lesson7.DAL.Models;
using Lesson7.Extend;
using System.Collections.Generic;
using System.Threading;

namespace Lesson7
{
    internal class ConsoleHost
    {
        internal void Run()
        {
            var orders1 = this.GetPurchases1(); 
            var orders2 = this.GetPurchases2();
            var orders3 = this.GetPurchases3();

            object lockObject = new object();
            var orderProducer1 = new PurchasedOrdersProducer(lockObject);
            var orderProducer2 = new PurchasedOrdersProducer(lockObject);
            var orderProducer3 = new PurchasedOrdersProducer(lockObject);

            var orderProcessor1 = new PurchasedOrderProcessor(orderProducer1.GetOrdersQueue().As<Queue<PurchasedOrder>>(), lockObject);
            var orderProcessor2 = new PurchasedOrderProcessor(orderProducer2.GetOrdersQueue().As<Queue<PurchasedOrder>>(), lockObject);
            var orderProcessor3 = new PurchasedOrderProcessor(orderProducer3.GetOrdersQueue().As<Queue<PurchasedOrder>>(), lockObject);

            Thread orderProducerThread1 = new Thread(orderProducer1.Produce);
            Thread orderProducerThread2 = new Thread(orderProducer2.Produce);
            Thread orderProducerThread3 = new Thread(orderProducer3.Produce);
            orderProducerThread1.Start();
            orderProducerThread2.Start();
            orderProducerThread3.Start();
            
            Thread orderProcessorThread1 = new Thread(orderProcessor1.ProcessItem);
            Thread orderProcessorThread2 = new Thread(orderProcessor2.ProcessItem);
            Thread orderProcessorThread3 = new Thread(orderProcessor3.ProcessItem);
            orderProcessorThread1.Start();
            orderProcessorThread2.Start();
            orderProcessorThread3.Start();
        }

        private List<PurchasedOrder> GetPurchases1()
        {
            return new List<PurchasedOrder>()
            {
                new PurchasedOrder { ItemId = 1, ItemName = "Item1", Count = 2, DeliveryAddress = "Address1" },
                new PurchasedOrder { ItemId = 2, ItemName = "Item2", Count = 3, DeliveryAddress = "Address2" },
                new PurchasedOrder { ItemId = 3, ItemName = "Item3", Count = 2, DeliveryAddress = "Address3" },
            };
        }

        private List<PurchasedOrder> GetPurchases2()
        {
            return new List<PurchasedOrder>()
            {
                new PurchasedOrder { ItemId = 4, ItemName = "Item4", Count = 1, DeliveryAddress = "Address3" },
                new PurchasedOrder { ItemId = 5, ItemName = "Item5", Count = 1, DeliveryAddress = "Address4" },
                new PurchasedOrder { ItemId = 6, ItemName = "Item6", Count = 5, DeliveryAddress = "Address5" }
            };
        }

        private List<PurchasedOrder> GetPurchases3()
        {
            return new List<PurchasedOrder>()
            {
                new PurchasedOrder { ItemId = 7, ItemName = "Item7", Count = 1, DeliveryAddress = "Address7" },
                new PurchasedOrder { ItemId = 8, ItemName = "Item8", Count = 1, DeliveryAddress = "Address8" },
                new PurchasedOrder { ItemId = 9, ItemName = "Item9", Count = 5, DeliveryAddress = "Address9" }
            };
        }
    }
}