using BreadthFirstSearch;

namespace BreadthFirstSearchUnitTests;

[TestClass]
public class TreeTraversalsUnitTest
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
    public void PreorderTraversalTest()
    {
        
        TreeTraversal traversal = new TreeTraversal();
        traversal.PreorderTraversal(Root);
        List<int> expected = new List<int>();

        expected.Add(1);
        expected.Add(2);
        expected.Add(4);
        expected.Add(5);
        expected.Add(3);
        expected.Add(6);
        expected.Add(7);
        
        CollectionAssert.AreEqual(expected,traversal.GetPath());
    }
    
    [TestMethod]
    public void InorderTraversalTest()
    {
        TreeTraversal traversal = new TreeTraversal();
        traversal.InorderTraversal(Root);
        List<int> expected = new List<int>();

        expected.Add(4);
        expected.Add(2);
        expected.Add(5);
        expected.Add(1);
        expected.Add(6);
        expected.Add(3);
        expected.Add(7);
        
        CollectionAssert.AreEqual(expected,traversal.GetPath());
    }
    
    [TestMethod]
    public void PostorderTraversalTest()
    {
        TreeTraversal traversal = new TreeTraversal();
        traversal.PostorderTraversal(Root);
        List<int> expected = new List<int>();

        expected.Add(4);
        expected.Add(5);
        expected.Add(2);
        expected.Add(6);
        expected.Add(7);
        expected.Add(3);
        expected.Add(1);
        
        CollectionAssert.AreEqual(expected,traversal.GetPath());
    }
    
}