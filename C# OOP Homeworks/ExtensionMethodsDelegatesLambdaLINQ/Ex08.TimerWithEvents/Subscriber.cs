using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08.TimerWithEvents
{
    public class Subscriber
    {
        public void Subscribe(Publisher pub)
        {
            pub.RaiseCustomEvent += new Publisher.TimerDelegate(this.Message);
        }

        public void Message(Publisher pub, EventArgs e)
        {
            Console.WriteLine("You have a new message");
        }
    }
}
