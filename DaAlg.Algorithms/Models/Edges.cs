
using System;
namespace DaAlg.Algorithms.Models
{
    public class Edges<T> 
    {
        
        public LinkedList<Edge<T>>? Neighbors;

        public Edges()
        {
        }

        //public Edges(int x, int y, T? weight)
        //{
        //    if(Neighbors == null)
        //    {
        //        Neighbors = new LinkedList<Edge<T>>();
        //    }

        //    Neighbors.AddLast(new Edge<T>
        //    {
        //        X = x,
        //        Y = y,
        //        Weight = weight
        //    });
        //}
    }
}

