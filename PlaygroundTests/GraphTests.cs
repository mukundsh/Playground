using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Playground2;

namespace PlaygroundTests
{
    [TestClass]
    public class GraphTests
    {
        [TestMethod]
        public void CanDoBFS()
        {
            var graph = new Graph<int>(
            Tuple.Create(2, 7),
            Tuple.Create(7, 4),
            Tuple.Create(4, 6),
            Tuple.Create(8, 3),
            Tuple.Create(6, 2));

            var breadthFirstSearch = new BreadthFirstSearch<int>(graph);

            foreach (var vertex in breadthFirstSearch.GetAllReachableVertices(4))
            {
                Console.WriteLine("Next vertex is {0}", vertex);
            }
        }
    }
}
