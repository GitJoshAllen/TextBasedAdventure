using System;
using GameEntity;
//not add
namespace GameWeapon{

    class Weapon : Entity
    {
        public bool sharp {get; private set;}
        public bool twoHanded {get; private set;}
        public Weapon(string name, int health, string description, bool breakable, bool sharp, bool hasInventory, int damage, bool twoHanded) : base(name, health, description, breakable, hasInventory, damage){
            Console.WriteLine("In weapon");
            Console.WriteLine(name);

            Console.WriteLine(damage);
            this.sharp = sharp;
            this.twoHanded = twoHanded;
        }

        public string Name(){
            return base.name;
        }
        public bool Sharp(){
            return this.sharp;
        }
        
        static public Weapon Knife(){
            return new Weapon("Knife", 10, "Golden sharp", false, true, false, 5, false);
        }
        static public Weapon MorningStar(){
            return new Weapon("Morning Star", 100, "Zombie killer", false, false, false, 25, false);
        }
        static public Weapon Hammer(){
            return new Weapon("Hammer", 120, "Blunt one handed weapon", false, false, false, 3, false);
        }
        static public Weapon Spear(){
            return new Weapon("Spear", 101, "Two handed pointed thrusting-throwable weapon", false, true, false, 10, true);
        }

    }
}