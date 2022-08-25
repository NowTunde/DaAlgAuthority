using System;
using DaAlg.Algorithms.Models;

namespace DaAlg.Algorithms.Graph
{
    public class DFS
    {
        private AdjUndirectedGraph<int>? _adj;
        private readonly int _source;
        private bool[] _marked;
        private int?[] _parents;
        private LinkedList<int> _path;
        public DFS(AdjUndirectedGraph<int>? adj, int vertex)
        {
            _adj = adj;
            _source = vertex;
            _marked = new bool[adj.Graph.Length];
            _parents = new int?[adj.VerticesCount];
            _path = new LinkedList<int>();
        }

        public void Execute(int vertex)
        { 
            Visit(vertex);
        }

        public void Visit(int vertex)
        {
            _path.AddLast(vertex);
            _marked[vertex] = true;

            //always for each linked list.
            foreach(var node in _adj.Graph[vertex].Neighbors)
            {
                if (!_marked[node.Y.Value])
                {
                    _parents[node.Y.Value] = vertex;
                    Visit(node.Y.Value);
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

