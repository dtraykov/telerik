using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmData
{
    public class Gsm
    {
        private static Gsm iphone = new Gsm("iPhone 4S 16G", "Apple", 699.00M, new Battery(BatteryType.LiPo, 200, 14), new Display(3.5F, "16M"));

        private Battery battery;
        private Display display;

        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;

        private List<Call> callHistory = new List<Call>();

        public Gsm(string model, string manufacturer, Battery battery, Display display)
            : this(model, manufacturer, 0, null, battery, display)
        {
        }

        public Gsm(string model, string manufacturer, decimal price, Battery battery, Display display)
            : this(model, manufacturer, price, null, battery, display)
        {
        }

        public Gsm(string model, string manufacturer, string owner, Battery battery, Display display)
            : this(model, manufacturer, 0, owner, battery, display)
        {
        }

        public Gsm(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public static Gsm IPhone4S
        {
            get
            {
                return iphone;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid Model! Model can't be empty!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid manufacturer! Manufacturer can't be empty!");
                }

                this.manufacturer = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Price! Price can't be negative!");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine("-------------GSM-------------");
            text.AppendLine(string.Format("Model: {0,22}", this.Model));
            text.AppendLine(string.Format("Manufacturer: {0,15}", this.Manufacturer));
            text.AppendLine(string.Format("Price: {0,22:C2}", this.Price));
            text.AppendLine(string.Format("Owner: {0,22}", this.Owner));
            text.AppendLine();
            text.AppendLine("-----------BATTERY-----------");
            text.AppendLine(string.Format("Model Type: {0,17}", this.battery.BatteryModel));
            text.AppendLine(string.Format("Idle hours: {0,17}", this.battery.IdleHours));
            text.AppendLine(string.Format("Talk hours: {0,17}", this.battery.TalkHours));
            text.AppendLine();
            text.AppendLine("-----------DISPLAY-----------");
            text.AppendLine(string.Format("Size(inches): {0,15}", this.display.Size));
            text.AppendLine(string.Format("Number of Colors: {0,11}", this.display.NumberColors));
            text.AppendLine("-----------------------------");
            string result = text.ToString();
            return result;
        }

        public void AddCall(DateTime now, string dialedNumber, int duration)
        {
            Call newCall = new Call(now, dialedNumber, duration);
            this.callHistory.Add(newCall);
        }

        public void RemoveCall(int duration)
        {
            for (int i = 0; i < this.callHistory.Count; i++)
            {
                if (this.callHistory[i].Duration == duration)
                {
                    this.callHistory.Remove(this.callHistory[i]);
                }
            }
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public double TotalPrice()
        {
            double totalPrice = 0;
            double cost = 0.37;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalPrice += this.callHistory[i].Duration * cost;
            }

            return totalPrice;
        }

        public void DisplayCallHistory()
        {
            StringBuilder displayCall = new StringBuilder();
            displayCall.AppendLine("---------CALL HISTORY---------");
            foreach (var call in this.callHistory)
            {
                displayCall.AppendLine(string.Format("Number: {0,22}", call.DialedNumber));
                displayCall.AppendLine(string.Format("Date: {0,24}", call.DateTime));
                displayCall.AppendLine(string.Format("Duration: {0,20}", call.Duration));
                displayCall.AppendLine("------------------------------");
            }

            Console.WriteLine(displayCall.ToString());
            Console.WriteLine("Total price: {0,17:C2}", this.TotalPrice());
        }
    }
}
