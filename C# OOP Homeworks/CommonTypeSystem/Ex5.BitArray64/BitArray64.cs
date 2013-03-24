using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5.BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;
        private int[] bits;

        public BitArray64(ulong number = 0)
        {
            this.Number = number;
        }

        public int[] Bits
        {
            get
            {
                return this.bits;
            }

            set
            {
                this.bits = value;
            }
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.number = value;
            }
        }

        public int this[int index]
        {
            get
            {
                if (this.IndexChecker(index))
                {
                    throw new System.IndexOutOfRangeException();
                }

                int[] bits = this.ConvertToBits();
                return bits[index];
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }

        public IEnumerator<int> GetEnumerator()
        {
            int[] bits = this.ConvertToBits();
            for (int i = 63; i >= 0; i--)
            {
                yield return bits[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public bool Equals(BitArray64 value)
        {
            if (ReferenceEquals(null, value))
            {
                return false;
            }

            if (ReferenceEquals(this, value))
            {
                return true;
            }

            return this.number == value.number;
        }

        public override bool Equals(object obj)
        {
            BitArray64 temp = obj as BitArray64;
            if (temp == null)
            {
                return false;
            }

            return this.Equals(temp);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = (result * 23) + this.number.GetHashCode();
                return result;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                sb.AppendFormat("[{0}] = {1} \n", i, this[i]);
            }

            return sb.ToString();
        }

        private int[] ConvertToBits()
        {
            ulong value = this.number;

            int[] bits = new int[64];
            int counter = 63;

            while (value != 0)
            {
                bits[counter] = (int)value % 2;
                value /= 2;
                counter--;
            }

            do
            {
                bits[counter] = 0;
                counter--;
            }
            while (counter != 0);

            return bits;
        }

        private bool IndexChecker(int index)
        {
            if (index < 0 || index > 63)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
