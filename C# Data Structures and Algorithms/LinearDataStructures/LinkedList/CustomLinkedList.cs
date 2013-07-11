namespace LinkedList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomLinkedList<T> : IEnumerable<T>
    {
        private int count;

        private ListItem<T> firstElement;
        private ListItem<T> lastElement;

        public ListItem<T> LastElement
        {
            get
            {
                return this.lastElement;
            }

            private set
            {
                this.lastElement = value;
            }
        }

        public ListItem<T> FirstElement
        {
            get
            {
                return this.firstElement;
            }

            private set
            {
                this.firstElement = value;
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            private set
            {
                this.count = value;
            }
        }

        public void AddFirst(T value)
        {
            this.Count++;

            var listItem = new ListItem<T>(value);

            if (this.FirstElement == null)
            {
                this.FirstElement = listItem;
                this.LastElement = listItem;
            }
            else
            {
                listItem.NextItem = this.FirstElement;

                this.FirstElement.PreviousItem = listItem;
                this.FirstElement = listItem;
            }
        }

        public ListItem<T> RemoveFirst()
        {
            if (this.FirstElement == null)
            {
                return null;
            }

            this.Count--;

            var first = this.FirstElement;

            if (this.FirstElement.NextItem == null)
            {
                this.Clear();
            }
            else
            {
                this.FirstElement = this.FirstElement.NextItem;
                this.FirstElement.PreviousItem = null;
            }

            first.NextItem = null;
            first.PreviousItem = null;

            return first;
        }

        public void AddLast(T value)
        {
            this.Count++;

            var listItem = new ListItem<T>(value);

            if (this.LastElement == null)
            {
                this.FirstElement = listItem;
                this.LastElement = listItem;
            }
            else
            {
                listItem.PreviousItem = this.LastElement;

                this.LastElement.NextItem = listItem;
                this.LastElement = listItem;
            }
        }

        public ListItem<T> RemoveLast()
        {
            if (this.LastElement == null)
            {
                return null;
            }

            this.Count--;

            var last = this.LastElement;

            if (this.lastElement.PreviousItem == null)
            {
                this.Clear();
            }
            else
            {
                this.LastElement = this.LastElement.PreviousItem;
                this.lastElement.NextItem = null;
            }

            last.NextItem = null;
            last.NextItem = null;

            return last;
        }

        public void Clear()
        {
            this.FirstElement = null;
            this.LastElement = null;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var current = this.FirstElement; current != null; current = current.NextItem)
            {
                yield return current.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(" <-> ", this);
        }
    }
}
