using GameCharacter;
using GameInventory;
using GameWeapon;
using System;

namespace GameEntity{
    class Entity : Inventory{
        public string name {get; private set;}
        public int maxhealth{get; private set;}
        public int health {get; private set;}
        public string description {get; private set;}
        public bool breakable {get;private set;}
        private int Damage {get;set;}
        public int damage {get => this.Damage;private set {this.Damage = value * -1;}}
        protected Inventory inventory {get;set;}
        
        public void Inventory(Entity entity) => base.Add(entity);
        public void Inventory() => base.CheckInventory();
        protected Entity(string name, int health, string description, bool breakable, bool hasInventory, int damage): base(){
            this.name = name;
            this.health = health;
            this.description = description;
            this.breakable = breakable;
            this.damage = damage; 
            this.maxhealth = this.health;
            
            //Console.WriteLine("Weapon Name: {0}, Weapon Damage {1}",this.name, this.damage);
        }
        public void GiveName(string name){
            this.name = name;
        }
        public void AdjustHealth(int value){
            this.health = this.health + value >= this.maxhealth ? this.maxhealth : 
                (this.health + value <= 0 ? 0 : this.health + value);
        }
        public void SetHealth(int value){
            if((value) >= this.maxhealth){
                this.health = this.maxhealth;
            }else if(value <= 0 || (value == 1 && this.health ==1)){
                this.health = 0;
            }else{
                this.health = value;
            }
        }
        public void MaxHealth(int value){
            if((this.maxhealth + value)<= 1){
                this.maxhealth = 1;
            }else{
                this.maxhealth += value;
            }
            if(this.maxhealth<this.health){
                this.health = this.maxhealth;
            }
        }
        public void SetMaxHealth(int value){
            if(value <= 1){
                this.maxhealth = 1;
            }else{
                this.maxhealth = value;
            }
            if(this.health < this.maxhealth){
                this.health = this.maxhealth;
            }
        }
        public void Interact(Entity entityOne, Entity entityTwo){
            if((entityOne is Character)){

            }
        }
        //Throwable enitites, could be weapons, potions, etc.. 

    }
}