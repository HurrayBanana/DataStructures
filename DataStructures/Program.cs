using System;

namespace DataStructures
{
    
    class Program
    {
        static void Main(string[] args)
        {
            TestBubbleDoWhile();
            TestBubble();
            TestLinearSearch();

        }

        private static void TestLinearSearch()
        {
            Console.WriteLine("Test Linear Search");
            int[] nums = { 12, 10, 6, 9, 7, 1, 3, 2 };

            int index = SearchSort.Linear(nums, 67);

            if (index == -1)
                Console.WriteLine("Item does not exist");
            else
                Console.WriteLine("Item " + 67 + " was found at index " + index);

            index = SearchSort.Linear(nums, 10);

            if (index == -1)
                Console.WriteLine("Item does not exist");
            else
                Console.WriteLine("Item " + 10 + " was found at index " + index);
        }

        private static void TestBubbleDoWhile()
        {
            Console.WriteLine("Test Bubble sort do while version");

            int[] nums = { 12, 10, 6, 9, 7, 1, 3, 2 };
            SearchSort.ShowArray(nums, "Unsorted array");
            SearchSort.BubbleDoWhile(nums);
            //SearchSort.Insertion(nums);
            SearchSort.ShowArray(nums, "Hopefully sorted");
        }
        private static void TestBubble()
        {
            Console.WriteLine("Test Bubble Sort");

            int[] nums = { 12, 10, 6, 9, 7, 1, 3, 2 };
            SearchSort.ShowArray(nums, "Unsorted array");
            SearchSort.BubbleDoWhile(nums);
            //SearchSort.Insertion(nums);
            SearchSort.ShowArray(nums, "Hopefully sorted");
        }




    }
}
