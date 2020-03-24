using System;
using System.Collections.Generic;
using System.Text;

namespace aircraft_carrier
{
    class F16 : Aircraft
    {
        public F16()
        {
            type = Types.F16;
            maxAmmo = 8;
            baseDamage = 30;
        }
    }
}

/*Max ammo: 8
    Base damage: 30
*/