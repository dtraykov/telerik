namespace SortingAndSerachingAlgorithms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Quicksorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("collection", "Collection to sort cannot be null!");
            }

            if (collection.Count > 1)
            {
                this.QuickSort(collection, 0, collection.Count - 1);
            }
        }

        private void QuickSort(IList<T> array, int left, int right)
        {
            int pivot = 0;

            if (left < right)
            {
                pivot = this.Partition(array, left, right);
                this.QuickSort(array, left, pivot - 1);
                this.QuickSort(array, pivot + 1, right);
            }
        }

        private int Partition(IList<T> array, int left, int right)
        {
            T pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j].CompareTo(pivot) < 1)
                {
                    i++;
                    this.Swap(array, i, j);
                }
            }

            this.Swap(array, i + 1, right);
            return i + 1;
        }

        private void Swap(IList<T> array, int a, int b)
        {
            T temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
