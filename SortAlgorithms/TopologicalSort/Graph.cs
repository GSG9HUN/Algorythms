namespace TopologicalSort;

public class Graph
{
    private string _data;

    private List<Graph> _inDegree = new List<Graph>();
    private List<Graph> _outDegree = new List<Graph>();

    public Graph(string data)
    {
        _data = data;
    }


    public string GetData()
    {
        return _data;
    }

    public List<Graph> GetNodes()
    {
        return _nodes;
    }

    public void AddNode(Graph node)
    {
        _outDegree.Add(node);
        AddInDegree(node);
    }


    private void AddInDegree(Graph node)
    {
        _inDegree.Add(node);
    }
}