using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GsmData
{
    public class GsmTest
    {
      public  static void Main(string[] args)
        {
            Battery firstBattery = new Battery(BatteryType.LiIon, 650, 5);
            Battery secoundBattery = new Battery(BatteryType.LiIon);
            Battery thirdBattery = new Battery();

            Display firstDisplay = new Display(2.4F);
            Display secoundDisplay = new Display("16M 312ppi");
            Display thirdDisplay = new Display(2.8F, "16M 286ppi");

            Gsm firstGsm = new Gsm("Asha 203", "Nokia", 129.90M, "Peshu", firstBattery, firstDisplay);
            Gsm secoundGsm = new Gsm("ONE X", "HTC", 699.90M, "Goshu", secoundBattery, secoundDisplay);
            Gsm thirdGsm = new Gsm("Bold 9900", "BlackBerry ", "Cecka", thirdBattery, thirdDisplay);

            Gsm[] gsmData = new Gsm[4];
            Gsm.IPhone4S.Owner = "Penka";
            gsmData[0] = Gsm.IPhone4S;
            gsmData[1] = firstGsm;
            gsmData[2] = secoundGsm;
            gsmData[3] = thirdGsm;

            foreach (Gsm gsm in gsmData)
            {
                Console.WriteLine(gsm.ToString());
            }

            firstGsm.AddCall(DateTime.Now, "087654321", 439);
            firstGsm.AddCall(DateTime.Now, "087777777", 34);
            firstGsm.AddCall(DateTime.Now, "086666666", 254);
            firstGsm.AddCall(DateTime.Now, "085555555", 99);

            firstGsm.DisplayCallHistory();
            Console.WriteLine();
            firstGsm.RemoveCall(439);
            Console.WriteLine();
            firstGsm.DisplayCallHistory();
            Console.WriteLine();
            firstGsm.ClearHistory();
            Console.WriteLine();
            firstGsm.DisplayCallHistory();
        }
    }
}
