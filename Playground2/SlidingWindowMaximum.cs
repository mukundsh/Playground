using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2
{
    public static class SlidingWindowMaximum
    {
        // C# implementation of http://articles.leetcode.com/2011/01/sliding-window-maximum.html
        public static IEnumerable<int> GetSlidingWindowMaximum(int[] arr, int windowSize)
        {
            KvpComparer comparer = new KvpComparer();
            MaxHeap<KeyValuePair<int, int>> maxHeap = new MaxHeap<KeyValuePair<int, int>>(comparer);

            for (int i = 0; i < windowSize; i++)
            {
                maxHeap.Add(new KeyValuePair<int, int>(arr[i], i));
            }

            for(int i = windowSize; i < arr.Length; i++)
            {
                var top = maxHeap.Peek();
                yield return top.Key;

                while(top.Value <= i - windowSize)
                {
                    maxHeap.ExtractDominating();
                    top = maxHeap.Peek();
                }

                maxHeap.Add(new KeyValuePair<int, int>(arr[i], i));
            }

            yield return maxHeap.ExtractDominating().Key;
        }
    }

    public class KvpComparer : Comparer<KeyValuePair<int, int>>
    {
        public override int Compare(KeyValuePair<int, int> x, KeyValuePair<int, int> y)
        {
            return x.Key.CompareTo(y.Key);
        }
    }
}
