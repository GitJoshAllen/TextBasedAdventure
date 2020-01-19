using System;
using System.Collections.Generic;
using GameEntity;
using GameWeapon;
using GameConsumable;
//How to handle entities being equipped to primary and secondary slots
//
namespace GameInventory{
    class Inventory{
        private List<Weapon> Weapons {get; set;}
        private List<Consumable> Consumables {get;set;}
        protected Inventory(){}
        public void Add(Entity entity){
            switch(entity){
                case Weapon weapon:
                    if(this.Weapons == null){
                        this.Weapons = new List<Weapon>();
                    }
                    if(!this.Weapons.Contains(weapon)) {
                        this.Weapons.Add(weapon);
                    }
                break;
                default:
                    Console.WriteLine("Could not add to inventory");
                break;
            }
        }
        public void CheckInventory(){
            Console.WriteLine("Weapons:");
            this.Weapons.ForEach( w => {Console.WriteLine(w.name);});
            Console.WriteLine("----------------");
        }
        public void CheckWeaponInventory(){
            Console.WriteLine("Weapons:");
            this.Weapons.ForEach(w => {Console.WriteLine(w.name);});
            Console.WriteLine("----------------");
        }
        public void CheckConsumableInventory(){
            Console.WriteLine("Consumables:");
            this.Consumables.ForEach(w => {Console.WriteLine(w.name);});
            Console.WriteLine("----------------");
        }
        public Weapon PullWeapon(string name){
            return this.Weapons.Find(w => w.name.ToUpper() == name.ToUpper());
        }
        
        public Consumable PullConsumable(string name){
            return this.Consumables.Find(c => c.name.ToUpper() == name.ToUpper);
        }

        


    }
}