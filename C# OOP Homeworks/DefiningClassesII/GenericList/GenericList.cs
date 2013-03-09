using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    public class GenericList<T> where T : IComparable
    {
        private T[] elements;
        private int count = 0;

        public GenericList(int capacity)
        {
            this.elements = new T[capacity];
        }

        public GenericList()
            : this(4)
        {
        }

        public int Capacity
        {
            get
            {
                return this.elements.Length;
            }

            set
            {
                if (value < this.count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (value != this.elements.Length)
                {
                    if (value > 0)
                    {
                        T[] tarray = new T[value];
                        if (this.count > 0)
                        {
                            Array.Copy(this.elements, 0, tarray, 0, this.count);
                        }

                        this.elements = tarray;
                        return;
                    }
                }
            }
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public T this[int index]
        {
            get
            {
                if (index >= this.count)
                {
                    throw new IndexOutOfRangeException(string.Format(
                        "Invalid index: {0}.", index));
                }

                T result = this.elements[index];
                return result;
            }
        }
     
        public void Add(T element)
        {
            if (this.count == this.elements.Length)
            {
                this.EnsureCapacity(this.count + 1);
            }

            this.elements[this.count] = element;
            this.count++;
        }

        public void Clear()
        {
            Array.Clear(this.elements, 0, this.count);
            this.count = 0;
        }

        public int Find(T value)
        {
            if (value == null)
            {
                throw new ArgumentNullException();
            }

            int index = 0;
            while (index < this.count)
            {
                if (value.Equals(this.elements[index]))
                {
                    return index;
                }
                else
                {
                    index++;
                }
            }

            return -1;
        }

        public T Min()
        {
            T minValue = this.elements[0];

            for (int i = 0; i < this.count; i++)
            {
                if ((dynamic)minValue.CompareTo((dynamic)this.elements[i]) > 0)
                {
                    minValue = this.elements[i];
                }
            }

            return minValue;
        }

        public T Max()
        {
            T maxValue = this.elements[0];

            for (int i = 0; i < this.count; i++)
            {
                if ((dynamic)maxValue.CompareTo((dynamic)this.elements[i]) < 0)
                {
                    maxValue = this.elements[i];
                }
            }

            return maxValue;
        }

        public void Insert(int index, T item)
        {
            if (index > this.count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (this.count == this.elements.Length)
            {
                this.EnsureCapacity(this.count + 1);
            }

            if (index < this.count)
            {
                Array.Copy(this.elements, index, this.elements, index + 1, this.count - index);
            }

            this.elements[index] = item;
            this.count++;
        }

        public void RemoveAt(int index)
        {
            if (index >= this.count)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.count--;
            if (index < this.count)
            {
                Array.Copy(this.elements, index + 1, this.elements, index, this.count - index);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int index = 0; index < this.count; index++)
            {
                output.Append(this.elements[index] + " ");
            }

            output.AppendLine();

            return output.ToString();
        }

        private void EnsureCapacity(int min)
        {
            int num;
            if ((int)this.elements.Length < min)
            {
                num = this.elements.Length * 2;
                int num1 = num;
                if (num1 > 2146435071)
                {
                    num1 = 2146435071;
                }

                if (num1 < min)
                {
                    num1 = min;
                }

                this.Capacity = num1;
            }
        }
    }
}
