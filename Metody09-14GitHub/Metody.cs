using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody09_14GitHub
{
    class Metody
    {
        public static bool Kvadratickarovnice(out double diskriminant, out double koren1, out double koren2, double a, double b, double c)
        {
            diskriminant = b * b - 4 * (a * c);
            if (diskriminant > 0)
            {
                koren1 = -b + Math.Sqrt(diskriminant) / 2 * a;
                koren2 = -b - Math.Sqrt(diskriminant) / 2 * a;
            }
            else if (diskriminant < 0)
            {
                koren1 = -b + Math.Sqrt(diskriminant) / 2 * a;
                koren2 = -b - Math.Sqrt(diskriminant) / 2 * a;
            }
            else
            {
                koren1 = -b + Math.Sqrt(diskriminant) / 2 * a;
                koren2 = -b - Math.Sqrt(diskriminant) / 2 * a;
            }
            
            bool maReseniVR = false;
            return maReseniVR;
        }
    }
}
