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

                // manage the queue
                ManageQueue();
            }
        }

        /// <summary>
        /// Process the document
        /// </summary>
        /// <param name="docName">The doc name to process</param>
        private static void ManageQueue()
        {
            // no item in queue or is still in process
            if (documentQueue.Count == 0 || docIsProcessing)
            {
                return;
            }

            // get current element
            var curElement = documentQueue.Dequeue();

            ProcessDoc(curElement);
        }

        /// <summary>
        /// Process the document
        /// </summary>
        /// <param name="docName">The doc name</param>
        private static void ProcessDoc(string docName)
        {
            // doc processing started
            docIsProcessing = true;

            var random = new Random();
            int timeMS = random.Next(5000, 10000);

            // set delay for processing
            Task.Delay(timeMS).ContinueWith(t => OnProcessDocComplete(docName, timeMS / 1000f));
        }

        /// <summary>
        /// Work after doc processing is complete
        /// </summary>
        /// <param name="curDocument">The current document</param>
        /// <param name="timeSeconds">The time doc processed</param>
        private static void OnProcessDocComplete(string curDocument, float timeSeconds)
        {
            // processing is complete
            docIsProcessing = false;

            Console.WriteLine($"Processing of \"{curDocument}\" took {timeSeconds} seconds.");

            // process next doc
            ManageQueue();
        }
    }
}
