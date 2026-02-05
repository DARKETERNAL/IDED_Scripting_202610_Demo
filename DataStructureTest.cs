namespace IDED_Scripting_202610_Demo
{
    public class DataStructureTest
    {
        public static void Main(string[] args)
        {
            int[] numbers = [-18, 422, 37, 14, 50]; // Hypothetical array literal syntax in C# 13.0
            ////int sum = numbers.Length;

            //int[] numbersB = new int[5];
            ////int[] numberB = new int[5] { -18, 422, 37, 14, 50 };

            List<int> numberList = new() { -18, 422, 37, 14, 50 };
            List<int> numberListB = new(); //5? //0?
            List<int> numberListC = new List<int>(5); // 5

            //Console.WriteLine($"numberList[3]:{numberList[3]}");

            PrintListElements(numberListB);
            Console.WriteLine("----");
            numberListB.Add(54762398);
            Console.WriteLine("----");
            PrintListElements(numberListB);

            Console.WriteLine("----");
            Console.WriteLine("----");

            PrintListElements(numberList);
            Console.WriteLine("----");
            numberList.RemoveAt(2);
            Console.WriteLine("----");
            PrintListElements(numberList);

            Console.WriteLine("----");
            numberList.Insert(4, 123456);
            Console.WriteLine("----");
            PrintListElements(numberList);

            Console.WriteLine("----");
            numberList.Add(987654);
            Console.WriteLine("----");
            PrintListElements(numberList);

            Console.WriteLine("----");
            numberList[1] = 0;
            Console.WriteLine("----");
            PrintListElements(numberList);

            Console.WriteLine("----");

            for (int i = 0; i < 200; i++)
            {
                numberListC.Add(i * 111);
            }

            Console.WriteLine("----");
            PrintListElements(numberListC);
        }

        private static int PrintListElements(List<int> list)
        {
            int index = 0;

            while (index < list.Count)
            {
                Console.WriteLine($"numberList[{index}]:{list[index]}");
                index++;
            }

            return index;
        }
    }
}