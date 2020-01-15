using System;
using GameCharacter;
using GameEntity;
using GameWeapon;

namespace GameInteract{
    static class Interact{
        static public void Combat(Entity entityOne, Entity entityTwo){
            if(entityOne is Character && entityTwo is Character){
                while(entityOne.health > 0 && entityTwo.health > 0){
                    var command = CombatQuestion();
                    if(((Character)entityOne).player){
                        Character player = ((Character)entityOne);
                        switch(command){
                            case "ATTACK":
                                Console.WriteLine("\nWhat shall you attack with?: ");
                                player.CheckWeaponInventory();
                                var weaponName = Interact.ReadLine();
                                var weapon = player.PullWeapon(weaponName);
                                Attack(weapon, entityTwo);
                            break;
                            default:
                            break;
                        }
                    }else{

                    }
                    // if(((CHaracter)enitiyOne).player){

                    // }else{

                    // }
                }
            }
        }
        static private void Attack(Entity entityOne, Entity entityTwo){
            entityTwo.AdjustHealth(((Character)entityOne).damage);
            Console.WriteLine("Player health: {0}", entityOne.health);
            Console.WriteLine("Enemy Health: {0}", entityTwo.health);
        }
        static private void Attack(Weapon weapon, Entity entityTwo){
            entityTwo.AdjustHealth(weapon.damage);
            Console.WriteLine("Enemy Health: {0}", entityTwo.health);
        }
        static private string CombatQuestion(){
                Console.WriteLine("\nAttack | Defend | Heal | Talk");
                var command = Interact.ReadLine();
                return command;
        }
        static public string ReadLine(){
            return Console.ReadLine().ToUpper();
        }
    }
}