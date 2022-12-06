using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Unit.Weapons
{
    internal class Knife : MainWeapon
    {
        public int blade_length;
        public Knife(string name, string color, double weight, int minDamage, int maxDamage, int blade_length) : base(name, color, weight, minDamage, maxDamage)
        {
            this.blade_length = blade_length;
        }

        public new void Print_1()
        {
            base.Print_1();
            Console.WriteLine($"Blade length = {blade_length}");
        }
    }
}
