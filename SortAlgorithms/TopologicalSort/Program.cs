// See https://aka.ms/new-console-template for more information


using TopologicalSort;

Graph A = new Graph("A");
Graph B = new Graph("B");
Graph C = new Graph("C");
Graph D = new Graph("D");
Graph E = new Graph("E");

B.AddNode(E);
B.AddNode(C);
E.AddNode(A);
E.AddNode(C);
A.AddNode(D);
A.AddNode(C);
C.AddNode(D);


Console.WriteLine("Hello, World!");