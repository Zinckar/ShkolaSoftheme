namespace LinkedList
{
    public class Node<T>
    {
        public T CurrentNode { get; set; }

        public Node<T> NextNode { get; set; }

        public Node<T> PreviousNode { get; set; }

        public Node(T currentNode)
        {
            CurrentNode = currentNode;
        }
    }
}