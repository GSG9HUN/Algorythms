using BinaryTree;

namespace BreadthFirstSearchUnitTests;

[TestClass]
public class BfsUnitTests
{
    private Node Root;
    
    [TestInitialize]
    public void Init()
    {
        Root = new Node(1);

        Root.LeftNode = new Node(2);
        Root.LeftNode.LeftNode = new Node(4);
        Root.LeftNode.RightNode = new Node(5);
        Root.RightNode = new Node(3);
        Root.RightNode.LeftNode = new Node(6);
        Root.RightNode.RightNode = new Node(7);

    }

    
    [TestMethod]
    public void Bfs1()
    {
        Node foundedNode = Bfs(Root, 2);
    }
    
    [TestMethod]
    public void Bfs2()
    {
    }
    
    [TestMethod]
    public void Bfs3()
    {
        
    }
}