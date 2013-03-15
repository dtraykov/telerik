using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex07.TimerDelegate
{
    public class Timer
    {
        private TimerDelegate currentMethods;
        private int interval;
        private int overalTime;

        public Timer() :
            this(0, 20)
        {
        }

        public Timer(int interval, int totalSeconds)
        {
            this.OveralTime = totalSeconds;
            this.interval = interval;
        }

        public delegate void TimerDelegate();

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

        public TimerDelegate CurrentMethods
        {
            get
            {
                return this.currentMethods;
            }

            set
            {
                this.currentMethods = value;
            }
        }

        public void Execute()
        {
            DateTime start = DateTime.Now;
            DateTime end = start.AddMilliseconds(this.OveralTime);
            while (start <= end)
            {
                this.currentMethods();
                Thread.Sleep(this.Interval);
                start = DateTime.Now;
            }
        }
    }
}
