namespace TopologicalSort;

public class TopologicalSort
{

    private List<Graph>_listOfArrays;
    private List<Graph> _visitedNodes = new List<Graph>();
    private Graph _startNode;
    public TopologicalSort(List<Graph> listOfArrays)
    {
        _listOfArrays = listOfArrays;
    }

    private Graph PickOneUnvisitedNode()
    {
        var index = new Random().Next(_listOfArrays.Count);

       return _listOfArrays[index];
    }

    public void TopologicalSortAlgorithm()
    {

        while (_listOfArrays.Count > 0)
        {
            var startNode = PickOneUnvisitedNode();
            
            Dfs(startNode);
            
        }

        _visitedNodes.Reverse();
    }

    public List<Graph> GetVisitedNodes()
    {
        return _visitedNodes;
    }

    private void Dfs(Graph node)
    {
        var outDegrees = node.GetOutDegrees();
        
        foreach (var outDegree in outDegrees)
        {
            if (!_visitedNodes.Contains(outDegree))
            {
                Dfs(outDegree);
            }
          
        }

        _visitedNodes.Add(node);

        _listOfArrays.Remove(node);

    }
}