using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmData
{
    public class Call
    {
        private DateTime dateTime;
        private string dialedNumber;
        private int duration;

        public Call(DateTime dateTime, string dialedNumbers, int duration)
        {
            this.DateTime = dateTime;
            this.DialedNumber = dialedNumbers;
            this.Duration = duration;
        }

        public DateTime DateTime
        {
            get { return this.dateTime; }
            set { this.dateTime = value; }
        }

        public string DialedNumber
        {
            get { return this.dialedNumber; }
            set { this.dialedNumber = value; }
        }

        public int Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }
    }
}
