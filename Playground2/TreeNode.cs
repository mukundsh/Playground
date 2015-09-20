namespace Playground2
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;

    [DebuggerDisplay("data={Data}")]
    public class TreeNode
    {
        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }

        public int Data { get; set; }

        public TreeNode(int data)
        {
            this.Left = null;
            this.Right = null;
            this.Data = data;
        }

        public static bool DoesPathWithHeightKExist(TreeNode root, int k)
        {
            if (k < 0)
            {
                return false;
            }

            if (root == null)
            {
                return false;
            }

            if ((root.Left == null && root.Right == null) && k == 0)
            {
                return true;
            }

            return DoesPathWithHeightKExist(root.Left, k - 1) || DoesPathWithHeightKExist(root.Right, k - 1);
        }

        public static void PrintRightViewOfTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Dictionary<int, TreeNode> levelToTreeNodeMap = new Dictionary<int, TreeNode>();
            levelToTreeNodeMap.Add(0, root);
            PrintRightViewOfTree(root, levelToTreeNodeMap, 0);

            foreach (KeyValuePair<int, TreeNode> keyValuePair in levelToTreeNodeMap)
            {
                Console.WriteLine("{0} : {1}", keyValuePair.Key, keyValuePair.Value.Data);
            }
        }

        private static void PrintRightViewOfTree(TreeNode root, Dictionary<int, TreeNode> levelToTreeNodeMap, int level)
        {
            if (root == null)
            {
                return;
            }

            if (root.Right != null)
            {
                if (!levelToTreeNodeMap.ContainsKey(level + 1))
                {
                    levelToTreeNodeMap[level + 1] = root.Right;
                }

                PrintRightViewOfTree(root.Right, levelToTreeNodeMap, level + 1);
            }

            if (root.Left != null)
            {
                if (!levelToTreeNodeMap.ContainsKey(level + 1))
                {
                    levelToTreeNodeMap[level + 1] = root.Left;
                }

                PrintRightViewOfTree(root.Left, levelToTreeNodeMap, level + 1);
            }
        }


        /* http://www.geeksforgeeks.org/amazon-interview-questions-set-147/ 
         * Given a sorted array.Make a balanced binary tree from this array.
         */
        public static TreeNode BuildBalancedTreeFromSortedArray(int[] arr)
        {
            return BuildBalancedTreeFromSortedArray(arr, 0, arr.Length - 1);
        }

        public static TreeNode BuildBalancedTreeFromSortedArray(int[] arr, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return null;
            }

            int mid = (startIndex + endIndex) / 2;
            TreeNode root = new TreeNode(arr[mid]);
            root.Left = BuildBalancedTreeFromSortedArray(arr, startIndex, mid - 1);
            root.Right = BuildBalancedTreeFromSortedArray(arr, mid + 1, endIndex);
            return root;
        }

        public static List<TreeNode> GetTreeNodesAtKthLevel(TreeNode root, int k)
        {
            Dictionary<int, List<TreeNode>> levelToNodesLookup = new Dictionary<int, List<TreeNode>>();
            return null;
        }

        public static List<TreeNode> GetTreeNodesAtKthLevel2(TreeNode root, int k)
        {
            List<TreeNode> result = new List<TreeNode>();

            Queue<TreeNode> oddLevelNodes = new Queue<TreeNode>();

            Queue<TreeNode> evenLevelNodes = new Queue<TreeNode>();

            if (root == null)
            {
                return null;
            }

            if (k == 0)
            {
                result.Add(root);
                return result;
            }

            if (root.Left != null)
            {
                oddLevelNodes.Enqueue(root.Left);
            }

            if (root.Right != null)
            {
                oddLevelNodes.Enqueue(root.Right);
            }

            int currentLevel = 1;
            while (currentLevel < k)
            {
                bool isCurrentLevelOdd = currentLevel % 2 != 1;
                if (isCurrentLevelOdd)
                {
                    while (evenLevelNodes.Count != 0)
                    {
                        var node = evenLevelNodes.Dequeue();
                        if (node.Left != null)
                        {
                            oddLevelNodes.Enqueue(node.Left);
                        }

                        if (node.Right != null)
                        {
                            oddLevelNodes.Enqueue(node.Right);
                        }
                    }
                }
                else
                {
                    while (oddLevelNodes.Count != 0)
                    {
                        var node = oddLevelNodes.Dequeue();
                        if (node.Left != null)
                        {
                            evenLevelNodes.Enqueue(node.Left);
                        }

                        if (node.Right != null)
                        {
                            evenLevelNodes.Enqueue(node.Right);
                        }
                    }
                }

                currentLevel++;
            }

            if (k % 2 == 0)
            {
                return evenLevelNodes.ToArray().ToList();
            }

            return oddLevelNodes.ToArray().ToList();
        }

        public static void PrintVertically(TreeNode root)
        {
            Dictionary<int, List<TreeNode>> distanceToNodesLookup = new Dictionary<int, List<TreeNode>>();

            InOrderTraversalVariant(root, distanceToNodesLookup, 0);

            List<TreeNode>[] array = distanceToNodesLookup.Values.ToArray();
            int[] keys = distanceToNodesLookup.Keys.ToArray();
            Array.Sort(keys, array);

            foreach (List<TreeNode> treeNodes in array)
            {
                Console.WriteLine(string.Join(" ", treeNodes.Select(s => s.Data)));
            }
        }

        private static void InOrderTraversalVariant(TreeNode root, Dictionary<int, List<TreeNode>> distanceToNodesLookup, int currentDistance)
        {
            if (root == null)
            {
                return;
            }

            if (!distanceToNodesLookup.ContainsKey(currentDistance))
            {
                distanceToNodesLookup[currentDistance] = new List<TreeNode>();
            }

            distanceToNodesLookup[currentDistance].Add(root);
            InOrderTraversalVariant(root.Left, distanceToNodesLookup, currentDistance - 1);
            InOrderTraversalVariant(root.Right, distanceToNodesLookup, currentDistance + 1);
        }
    }
}
