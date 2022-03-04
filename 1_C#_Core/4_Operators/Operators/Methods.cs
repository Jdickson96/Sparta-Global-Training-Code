using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Methods
    {
        public static int GetStones(int totalPounds)
        {
            if (totalPounds < 0)
            {
                throw new ArgumentOutOfRangeException("totalPounds: " + totalPounds + " Value Must Be Greater than Zero");
            }
            else
            {
                return totalPounds / 14;
            }
        }

        public static int GetPounds(int totalPounds)
        {
            if (totalPounds < 0)
            {
                throw new ArgumentOutOfRangeException("totalPounds: " + totalPounds + " Value Must Be Greater than Zero");
            }
            else
            {
                return totalPounds % 14;
            }
        }
    }
}
