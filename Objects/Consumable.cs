using GameEntity;
namespace GameConsumable{
    class Consumable : Entity
    {
        public Consumable(string name, int health, string description, bool breakable, bool hasInventory, int damage): base(name, health, description, breakable, hasInventory, damage){

        }
        static public Consumable HealthPotion(){
            return new Consumable("Health Potion", 1, "A small vial of magic juice", false, false, 50);
        }
    }
}