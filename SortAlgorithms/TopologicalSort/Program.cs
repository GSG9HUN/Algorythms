// See https://aka.ms/new-console-template for more information


using TopologicalSort;

var a = new Graph("A");
var b = new Graph("B");
var c = new Graph("C");
var d = new Graph("D");
var e = new Graph("E");
var f = new Graph("F");
var g = new Graph("G");
var h = new Graph("H");
var i = new Graph("I");
var j = new Graph("J");
var k = new Graph("K");
var l = new Graph("L");
var m = new Graph("M");


a.AddOutDegree(d);
a.AddInDegree(c);
a.AddInDegree(e);

b.AddOutDegree(d);
b.AddInDegree(c);


c.AddOutDegree(a);
c.AddOutDegree(b);

d.AddOutDegree(h);
d.AddOutDegree(g);
d.AddInDegree(b);
d.AddInDegree(a);
d.AddInDegree(e);

e.AddOutDegree(a);
e.AddOutDegree(d);
e.AddOutDegree(f);

f.AddOutDegree(k);
f.AddOutDegree(j);

f.AddInDegree(e);

g.AddOutDegree(i);
g.AddInDegree(d);

h.AddOutDegree(i);
h.AddOutDegree(j);
h.AddInDegree(d);

i.AddOutDegree(l);
i.AddInDegree(g);
i.AddInDegree(h);

j.AddOutDegree(m);
j.AddOutDegree(l);
j.AddInDegree(k);
j.AddInDegree(f);
j.AddInDegree(h);

k.AddOutDegree(j);
k.AddInDegree(f);

l.AddInDegree(j);
l.AddInDegree(i);

m.AddInDegree(j);

List<Graph>list = new List<Graph> {a, b, c, d, e, f, g, h, i, j, k, l, m};

var topologicalSort = new TopologicalSort.TopologicalSort(list);

topologicalSort.TopologicalSortAlgorithm();

var ordering = topologicalSort.GetVisitedNodes();
foreach (var node in ordering)
{
    Console.Write(node.GetData() + " ");
}


