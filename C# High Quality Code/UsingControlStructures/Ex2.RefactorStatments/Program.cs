using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.RefactorStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            Potato potato;
            //... 
            if (potato != null)
            {
                if (!potato.IsRotten && potato.HasBeenPeeled)
                {
                    Cook(potato);
                }
            }

            bool xInRange = MIN_X <= x && x <= MAX_X;
            bool yInRange = MIN_Y <= y && y <= MAX_Y;

            if (xInRange && yInRange  && visitedCell)
            {
               VisitCell();
            }
        }
    }
}
