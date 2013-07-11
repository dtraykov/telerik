namespace PriorityQueue
{
    using System;

    public class Node<T>
        where T : IComparable<T>
    {
        private T nodeItem;

        public Node(T value)
        {
            this.nodeItem = value;
        }

        public T Getvalue()
        {
            return this.nodeItem;
        }

        public void SetValue(T id)
        {
            this.nodeItem = id;
        }
    }
}
