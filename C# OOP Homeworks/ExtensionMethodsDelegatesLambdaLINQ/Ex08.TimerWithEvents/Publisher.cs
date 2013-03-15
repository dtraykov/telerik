using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex08.TimerWithEvents
{
    public class Publisher
    {
        private int interval = 0;
        private int overalTime;
        private EventArgs e = null;

        public Publisher() :
            this(0, 20)
        {
        }

        public Publisher(int interval, int totalSeconds)
        {
            this.overalTime = totalSeconds;
            this.interval = interval;
        }

        public delegate void TimerDelegate(Publisher pub, EventArgs e);

        public event TimerDelegate RaiseCustomEvent;

        public int OveralTime
        {
            get
            {
                return this.overalTime;
            }

            set
            {
                this.overalTime = value * 1000;
            }
        }

        public int Interval
        {
            get
            {
                return this.interval;
            }

            set
            {
                this.interval = value;
            }
        }

        public void Start()
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddMilliseconds(this.OveralTime);
            while (start <= end)
            {
                if (this.RaiseCustomEvent != null)
                {
                    this.RaiseCustomEvent(this, this.e);
                }

                Thread.Sleep(this.Interval);
                start = DateTime.Now;
            }
        }
    }
}
