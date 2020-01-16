using GameEntity;
using GameInventory;
namespace GameCharacter{
    class Character : Entity{
        private string race {get;set;}
        public string job {get; private set;}
        public bool player {get;set;}
        const string orc = "ORC";
        const string skeleton = "SKELETON";
        const string goblin = "GOBLIN";
        public Character(string name, int health, string description, bool breakable, bool hasInventory, int damage, string race, string job, bool player = false) : base(name, health, description, breakable, hasInventory, damage){
            this.race = race;
            this.job = job;
            this.inventory = base.inventory;
            this.player = player;
        }
        public void Equip(Entity entity){

        }

        static public Character OrcWizard(){
            return new Character("Orc Wizard", 103, "Orc trained in the arcane arts", false, true, 1, "Orc", "Wizard", false);
        }
    }
}