namespace BinaryTree;


public class TreeTraversal
{
    private List<int> Path = new();

    public void PreorderTraversal(Node? node)
    {
        if (node == null)
        {
            return;
        }

        Path.Add(node.Data);
        PreorderTraversal(node.LeftNode);
        PreorderTraversal(node.RightNode);
    
    }

    public void InorderTraversal(Node? node)
    {
        if (node == null)
        {
            return;
        }
        InorderTraversal(node.LeftNode);
        Path.Add(node.Data);
        InorderTraversal(node.RightNode);
    }

    public void PostorderTraversal(Node? node)
    {
        if (node == null)
        {
            return;
        }
        
        PostorderTraversal(node.LeftNode);
        PostorderTraversal(node.RightNode);   
        Path.Add(node.Data);
    }

    
    public List<int> GetPath()
    {
        return Path;
    }
    
    
}