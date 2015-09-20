using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2
{
    [DebuggerDisplay("{Data}")]
    public class TreeNode2<T> where T : IComparable
    {
        public T Data { get; private set; }

        public TreeNode2<T> Right { get; set; }

        public TreeNode2<T> Left { get; set; }

        public TreeNode2(T data)
        {
            this.Data = data;
        }

        public void Insert(T data)
        {
            if (this.Data.CompareTo(data) > 0)
            {
                if (this.Left == null)
                {
                    this.Left = new TreeNode2<T>(data);
                    return;
                }

                this.Left.Insert(data);
                return;
            }

            if (this.Right == null)
            {
                this.Right = new TreeNode2<T>(data);
                return;
            }

            this.Right.Insert(data);
        }

        public void PrintTree()
        {
            Console.Write(this.Data.ToString() + " ");

            if (this.Left != null)
            {
                this.Left.PrintTree();
            }
            else
            {
                Console.Write("L ");
            }

            if (this.Right != null)
            {
                this.Right.PrintTree();
            }
            else
            {
                Console.Write("R ");
            }
        }

        public void PrintAllPaths()
        {
            Console.WriteLine();
            this.PrintAllPaths(this, new List<TreeNode2<T>>() { this });
        }

        private void PrintAllPaths(TreeNode2<T> root, List<TreeNode2<T>> elementsTillRoot)
        {
            if (root.Left == null && root.Right == null)
            {
                Console.WriteLine(string.Join(" ", elementsTillRoot.Select(it => it.Data.ToString())));
            }

            if (root.Left != null)
            {
                elementsTillRoot.Add(root.Left);
                PrintAllPaths(root.Left, elementsTillRoot);
                elementsTillRoot.Remove(root.Left);
            }

            if (root.Right != null)
            {
                elementsTillRoot.Add(root.Right);
                PrintAllPaths(root.Right, elementsTillRoot);
                elementsTillRoot.Remove(root.Right);
            }
        }
    }
}
