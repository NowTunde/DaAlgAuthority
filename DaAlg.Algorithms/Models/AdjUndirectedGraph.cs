using System;
namespace DaAlg.Algorithms.Models
{
    public class AdjUndirectedGraph<T>
    {
        private readonly int _edgesCount;
        public Edges<T>[] Graph;
        public int VerticesCount;

        public AdjUndirectedGraph(int edgesCount)
        {
            _edgesCount = edgesCount;
            Graph = new Edges<T>[edgesCount];
        }

        public void AddEdge(int x, int y, T weight)
        {
            AddEdge(new Edge<T>
            {
                X = x,
                Y = y,
                Weight = weight
            });
        }

        public void AddEdge(Edge<T> edge)
        {
            if(edge == null)
            {
                return;
            }
            else if (Graph[edge.X.Value] == null)
            {
                Graph[edge.X.Value] = new Edges<T>();
                Graph[edge.X.Value].Neighbors = Graph[edge.X.Value].Neighbors ?? new LinkedList<Edge<T>>();
                AddEdgeHelper(edge);
            }
            else if(Graph[edge.X.Value].Neighbors == null)
            {
                Graph[edge.X.Value].Neighbors = new LinkedList<Edge<T>>();
                AddEdgeHelper(edge);
            }
            else
            {
                AddEdgeHelper(edge);
            }
        }

        private void AddEdgeHelper(Edge<T> edge)
        {
            Graph[edge.X.Value]?.Neighbors?.AddLast(new Edge<T>
            {
                X = edge.X.Value,
                Y = edge.Y.Value,
                Weight = edge.Weight
            });
            VerticesCount += 1;
        }
    }
}

