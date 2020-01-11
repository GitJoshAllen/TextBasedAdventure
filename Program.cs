using System;
using GameInventory;
using GameWeapon;
using GameCharacter;
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
            BigBaddy.EquipRightHand(Hammer);
            Character player = new Character("Lorik", 100, "XXL PIMP", false, true, 1, "Human", "Lancer");
            player.EquipRightHand(Spear);
            Console.WriteLine("Primary object is: {0}", player.RightHand().name); 
            Console.WriteLine("You opponenent is {0}", BigBaddy.name);

            Interact(player, BigBaddy);
        }
    }
}
