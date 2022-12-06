using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Unit.Weapons
{
    internal class Pistol : MainWeapon
    {
        public string material;
        public Pistol(string name, string color, bool canBurstShooting, double weight, int amount_bullet, int rateOfFire, int minDamage, int maxDamage, string material) : base(name, color, canBurstShooting, weight, amount_bullet, rateOfFire, minDamage, maxDamage)
        {
            this.material = material;
        }
    }
}
