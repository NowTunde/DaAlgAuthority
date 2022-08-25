// See https://aka.ms/new-console-template for more information
using System.Linq;
using DaAlg.Algorithms.Graph;
using DaAlg.Algorithms.Models;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");

//var g = new AdjUndirectedGraph<int>(4);

//g.AddEdge(0, 1, 0);
//g.AddEdge(0, 2, 0);
//g.AddEdge(1, 2, 0);
//g.AddEdge(2, 0, 0);
//g.AddEdge(2, 3, 0);
//g.AddEdge(3, 3, 0);

//Console.WriteLine(
//            "Following is Depth First Traversal "
//            + "(starting from vertex 2)");

//var dfs = new DFS(g, 2);
//dfs.Execute(2);
//var dfsPath = dfs.GetPath();

//for(int i=0; i < dfsPath.Length; i++)
//{
//    Console.WriteLine(dfsPath[i]);
//}


//===============================  BFS ===============================
//Create the graph
var g = new AdjUndirectedGraph<int>(4);

g.AddEdge(0, 1, 0);
g.AddEdge(0, 2, 0);
g.AddEdge(1, 2, 0);
g.AddEdge(2, 0, 0);
g.AddEdge(2, 3, 0);
g.AddEdge(3, 3, 0);

var BFS = new BFS(4, g.VerticesCount);
BFS.Execute(g, 2);

var bfsPath = BFS.GetPath();

Console.WriteLine(
            "Following is Depth First Traversal "
            + "(starting from vertex 2)");

for (int i = 0; i < bfsPath.Length; i++)
{
    Console.WriteLine(bfsPath[i]);
}

Console.ReadKey();

//2013