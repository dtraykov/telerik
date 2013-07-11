namespace PriorityQueue
{
    using System;

    public class PriorityQueue<T>
         where T : IComparable<T>
    {
        private const int MaxQueueSize = 4;
        private Node<T>[] queueArray;
        private int maxSize;
        private int currentSize;

        public PriorityQueue()
        {
            this.maxSize = MaxQueueSize;
            this.currentSize = 0;
            this.queueArray = new Node<T>[this.maxSize];
        }

        public bool IsEmpty()
        {
            return this.currentSize == 0;
        }

        public void Enqueue(T value)
        {
            if (this.currentSize == this.maxSize)
            {
                this.Resize();
            }

            Node<T> newNode = new Node<T>(value);
            this.queueArray[this.currentSize] = newNode;
            this.CascadeUp(this.currentSize++);
        }

        public Node<T> Dequeue() // Remove maximum value node
        {
            Node<T> root = this.queueArray[0];
            this.queueArray[0] = this.queueArray[--this.currentSize];
            this.CascadeDown(0);

            return root;
        }

        public bool HeapIncreaseDecreaseKey(int index, T newValue)
        {
            if (index < 0 || index >= this.currentSize)
            {
                return false;
            }

            T oldValue = this.queueArray[index].Getvalue();
            this.queueArray[index].SetValue(newValue);

            if (oldValue.CompareTo(newValue) == -1)
            {
                this.CascadeUp(index);
            }
            else
            {
                this.CascadeDown(index);
            }

            return true;
        }

        public void DisplayQueue()
        {
            Console.WriteLine();
            Console.Write("Elements of the Heap Array are : ");
            for (int m = 0; m < this.currentSize; m++)
            {
                if (this.queueArray[m] != null)
                {
                    Console.Write(this.queueArray[m].Getvalue() + " ");
                }
                else
                {
                    Console.Write("-- ");
                }
            }

            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            string separator = "...............................";
            Console.WriteLine(separator + separator);
            while (this.currentSize > 0)
            {
                if (column == 0)
                {
                    for (int k = 0; k < emptyLeaf; k++)
                    {
                        Console.Write(' ');
                    }
                }

                Console.Write(this.queueArray[j].Getvalue());

                if (++j == this.currentSize)
                {
                    break;
                }

                if (++column == itemsPerRow)
                {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                }
                else
                {
                    for (int k = 0; k < (emptyLeaf * 2) - 2; k++)
                    {
                        Console.Write(' ');
                    }
                }
            }

            Console.WriteLine("\n" + separator + separator);
        }

        private void CascadeDown(int index)
        {
            int largerChild;
            Node<T> top = this.queueArray[index];
            while (index < this.currentSize / 2)
            {
                int leftChild = (2 * index) + 1;
                int rightChild = leftChild + 1;
                bool compare = this.queueArray[leftChild].Getvalue().CompareTo(this.queueArray[rightChild].Getvalue()) == -1;
                if (rightChild < this.currentSize && compare)
                {
                    largerChild = rightChild;
                }
                else
                {
                    largerChild = leftChild;
                }

                int comp = top.Getvalue().CompareTo(this.queueArray[largerChild].Getvalue());
                if (comp == 0 || comp > 0)
                {
                    break;
                }

                this.queueArray[index] = this.queueArray[largerChild];
                index = largerChild;
            }

            this.queueArray[index] = top;
        }

        private void CascadeUp(int index)
        {
            int parent = (index - 1) / 2;
            Node<T> bottom = this.queueArray[index];
            while (index > 0 && this.queueArray[parent].Getvalue().CompareTo(bottom.Getvalue()) == -1)
            {
                this.queueArray[index] = this.queueArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }

            this.queueArray[index] = bottom;
        }

        private void Resize()
        {
            this.maxSize = this.maxSize * 2;
            Node<T>[] newArray = new Node<T>[this.maxSize];
            for (int i = 0; i < this.currentSize; i++)
            {
                newArray[i] = this.queueArray[i];
            }

            this.queueArray = newArray;
        }
    }
}
