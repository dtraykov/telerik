using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08.TimerWithEvents
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Publisher pub = new Publisher(200, 2000);
            Subscriber sub = new Subscriber();

            sub.Subscribe(pub);
            pub.Start();
        }
    }
}
