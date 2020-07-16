using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Collections.Queue
{
    /// <summary>
    /// Queue Demo model
    /// </summary>
    public class QueueDemo
    {
        private static readonly Queue<string> documentQueue = new Queue<string>();
        private static bool docIsProcessing;

        /// <summary>
        /// Run Queue Collection demo
        /// </summary>
        public static void Run()
        {
            while (true)
            {
                // get doc name
                var inputDocName = Console.ReadLine();

                if (inputDocName.Equals("q"))
                {
                    break;
                }

                documentQueue.Enqueue(inputDocName);

                MangeQueue();
            }
        }

        private static void MangeQueue()
        {
            if (documentQueue.Count == 0 || docIsProcessing)
            {
                return;
            }

            var currentDoc = documentQueue.Dequeue();

            docIsProcessing = true;
            ProcessDoc(currentDoc);
        }

        private static void ProcessDoc(string currentDoc)
        {
            var random = new Random();
            int timeMS = random.Next(5000, 10000);

            // set delay for processing
            Task.Delay(timeMS).ContinueWith(t => OnProcessDocComplete(currentDoc, timeMS / 1000f));
        }

        private static void OnProcessDocComplete(object docName, float time)
        {
            docIsProcessing = false;
            Console.WriteLine($"Processing of \"{docName}\" took {time} seconds");

            MangeQueue();
        }
    }
}
