namespace DataStructures
{
    public interface IQueue<T>
    {
        void Enqueue(T item);

        T Dequeue();

        T Peek();
    }
}