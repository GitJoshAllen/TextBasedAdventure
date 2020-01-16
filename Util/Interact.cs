using System;
using GameCharacter;
using GameEntity;
using GameWeapon;

namespace GameInteract{
    static class Interact{
        const string attack = "ATTACK";
        const string defend = "DEFEND";
        const string heal = "HEAL";
        const string talk = "TALK";
        static public void Combat(Entity entityOne, Entity entityTwo){
            if(entityOne is Character && entityTwo is Character){
                while(entityOne.health > 0 && entityTwo.health > 0){
                    var command = CombatQuestion();
                    if(((Character)entityOne).player){
                        Character player = ((Character)entityOne);
                        switch(command){
                            case Interact.attack:
                                Console.WriteLine("\nWhat shall you attack with?: ");
                                player.CheckWeaponInventory();
                                var weaponName = Interact.ReadLine();
                                var weapon = player.PullWeapon(weaponName);
                                Attack(weapon, entityTwo);
                                Attack(entityTwo, entityOne);
                            break;
                            case Interact.defend:
                                Defend();
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
        static private void Attack(Entity attacker, Entity attackee){
            attackee.AdjustHealth(((Character)attacker).damage);
            Console.WriteLine("{1} Health: {0}", attackee.health, attackee.name);
        }
        static private void Attack(Weapon weapon, Entity entityTwo){
            entityTwo.AdjustHealth(weapon.damage);
            Console.WriteLine("{1} Health: {0}", entityTwo.health, entityTwo.name);
        }
        static private void Defend(){
            Console.WriteLine("Block!");
        }
        static private string CombatQuestion(){
                Console.WriteLine("\n{0} | {1} | {2} | {3}", Interact.attack, Interact.defend, Interact.heal, Interact.talk);
                var command = Interact.ReadLine();
                return command;
        }
        static public string ReadLine(){
            return Console.ReadLine().ToUpper();
        }
    }
}