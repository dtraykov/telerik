﻿namespace AutoResizableStack
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class CustomStack<T> : IEnumerable<T>
    {
        private T[] elements = null;

        private int pointer = 0;

        public CustomStack()
        {
            this.Clear();
        }

        public int Count
        {
            get { return this.pointer + 1; }
        }

        public int Capacity
        {
            get { return this.elements.Length; }
        }

        public void Push(T value)
        {
            this.pointer++;

            if (this.elements.Length < this.pointer + 1)
            {
                this.EnsureCapacity(this.pointer + 1);
            }

            this.elements[this.pointer] = value;
        }

        public T Peek()
        {
            if (this.pointer == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            return this.elements[this.pointer];
        }

        public T Pop()
        {
            if (this.pointer == -1)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            T value = this.elements[this.pointer];

            this.elements[this.pointer] = default(T);

            this.pointer--;

            return value;
        }

        public void Clear()
        {
            this.pointer = -1;
            this.elements = new T[0];
        }

        public void TrimExcess()
        {
            Array.Resize(ref this.elements, this.Count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(" ", this);
        }

        private void EnsureCapacity(int size)
        {
            if (!(this.elements.Length < size))
            {
                return;
            }

            int newSize = (this.elements.Length != 0) ? (this.elements.Length * 2) : 1;

            Array.Resize(ref this.elements, newSize);
        }
    }
}
