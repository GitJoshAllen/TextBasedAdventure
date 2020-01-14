using System;
using System.Collections.Generic;
using GameEntity;
using GameWeapon;
//How to handle entities being equipped to primary and secondary slots
//
namespace GameInventory{
    class Inventory{
        private Entity primary {get;set;}
        private Entity Secondary {get;set;}
        private List<Weapon> Weapons {get; set;}
        protected Inventory(){}
        protected void Add(Entity entity){
            switch(entity){
                case Weapon weapon:
                    if(this.Weapons == null){
                        this.Weapons = new List<Weapon>();
                    }
                    if(!this.Weapons.Contains(weapon)) {
                        this.Weapons.Add(weapon);
                    }
                break;
            }
        }
        protected void EquipPrimary(Entity entity){
            this.primary = entity;
        }
        protected void EquipSecondary(Entity entity){
            this.Secondary = entity;
        }
        protected void CheckInventory(){
            Console.WriteLine("Weapons:");
            this.Weapons.ForEach( w => {Console.WriteLine(w.name);});
            Console.WriteLine("----------------");
        }
        public Entity GetPrimary(){
            return this.primary;
        }
        protected Entity Primary(){
            return this.primary;
        }
    }
}