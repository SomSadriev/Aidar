using ConsoleApp2.Unit.Weapons;

class Program
{
    static void Main()
    {

        MainWeapon weapon_exaple = new MainWeapon("Main Weapon", "Black", true, 100, 100, 100, 100, 100);
        weapon_exaple.Print();


        Console.WriteLine();
        Pistol pistol_1 = new Pistol("Pistol traumatic", "Blue", true, 20, 3, 3, 3, 35, "Metall");
        pistol_1.Print();

        Console.WriteLine();
        Knife knife_1 = new Knife("Hawkbill", "Grey", 1, 2, 35, 200);
        knife_1.Print_1();

        Console.WriteLine();
        Knife knife_2 = new Knife("Hawkbill", "Grey", 1, 2, 35, 200);
        knife_2.Print_1();

        
    }
}
