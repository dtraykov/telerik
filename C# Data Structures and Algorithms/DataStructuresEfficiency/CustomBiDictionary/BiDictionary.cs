namespace CustomBiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

   public class BiDictionary<K1, K2, V>
    {
       private MultiDictionary<K1, V> firstKeyDictionary;
       private MultiDictionary<K2, V> secondKeyDictionary;
       private MultiDictionary<int, V> bothKeysDictionary;
       private MultiDictionary<K1, K2> firstSecondKeyDictionary;
       private MultiDictionary<K2, K1> secondFirstKeyDictionary;

        public BiDictionary()
        {
            this.firstKeyDictionary = new MultiDictionary<K1, V>(true);
            this.secondKeyDictionary = new MultiDictionary<K2, V>(true);
            this.bothKeysDictionary = new MultiDictionary<int, V>(true);
            this.firstSecondKeyDictionary = new MultiDictionary<K1, K2>(true);
            this.secondFirstKeyDictionary = new MultiDictionary<K2, K1>(true);
        }

        public void Add(K1 key1, K2 key2, V value)
        {
            int compositeKey = this.GetCompositeKey(key1, key2);
            this.bothKeysDictionary.Add(compositeKey, value);
            this.firstKeyDictionary.Add(key1, value);
            this.secondKeyDictionary.Add(key2, value);

            this.firstSecondKeyDictionary.Add(key1, key2);
            this.secondFirstKeyDictionary.Add(key2, key1);
        }

        public ICollection<V> FindUsingFirstKey(K1 key1)
        {
            List<V> found = new List<V>();

            found.AddRange(this.firstKeyDictionary[key1]);

            return found;
        }

        public ICollection<V> FindUsingSecondKey(K2 key2)
        {
            List<V> found = new List<V>();

            found.AddRange(this.secondKeyDictionary[key2]);

            return found;
        }

        public ICollection<V> FindUsingBothKeys(K1 key1, K2 key2)
        {
            List<V> found = new List<V>();

            found.AddRange(this.firstKeyDictionary[key1]);
            found.AddRange(this.secondKeyDictionary[key2]);
            found.AddRange(this.bothKeysDictionary[this.GetCompositeKey(key1, key2)]);

            return found;
        }

        public void RemoveWithFirstKey(K1 key1)
        {
            if (!this.firstKeyDictionary.ContainsKey(key1))
            {
                throw new ArgumentException("Invalid key");
            }

            this.firstKeyDictionary.Remove(key1);
            ICollection<K2> key2 = this.firstSecondKeyDictionary[key1];
            foreach (var item in key2)
            {
                this.secondKeyDictionary.Remove(item);
                this.bothKeysDictionary.Remove(this.GetCompositeKey(key1, item));
            }
        }

        public void RemoveWithSecondKey(K2 key2)
        {
            if (!this.secondKeyDictionary.ContainsKey(key2))
            {
                throw new ArgumentException("Invalid key");
            }

            this.secondKeyDictionary.Remove(key2);
            ICollection<K1> key1 = this.secondFirstKeyDictionary[key2];
            foreach (var item in key1)
            {
                this.firstKeyDictionary.Remove(item);
                this.bothKeysDictionary.Remove(this.GetCompositeKey(item, key2));
            }
        }

        public void RemoveWithBothKeys(K1 key1, K2 key2)
        {
            if (!this.firstKeyDictionary.ContainsKey(key1) || !this.secondKeyDictionary.ContainsKey(key2))
            {
                throw new ArgumentException("Invalid key");
            }

            this.firstKeyDictionary.Remove(key1);
            this.secondKeyDictionary.Remove(key2);

            this.bothKeysDictionary.Remove(this.GetCompositeKey(key1, key2));
        }

        private int GetCompositeKey(K1 key1, K2 key2)
        {
            int compositeKey = 0;
            unchecked
            {
                compositeKey = key1.GetHashCode() * 5039;
                compositeKey = key2.GetHashCode() * 5039;
            }

            return compositeKey;
        }
    }
}