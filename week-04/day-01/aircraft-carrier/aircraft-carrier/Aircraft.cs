using System;
using System.Collections.Generic;
using System.Text;

namespace aircraft_carrier
{
    class Aircraft
    {
        public enum Types { F16, F35 }
        protected int ammo = 0; 
        protected int baseDamage;
        protected int maxAmmo;
        protected Types type;
        protected int allDamage = 0;
        public int Fight()
        {
            int damage = ammo * baseDamage;
            ammo = 0;
            allDamage += damage;
            return damage;
        }
        public int Refill(int ammoToAdd)
        {
            int missingAmmo = maxAmmo - this.ammo;
            if (ammoToAdd > missingAmmo)
            {
                ammo = maxAmmo;
                return ammoToAdd - missingAmmo;
            }
            else
            {
                ammo += ammoToAdd;
                return 0;
            }
        }
        public string GetType()
        {
            return type.ToString();
        }
        public string GetStatus()
        {
            return $"Type {type}, Ammo: {ammo}, Base Damage: {baseDamage}, All Damage: {allDamage}";
        }
        public bool IsPriority()
        {
            return type.Equals(Types.F35);
        }
    }
}
