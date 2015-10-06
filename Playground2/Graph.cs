using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground2
{
    public interface IGraph<TVertex>
    {
        bool Contains(TVertex vertex);
        IEnumerable<TVertex> GetAdjacent(TVertex vertex);
    }

    public class Graph<TVertex> : IGraph<TVertex>
    {
        private readonly Dictionary<TVertex, List<TVertex>> _edges;

        public Graph(params Tuple<TVertex, TVertex>[] directEdges)
        {
            _edges = directEdges
                .GroupBy(tuple => tuple.Item1, tuple => tuple.Item2)
                .ToDictionary(g => g.Key, g => g.ToList());

            //Adding vertices that are used as a target to the list of available vertices
            foreach (var missingVertex in directEdges
                .Where(tuple => !_edges.ContainsKey(tuple.Item2))
                .Select(tuple => tuple.Item2))
            {
                _edges[missingVertex] = new List<TVertex>();
            }
        }

        public bool Contains(TVertex vertex)
        {
            return _edges.ContainsKey(vertex);
        }

        public IEnumerable<TVertex> GetAdjacent(TVertex vertex)
        {
            List<TVertex> adjacentVertices;
            return _edges.TryGetValue(vertex, out adjacentVertices) ? adjacentVertices : Enumerable.Empty<TVertex>();
        }
    }

    public class BreadthFirstSearch<TVertex>
    {
        private readonly IGraph<TVertex> _graph;

        public BreadthFirstSearch(IGraph<TVertex> graph)
        {
            _graph = graph;
        }

        public IEnumerable<TVertex> GetAllReachableVertices(TVertex startingVertex)
        {
            HashSet<TVertex> visited = new HashSet<TVertex> { startingVertex };
            Queue<TVertex> horizon = new Queue<TVertex>();
            horizon.Enqueue(startingVertex);

            while (horizon.Count > 0)
            {
                var nextVertexToExpand = horizon.Dequeue();
                yield return nextVertexToExpand;

                foreach (var vertex in _graph.GetAdjacent(nextVertexToExpand).Where(vertex => !visited.Contains(vertex)))
                {
                    visited.Add(vertex);
                    horizon.Enqueue(vertex);
                }
            }
        }
    }
}
