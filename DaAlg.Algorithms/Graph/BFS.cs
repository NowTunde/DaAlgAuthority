using System;
using DaAlg.Algorithms.Models;

namespace DaAlg.Algorithms.Graph
{
    public class BFS
    {
        private LinkedList<int> _path;
        private bool[] _marked;
        private int?[] _parents;

        public BFS(int edgeCount, int verticesCount = 0)
        {
            _marked = new bool[edgeCount];
            _parents = new int?[verticesCount];
            _path = new LinkedList<int>();
        }

        public void Execute(AdjUndirectedGraph<int> adj, int vertex)
        {
            Queue<int> bfsQueue = new Queue<int>();
            bfsQueue.Enqueue(vertex);

            while (bfsQueue.Count > 0)
            {
                var curNode = bfsQueue.Dequeue();
                _marked[curNode] = true;
                _path.AddLast(curNode);

                foreach (var node in adj.Graph[curNode].Neighbors)
                {
                    if (!_marked[node.Y.Value])
                    {
                        bfsQueue.Enqueue(node.Y.Value);
                        _marked[node.Y.Value] = true;
                        _parents[node.Y.Value] = curNode;
                    }

                }

            }
        }

        public int?[] GetParent()
        {
            return _parents;
        }

        public int[] GetPath()
        {
            return _path.ToArray();
        }


    }
}

