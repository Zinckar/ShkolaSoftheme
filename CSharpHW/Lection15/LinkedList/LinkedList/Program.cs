using System;

namespace LinkedList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DoubleLinkedList<int> listInt = new DoubleLinkedList<int>();
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);

            listInt.Add(node1);
            listInt.Add(node2);
            listInt.Add(node3);
            listInt.Add(node4);


            try
            {
                listInt.AddAfterIndex(node5, 3);
                listInt.RemoveByIndex(4);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
            listInt.Contains(node4);

            var a = listInt.ToArray();

            foreach (var elem in a)
            {
                Console.WriteLine(elem.CurrentNode);
            }
            Console.ReadKey();
        }
    }
}