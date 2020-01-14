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
            Console.WriteLine(((Character)entityOne));
            var y = ((Character)entityOne);
            Console.WriteLine(y.RightHand());
            var x = y.RightHand().name;
            Console.WriteLine(x);
            // var w = x.damage;
            entityTwo.AdjustHealth(3);
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