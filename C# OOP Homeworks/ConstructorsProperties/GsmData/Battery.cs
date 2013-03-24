using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmData
{
    public class Battery
    {
        private BatteryType batteryModel;
        private int idleHours;
        private int talkHours;

        public Battery()
        {
        }

        public Battery(BatteryType batteryModel)
            : this(batteryModel, 0, 0)
        {
        }

        public Battery(BatteryType batteryModel, int idleHours, int talkHours)
        {
            this.IdleHours = idleHours;
            this.TalkHours = talkHours;
            this.BatteryModel = batteryModel;
        }

        public BatteryType BatteryModel
        {
            get { return this.batteryModel; }
            set { this.batteryModel = value; }
        }

        public int IdleHours
        {
            get { return this.idleHours; }
            set { this.idleHours = value; }
        }

        public int TalkHours
        {
            get { return this.talkHours; }
            set { this.talkHours = value; }
        }
    }
}
