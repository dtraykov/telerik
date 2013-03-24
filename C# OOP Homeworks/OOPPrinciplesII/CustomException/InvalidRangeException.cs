using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class InvalidRangeException<T> : Exception
    {
        private T outrangeValue;
        private T minValue;
        private T maxValue;

        public InvalidRangeException()
        {
        }

        public InvalidRangeException(string message, Exception innerException = null)
            : this(message, default(T), innerException)
        {
        }

        public InvalidRangeException(string message, T outrangeValue, Exception innerException = null)
            : this(message, outrangeValue, default(T), default(T), innerException)
        {
        }

        public InvalidRangeException(string message, T outrangeValue, T minValue, T maxValue, Exception innerException = null)
            : base(message, innerException)
        {
            this.OutrangeValue = outrangeValue;
            this.MinValue = minValue;
            this.MaxValue = maxValue;
        }

        public T MaxValue
        {
            get
            {
                return this.maxValue;
            }

            set
            {
                this.maxValue = value;
            }
        }

        public T MinValue
        {
            get
            {
                return this.minValue;
            }

            set
            {
                this.minValue = value;
            }
        }

        public T OutrangeValue
        {
            get
            {
                return this.outrangeValue;
            }

            set
            {
                this.outrangeValue = value;
            }
        }
    }
}
