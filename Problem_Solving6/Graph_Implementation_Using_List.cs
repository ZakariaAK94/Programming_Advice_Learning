using System;
using System.Collections.Generic;

class Graph
{
    public enum enGraphDirectionType { Directed, unDirected }

    private Dictionary<string, List<Tuple<string, int>>> _adjacencyList;

    private Dictionary<string, int> _vertexDictionary;

    private int _numberOfVertices;

    private enGraphDirectionType _GraphDirectionType = enGraphDirectionType.unDirected;
    public Graph(List<string> vertices, enGraphDirectionType GraphDirectionType)
    {

        _GraphDirectionType = GraphDirectionType;
        _numberOfVertices = vertices.Count;
        _adjacencyList = new Dictionary<string, List<Tuple<string, int>>>();
        _vertexDictionary = new Dictionary<string, int>();

        for (int i = 0; i < vertices.Count; i++)
        {
            _vertexDictionary[vertices[i]] = i;
            _adjacencyList[vertices[i]] = new List<Tuple<string, int>>();
        }
    }


    
    public void AddEdge(string vertex, string destination, int weight)
    {
        
        if (_vertexDictionary.ContainsKey(vertex) && _vertexDictionary.ContainsKey(destination))
        {
            
            _adjacencyList[vertex].Add(new Tuple<string, int>(destination, weight));

            
            if (_GraphDirectionType == enGraphDirectionType.unDirected)
            {
                _adjacencyList[destination].Add(new Tuple<string, int>(vertex, weight));
            }
        }
        else
        {
            Console.WriteLine($"\n\nIgnored: Invalid vertices. {vertex} ==> {destination}\n\n");
        }
    }

    public void RemoveEdge(string vertex, string destination)
    {
       
        if (_vertexDictionary.ContainsKey(vertex) && _vertexDictionary.ContainsKey(destination))
        {
            
            _adjacencyList[vertex].RemoveAll(edge => edge.Item1 == destination);

            
            if (_GraphDirectionType == enGraphDirectionType.unDirected)
            {
                _adjacencyList[destination].RemoveAll(edge => edge.Item1 == vertex);
            }
        }
        else
        {
            
            Console.WriteLine("Invalid vertices.");
        }
    }

    
    public void DisplayGraph(string Message)
    {
        Console.WriteLine("\n" + Message + "\n");

        
        foreach (var vertex in _adjacencyList)
        {
            Console.Write(vertex.Key + " -> "); 

            
            foreach (var edge in vertex.Value)
            {
                Console.Write($"{edge.Item1}({edge.Item2}) ");  
            }
            Console.WriteLine();
        }
    }

   
    public bool IsEdge(string vertex, string destination)
    {
        
        if (_vertexDictionary.ContainsKey(vertex) && _vertexDictionary.ContainsKey(destination))
        {
           
            foreach (var edge in _adjacencyList[vertex])
            {
                if (edge.Item1 == destination)
                {
                    return true;  
                }
            }
        }

        return false;  
    }

    public int GetInDegree(string vertex)
    {
        int inDegree = 0;  

        
        if (_vertexDictionary.ContainsKey(vertex))
        {
            
            foreach (var vertex1 in _adjacencyList)
            {
                
                foreach (var edge in vertex1.Value)
                {                   
                    if (edge.Item1 == vertex)
                    {
                        inDegree++;
                    }
                }
            }
        }

        return inDegree;  
    }

    
    public int GetOutDegree(string vertex)
    {
        int outDegree = 0;  

        if (_vertexDictionary.ContainsKey(vertex))
        {
            outDegree = _adjacencyList[vertex].Count;
        }

        return outDegree; 
    }

    public static void Main(string[] args)
    {
       
        List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

        Graph graph1 = new Graph(vertices, enGraphDirectionType.unDirected);

        graph1.AddEdge("A", "B", 1);
        graph1.AddEdge("A", "C", 1);
        graph1.AddEdge("B", "D", 1);
        graph1.AddEdge("C", "D", 1);
        graph1.AddEdge("B", "E", 1);
        graph1.AddEdge("D", "E", 1);

        
        graph1.DisplayGraph("Adjacency List for Example1 (Undirected Graph):");

        Console.WriteLine("\n------------------------------\n");

        Graph graph2 = new Graph(vertices, enGraphDirectionType.Directed);

       
        graph2.AddEdge("A", "A", 1);
        graph2.AddEdge("A", "B", 1);
        graph2.AddEdge("A", "C", 1);
        graph2.AddEdge("B", "E", 1);
        graph2.AddEdge("D", "B", 1);
        graph2.AddEdge("D", "C", 1);
        graph2.AddEdge("D", "E", 1);

        graph2.DisplayGraph("Adjacency List for Example2 (Directed Graph):");

       
        Console.WriteLine("\nInDegree of vertex1 D: " + graph2.GetInDegree("D"));
        Console.WriteLine("\nOutDegree of vertex1 D: " + graph2.GetOutDegree("D"));

        Console.WriteLine("\n------------------------------\n");

        
        Graph graph3 = new Graph(vertices, enGraphDirectionType.unDirected);

       
        graph3.AddEdge("A", "B", 5);
        graph3.AddEdge("A", "C", 3);
        graph3.AddEdge("B", "D", 12);
        graph3.AddEdge("C", "D", 10);
        graph3.AddEdge("B", "E", 2);
        graph3.AddEdge("D", "E", 7);
      
        graph3.DisplayGraph("Adjacency List for Example3 (Weighted Graph):");
        
        Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdge("A", "B"));
       
        graph3.RemoveEdge("E", "D");
       
        graph3.DisplayGraph("After Removing Edge between E and D:");

        Console.ReadKey();

    }
}

