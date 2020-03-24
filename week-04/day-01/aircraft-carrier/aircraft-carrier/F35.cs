using System;
using System.Collections.Generic;
using System.Text;

namespace aircraft_carrier
{
    class F35 : Aircraft
    {
        
        public F35()
        {
            type = Types.F35;
            baseDamage = 50;
            maxAmmo = 12;
        }
    }
}
