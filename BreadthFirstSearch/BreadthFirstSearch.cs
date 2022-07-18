using BreadthFirstSearch;

Node root = new Node(1);

root.LeftNode = new Node(2);
root.RightNode = new Node(3);
root.LeftNode.LeftNode = new Node(4);
root.LeftNode.RightNode = new Node(5);
root.RightNode.LeftNode = new Node(6);
root.RightNode.RightNode = new Node(7);