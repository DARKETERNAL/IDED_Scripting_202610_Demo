namespace IDED_Scripting_202610_Demo
{
    public class DataStructureTest
    {
        public static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();

            Console.WriteLine($"Stack elements:{stack.Count}");

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            Console.WriteLine($"Stack elements:{stack.Count}");

            Console.WriteLine(stack.Peek());

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}