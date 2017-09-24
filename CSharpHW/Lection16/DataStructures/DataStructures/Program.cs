using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(7);
            queue.Enqueue(8);

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Pop();
            stack.Pop();
            stack.Push(6);

            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(2, "first");

            dictionary.Add(3, "second");

            var a = dictionary[3];

        }
    }
}