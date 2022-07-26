using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Testing
{
    internal class Graphs
    {
        private int vertices;
        private int[,] adjMat; // 2D array

        public Graphs(int n) // number of vertices
        {
            vertices = n;
            adjMat = new int[n, n];  //[row,column]
        }

        public void InsertEdge(int u, int v, int w) // vertex, edge, weight
        {
            // we are assigning the cost of the edge in the cell for u,v 
            adjMat[u,v] = w; 
        }

        public void RemoveEdge(int u, int v)
        {
            // assigning the cost of the edge in the cell at row u, column v, to 0.
            adjMat[u,v] = 0;
        }

        public bool ExistEdge(int u, int v)
        {
            return adjMat[u,v] != 0;
        }

        public int VertexCount()
        {
            return vertices;
        }

        public int EdgeCount()
        {
            int count = 0;

            for (int i = 0; i < vertices; i++) // use for loop to traverse the rows.
            {
                for (int j = 0; j < vertices; j++) // using j forloop to traverse the columns
                {
                    if (adjMat[i,j] != 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public void Edges()
        {
            Console.WriteLine("Edges: ");

            for (int i = 0; i < vertices; i++) // rows
            {
                for (int j = 0; j < vertices; j++) // columns
                {
                    if (adjMat[i, j] != 0)
                    {
                        Console.WriteLine(i + "--" + j);
                    }
                }
            }
        }

        public int OutDegree(int v)
        {
            // checking how many OUT directions 'v' has.
            int count = 0;

            for (int j = 0; j < vertices; j++) // columns (the "row" has already been passed into this method as v) 
            {
                if (adjMat[v,j] != 0) // we're checking [v,j] -- the vertex "goes to" j
                {
                    count++;
                } 
            }

            return count;
        }

        public int InDegree(int v)
        {
            int count = 0;

            for (int i = 0; i < vertices; i++) // 
            {
                if (adjMat[i,v] != 0) // [i,v] because its IN. the edge (i) "goes to" v  i ---> v  --- v is the second number in the vertex because its on the receiving end.
                {
                    count++;
                }
            }

            return count;
        }

        public void Display()
        {
            for (int i = 0; i < vertices; i++) // rows
            {
                for (int j = 0; j < vertices; j++) // columns
                {
                    Console.Write(adjMat[i,j] + "\t");
                }

                Console.WriteLine(); // just used to output the values on different lines. 
            }
        }
        public void UndirectedGraph()
        {
            Graphs g = new Graphs(4);
            Console.WriteLine("Graphs Adjancy Matrix:");
            g.Display();
            Console.WriteLine($"Vertices: {g.VertexCount()}");
            Console.WriteLine($"Edges: {g.EdgeCount()}"); // at this point, the matrix ix empty and all 0's will display.

            // A --> B, B --> A
            g.InsertEdge(0, 1, 1); // row, column, weight (default 1 if this is a non-weighted graph).
            g.InsertEdge(1, 0, 1);

            // A --> C, C --> A
            g.InsertEdge(0, 2, 1);
            g.InsertEdge(2, 0, 1);

            // B --> C, C --> B
            g.InsertEdge(1, 2, 1);
            g.InsertEdge(2, 1, 1);

            // C --> D, D --> C
            g.InsertEdge(2, 3, 1);
            g.InsertEdge(3, 2, 1);
        }

        public void BreadthFirstSearch(int s) // s = the start vertex of BFS
        {
            int i = s; // temp variable.
            var q = new QueuesLinkedList();
            int[] visited = new int[vertices]; // creating a new array with the amount of vertices that are in our matrix.
            visited[i] = 1; // signifies that the vertice i is visited.
            q.Enqueue(i);

            while (!q.IsEmpty())
            {
                i = q.Dequeue(); // dequeue the vertice and store it in i.
                for (int j = 0; j < vertices; j++) // traverse the matrix n times (vertices = n) j = destination vertice.
                {
                    if (adjMat[i,j] == 1 && visited[j] == 0) // if there is an edge between i,j and it has not yet been visited
                    {
                        visited[j] = 1; // set the index of j in the visited array as visited. j represents the column / destination vertice
                        q.Enqueue(j); // we want to look at that destination vertice next/ add it into the queue 
                    }
                }
            }
        }

        public void DepthFirstSearch(int s)
        {
            int[] visited = new int[vertices]; // vertices (based on the index)

            if (visited[s] == 0)
            {
                visited[s] = 1; // mark this vertice as visited.

                for (int j = 0; j < vertices; j++) // checking the destination vertices / columns
                {
                    if (adjMat[s,j] == 1 && visited[j] == 0)
                    {
                        DepthFirstSearch(j); // if this cell exists, and it has NOT been visited yet, we are going to recursively call this method again using the 'destination' vertice.
                    }
                }
            }
        }
    }
}
