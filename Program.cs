using System;
using GameInventory;
using GameWeapon;
using GameCharacter;
using GameInteract;
//
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Character BigBaddy = Character.OrcWizard();
            Weapon Spear = Weapon.Spear();
            Weapon Hammer = Weapon.Hammer();
            Weapon MorningStar = Weapon.MorningStar();
            BigBaddy.Add(Hammer);
            Character player = new Character("Lorik", 111, "XXL PIMP", false, true, 1, "Human", "Lancer", true);
            player.Add(Spear);
            player.Add(MorningStar);
            Console.WriteLine("Player health: {0}", player.health);
            Console.WriteLine("Enemy Health: {0}", BigBaddy.health);
            Interact.Combat(player,BigBaddy);
            Console.WriteLine("Player health: {0}", player.health);
            Console.WriteLine("Enemy Health: {0}", BigBaddy.health);

            var name = "josh";
            nam = "briar";

            Console.WriteLine(name);

        
        }
    }
}
