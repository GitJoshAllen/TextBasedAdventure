using System;
using GameCharacter;
using GameEntity;

namespace GameInteract{
    static class Interact{
        static public void Combat(Entity entityOne, Entity entityTwo){
            if(entityOne is Character && entityTwo is Character){
                while(entityOne.health > 0 || entityTwo.health > 0){
                    var command = CombatQuestion();
                    if(((Character)entityOne).player){
                        switch(command){
                            case "ATTACK":
                                Attack(entityOne, entityTwo);
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
            entityTwo.AdjustHealth(((Character)entityOne).RightHand().damage);
            
            Console.WriteLine("Player health: {0}", entityOne.health);
            Console.WriteLine("Enemy Health: {0}", entityTwo.health);
        }
        static private string CombatQuestion(){
                Console.WriteLine("Attack | Defend | Heal | Talk");
                var command = Console.ReadLine().ToUpper();
                return command;
        }
    }
}