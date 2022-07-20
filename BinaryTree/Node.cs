namespace BinaryTree;

public class Node
{
    public int Data { get; set; }

    public Node LeftNode { get; set; }
    
    public Node RightNode { get; set; }
    
    
    public Node(int data)
    {
        Data = data;
    }
}