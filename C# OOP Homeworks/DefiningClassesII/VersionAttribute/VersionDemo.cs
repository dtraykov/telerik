using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [VersionAttribute(4, 11)]
    class VersionDemo
    {
        static void Main(string[] args)
        {
            Type type = typeof(VersionDemo);
            object[] versionAttributes = type.GetCustomAttributes(false);
            foreach (VersionAttribute versionAttribute in versionAttributes)
            {
                Console.WriteLine("The version of the class VersionDemo is {0}.{1}",
                    versionAttribute.Major, versionAttribute.Minor);
            }
            Console.WriteLine();
        }
    }
}
