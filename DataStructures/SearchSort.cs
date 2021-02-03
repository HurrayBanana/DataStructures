using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class SearchSort
    {
        /// <summary>
        /// Displays an a array in a simple fashion
        /// </summary>
        /// <param name="list">array to show</param>
        /// <param name="mess">prefix message to display</param>
        public static void ShowArray(int[] list, string mess)
        {
            Console.WriteLine(mess);
            for (int i = 0; i < list.Length; i++)
                Console.Write(list[i] + " ");
            Console.WriteLine();
        }
        /// <summary>
        /// bubble sorts the provided list
        /// </summary>
        /// <param name="list">array to sort</param>
        public static void Bubble(int[] list)
        {
            bool swapped = true;
            int processLength = list.Length - 1;
            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < processLength; i++)
                {
                    //is left item bigger than right
                    if (list[i] > list[i + 1])
                    {
                        swapped = true;
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
                //decrease length of list as each subsequent 
                //value is placed correctly at the right
                processLength--;
            }
        }
        /// <summary>
        /// Performs bubble sort but using a do while mechanism
        /// as we have to make at least 1 pass through the list
        /// </summary>
        /// <param name="list"></param>
        public static void BubbleDoWhile(int[] list)
        {
            bool swapped;
            int processLength = list.Length - 1;
            do
            {
                swapped = false;

                for (int i = 0; i < processLength; i++)
                {
                    //is left item bigger than right
                    if (list[i] > list[i + 1])
                    {
                        swapped = true;
                        int temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                    }
                }
                //decrease length of list as each subsequent 
                //value is placed correctly at the right
                processLength--;
            } while (swapped);
        }
        /// <summary>
        /// Performs an insertion sort on the array
        /// </summary>
        /// <param name="list">the array to sort</param>
        public static void Insertion(int[] list)
        {
            //examine each key
            for (int keyposition = 1; keyposition < list.Length; keyposition++)
            {
                int keyValue = list[keyposition];
                int insertPosition = keyposition - 1;

                //search for insert point
                while (insertPosition >= 0 && list[insertPosition] > keyValue)
                {
                    //shuffle item to the right
                    list[insertPosition + 1] = list[insertPosition];
                    //move backwards through the search
                    insertPosition--;
                }
                //insert point to the right of current position
                list[insertPosition + 1] = keyValue;
            }
        }


        /// <summary>
        /// Attempts a linear search on the specified items
        /// </summary>
        /// <param name="list">unordered array of integers</param>
        /// <param name="item">search value</param>
        /// <returns>either index item was found, or -1 if not found </returns>
        public static int Linear(int[] list, int item)
        {
            int i = 0;
            int length = list.Length;

            while (i < length)
            {
                if (list[i] == item)
                    return i;
                i++;
            }
            //exhausted array not found
            return -1;
        }
    }
}
