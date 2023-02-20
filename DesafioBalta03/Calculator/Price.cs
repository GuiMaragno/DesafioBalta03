using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioBalta03.Calculator
{
    internal static class Price
    {
        public static float GetResult(float alcohol, float gasoline)
        {
            if (gasoline >= 100)
            {
                gasoline /= 100;
            }

            if (alcohol >= 100)
            {
                alcohol /= 100;
            }

            return alcohol / gasoline;  
        }
    }
}
