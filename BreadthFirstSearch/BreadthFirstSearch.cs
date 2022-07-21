using BinaryTree;

Node? Bfs(Node node,int data)
{
    Queue<Node> q = new Queue<Node>();
    q.Enqueue(node);
    while (q.Count>0)
    {
        Node current = q.Dequeue();
        Console.WriteLine(current.Data);
        if (current.Data == data)
        {
            return current;
        }
        
        q.Enqueue(current.LeftNode);
        q.Enqueue(current.RightNode);
    }


    return null;
}

