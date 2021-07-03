using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAlgorithms.Basic
{
    public class Graphs
    {
        int vertices;
        int[,] adjMat;
        int[] visited;

        public Graphs(int n)
        {
            vertices = n;
            adjMat = new int[n, n];
            visited = new int[vertices];
        }
        public void InsertEdge(int u, int v, int x)
        {
            adjMat[u, v] = x;
        }
        public void RemoveEdge(int u, int v)
        {
            adjMat[u, v] = 0;
        }
        public bool ExistEdge(int u, int v)
        {
            return adjMat[u, v] != 0;
        }
        public int VertexCount()
        {
            return vertices;
        }
        public int EdgeCount()
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjMat[i, j] != 0)
                        count = count + 1;
            }
            return count;
        }
        public void Edges()
        {
            Console.WriteLine("Edges:");
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    if (adjMat[i, j] != 0)
                        Console.WriteLine(i + "--" + j);
            }
        }
        public int Outdegree(int v)
        {
            int count = 0;
            for (int j = 0; j < vertices; j++)
                if (adjMat[v, j] != 0)
                    count = count + 1;
            return count;
        }
        public int Indegree(int v)
        {
            int count = 0;
            for (int i = 0; i < vertices; i++)
                if (adjMat[i, v] != 0)
                    count = count + 1;
            return count;
        }
        public void Display()
        {
            for (int i = 0; i < vertices; i++)
            {
                for (int j = 0; j < vertices; j++)
                    Console.Write(adjMat[i, j] + "\t");
                Console.WriteLine();
            }
        }
        public void BFS(int s)
        {
            int i = s;
            QueuesLinked q = new QueuesLinked();
            int[] visited = new int[vertices];
            Console.Write(i + " ");
            visited[i] = 1;
            q.enqueue(i);
            while (!q.isEmpty())
            {
                i = q.dequeue();
                for (int j = 0; j < vertices; j++)
                {
                    if (adjMat[i, j] == 1 && visited[j] == 0)
                    {
                        Console.Write(j + " ");
                        visited[j] = 1;
                        q.enqueue(j);
                    }
                }
            }
        }
        public void DFS(int s)
        {
            if (visited[s] == 0)
            {
                Console.Write(s + " ");
                visited[s] = 1;
                for (int j = 0; j < vertices; j++)
                    if (adjMat[s, j] == 1 && visited[j] == 0)
                        DFS(j);
            }
        }
        static void Test()
        {
            Graphs g = new Graphs(4);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.Display();
            Console.WriteLine("Vertices: " + g.VertexCount());
            Console.WriteLine("Edges Count: " + g.EdgeCount());
            g.InsertEdge(0, 1, 1);
            g.InsertEdge(0, 2, 1);
            g.InsertEdge(1, 0, 1);
            g.InsertEdge(1, 2, 1);
            g.InsertEdge(2, 0, 1);
            g.InsertEdge(2, 1, 1);
            g.InsertEdge(2, 3, 1);
            g.InsertEdge(3, 2, 1);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.Display();
            Console.WriteLine("Vertices: " + g.VertexCount());
            Console.WriteLine("Edges Count: " + g.EdgeCount());
            g.Edges();
            Console.WriteLine("Edge between 1--3: " + g.ExistEdge(1, 3));
            Console.WriteLine("Edge between 1--2: " + g.ExistEdge(1, 2));
            Console.WriteLine("Degree of Vertex 2: " + g.Indegree(2));
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.Display();
            g.RemoveEdge(1, 2);
            Console.WriteLine("Graphs Adjacency Matrix:");
            g.Display();
            Console.WriteLine("Edge between 1--2: " + g.ExistEdge(1, 2));
        }
    }
}
