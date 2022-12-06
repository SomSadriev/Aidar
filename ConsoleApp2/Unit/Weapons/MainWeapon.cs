using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Unit.Weapons
{
    internal class MainWeapon
    {
        public string name;
        public string color;
        public bool canBurstShooting; //возможность стрелять очередями
        public double weight; //масса
        public int amount_bullet; //кол-во пуль
        public int rateOfFire; //скорострельность
        public int minDamage;
        public int maxDamage;

        public MainWeapon(string name, string color, double weight, int minDamage, int maxDamage)
        {
            this.name = name;
            this.color = color;
            this.weight = weight; //масса
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public MainWeapon(string name, string color, bool canBurstShooting, double weight, int amount_bullet, int rateOfFire, int minDamage, int maxDamage)
        {
            this.name = name;
            this.color = color;
            this.canBurstShooting = canBurstShooting;
            this.weight = weight;
            this.amount_bullet = amount_bullet;
            this.rateOfFire = rateOfFire;
            this.minDamage = minDamage;
            this.maxDamage = maxDamage;
        }

        public void Print()
        {
            Console.WriteLine($"The values of fields are weapon: {name}");
            Console.WriteLine($"Color = {color}");
            Console.WriteLine($"Can Burst Shooting = {canBurstShooting}");
            Console.WriteLine($"Weight = {weight}");
            Console.WriteLine($"Amount bullet = {amount_bullet}");
            Console.WriteLine($"Rate Of Fire = {rateOfFire}");
            Console.WriteLine($"Min.Damage {minDamage}");
            Console.WriteLine($"Max.Damage {maxDamage}");
        }

        public void Print_1()
        {
            Console.WriteLine($"The values of fields are weapon: {name}");
            Console.WriteLine($"Color = {color}");
            Console.WriteLine($"Weight = {weight}");
            Console.WriteLine($"Min.Damage {minDamage}");
            Console.WriteLine($"Max.Damage {maxDamage}");
        }
    }
}
