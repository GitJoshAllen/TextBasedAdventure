using GameEntity;
using GameInventory;
namespace GameCharacter{
    class Character : Entity{
        private string race {get;set;}
        private string job {get;set;}
        public Character(string name, int health, string description, bool breakable, bool hasInventory, int damage, string race, string job) : base(name, health, description, breakable, hasInventory, damage){
            this.race = race;
            this.job = job;
            this.inventory = base.inventory;
        }
        public void Equip(Entity entity){

        }
        public void EquipRightHand(Entity entity) => base.Primary(entity);
        public void EquipLeftHand(Entity entity) => base.Secondary(entity);
        public Entity RightHand(){
            return base.Primary();
        }
        
        static public Character OrcWizard(){
            return new Character("Orc Wizard", 100, "Orc trained in the arcane arts", false, true, 1, "Orc", "Wizard");
        }
    }
}