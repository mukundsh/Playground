using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2
{
    public static class StringProblems
    {
        public static IEnumerable<string> GetAllAnagramsOfString(string input)
        {
            char[] inputChars = input.ToCharArray();
            Array.Sort(inputChars);
            input = new string(inputChars);
            Console.WriteLine(input);
            yield return input;
            while (true)
            {
                input = GetNextPermutation(inputChars);
                if (input == null)
                {
                    yield break;
                }

                yield return input;
            }
        }

        // http://stackoverflow.com/questions/1622532/algorithm-to-find-next-greater-permutation-of-a-given-string
        private static string GetNextPermutation(char[] input)
        {
            int i = input.Length - 1;
            while(i > 0 && input[i] <= input[i - 1])
            {
                i--;
            }

            if (i == 0)
            {
                return null;
            }

            int j = input.Length - 1;
            while(input[j] <= input[i -1])
            {
                j--;
            }

            Swap(input, i -1, j);
            
            j = input.Length - 1;
            var temp = input[i - 1];
            while (i < j)
            {
                temp = input[i];
                input[i] = input[j];
                input[j] = temp;
                i++;
                j--;
            }

            string nextPermutation = new string(input);
            Console.WriteLine(nextPermutation);
            return nextPermutation;
        }

        private static void Swap(char[] input, int i, int j)
        {
            char temp = input[i];
            input[i] = input[j];
            input[j] = temp;
        }

        public static void Quicksort(IComparable[] arr)
        {
            Quicksort(arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
