using System;
namespace DaAlg.Algorithms.Models
{
    public class Edge<T> : IComparer<T>
    {
        public int? X { get; set; }
        public int? Y { get; set; }
        public T? Weight { get; set; }

        public int Compare(T? x, T? y)
        {
            return Comparer<T>.Default.Compare(x, y);
        }

        public int? Other(int value)
        {
            if (value == X)
            {
                return Y;
            }
            else if (value == Y)
            {
                return X;
            }

            throw new ArgumentException("Argument null exception");
        }
    }
}

