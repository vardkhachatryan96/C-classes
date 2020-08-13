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
    }
}