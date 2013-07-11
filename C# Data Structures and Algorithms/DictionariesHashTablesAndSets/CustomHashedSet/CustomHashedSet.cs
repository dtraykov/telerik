namespace CustomHashedSet
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using CustomHashTable;

    public class CustomHashedSet<T> : IEnumerable<T>
    {
        private CustomHashTable<T, T> container;

        public CustomHashedSet(params T[] values)
        {
            this.container = new CustomHashTable<T, T>();

            if (values != null)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    this.container.Add(values[i], values[i]);
                }
            }
        }

        public int Count
        {
            get { return this.container.Count; }
            private set { }
        }

        public void Add(T value)
        {
            this.container.Add(value, value);
        }

        public void Remove(T value)
        {
            this.container.Remove(value);
        }

        public T Find(T value)
        {
            T lookedValue = this.container.Find(value);

            return lookedValue;
        }

        public void Clear()
        {
            this.container = new CustomHashTable<T, T>();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.container)
            {
                yield return item.Value;
            }
        }

        public void UnionWhith(CustomHashedSet<T> otherSet)
        {
            foreach (var item in otherSet)
            {
                if (!this.container.Contains(new KeyValuePair<T, T>(item, item)))
                {
                    this.container.Add(item, item);
                }
            }
        }

        public void IntersectWith(CustomHashedSet<T> otherSet)
        {
            CustomHashTable<T, T> otherTable = new CustomHashTable<T, T>();
            foreach (var item in otherSet)
            {
                if (this.container.Contains(new KeyValuePair<T, T>(item, item)))
                {
                    otherTable.Add(item, item);
                }
            }

            this.container = otherTable;
        }
    }
}
