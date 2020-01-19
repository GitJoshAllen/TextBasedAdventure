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
                                Defend(entityOne, entityTwo);
                            break;
                            case Interact.heal:
                                Console.WriteLine("\nWhich item will you use to heal?: ");
                                player.CheckConsumableInventory();
                                var consumableName = Interact.ReadLine();
                            break;
                            default:
                            break;
                        }
                        Console.WriteLine("{1} Health: {0}", entityTwo.health, entityTwo.name);
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
        }
        static private void Attack(Weapon weapon, Entity entityTwo){
            entityTwo.AdjustHealth(weapon.damage);
        }
        static private void Consume(Entity item, Entity patient){
            patient.AdjustHealth(item.damage);
        }
        static private void Defend(Entity player, Entity enemy){
            switch(((Character)enemy).race.ToUpper()){
                case Character.orc:
                    Console.WriteLine("{0} no like block! Me want u to hurt!", enemy.name);
                break;
                case Character.skeleton:
                    Console.WriteLine("Block? Like... Def?.. like a rock?! NOO!!!");
                    enemy.AdjustHealth(-20);
                break;
                case Character.goblin:
                    Console.WriteLine("{0} is quick, it gets past your defence", enemy.name);
                    player.AdjustHealth(enemy.damage / 2);
                break;
                default:
                    Console.WriteLine("Invalid Entity");
                break;
            }
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