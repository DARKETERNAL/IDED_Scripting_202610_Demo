namespace IDED_Scripting_202610_Demo
{
    public class DataStructureTest
    {
        public static string FindInQueue(Queue<string> queue, string expectedValue)
        {
            string result = null;
            bool foundString = false;

            while (!foundString && queue.Count > 0)
            {
                foundString = queue.Peek().Equals(expectedValue);

                if (foundString)
                {
                    result = queue.Peek();
                }
                else
                {
                    queue.Dequeue();
                }
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            Console.WriteLine($"Queue elements:{queue.Count}");

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            Console.WriteLine($"Queue elements:{queue.Count}");

            //Console.WriteLine(queue.Peek());

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //    Console.WriteLine($"Queue elements:{queue.Count}");
            //}

            //for (int i = 0; i < queue.Count;)
            //for (int i = queue.Count; i > 0; i = queue.Count)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //    Console.WriteLine($"Queue elements:{queue.Count}");
            //}

            //do
            //{
            //    Console.WriteLine(queue.Dequeue());
            //    Console.WriteLine($"Queue elements:{queue.Count}");
            //}
            //while (queue.Count > 0);

            //int count = queue.Count;

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine(queue.Dequeue());
            //    Console.WriteLine($"Queue elements:{queue.Count}");
            //}

            string expectedValue = "Fourth";
            string result = FindInQueue(queue, expectedValue);

            if (string.IsNullOrEmpty(result))
            {
                result = "Not found";
            }

            Console.WriteLine($"Expected value: {expectedValue}, Result: {result}");
        }
    }
}