using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2
{
    public static class ArrayProblems
    {
        /* 
         * http://www.geeksforgeeks.org/makemytrip-interview-experience-set-4/
         * Q1. Given a stream of around billion numbers in an array, which has approximately only 1000 unique numbers. Print the unique numbers. Complexity should be less than O(n).
Eg:
Input: 1,1,1,1,….2,2,2,…3,4,4,4,4……1111,1111,………..
Output : 1,2,3,4,1111
         */
        public static List<int> FindUniqueElementsFromSortedArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
            {
                return null;
            }

            List<int> result = new List<int>();

            int current = arr[0];
            int currentIndex = 0;

            while (true)
            {
                int index = FindLastIndexOfElement(arr, current, currentIndex, arr.Length - 1);
                Console.WriteLine("Last index of {0} is {1}", current, index);
                result.Add(current);
                if (index == arr.Length - 1)
                {
                    break;
                }

                current = arr[index + 1];
                currentIndex = index + 1;
            }

            return result;
        }

        private static int FindLastIndexOfElement(int[] arr, int key, int lo, int hi)
        {
            int mid = (lo + hi) / 2;

            if (arr[mid] == key)
            {
                if (mid + 1 < hi)
                {
                    if (arr[mid + 1] != key)
                    {
                        return mid + 1;
                    }

                    return FindLastIndexOfElement(arr, key, mid + 1, hi);
                }

                return mid;
            }
            else if (key < arr[mid])
            {
                return FindLastIndexOfElement(arr, key, lo, mid);
            }
            else
            {
                return FindLastIndexOfElement(arr, key, lo, mid);
            }
        }
    }
}
