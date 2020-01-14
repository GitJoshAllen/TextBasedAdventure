using System;
using GameCharacter;
using GameEntity;

namespace GameInteract{
    static class Interact{
        static public void Combat(Entity entityOne, Entity entityTwo){
            if(entityOne is Character && entityTwo is Character){
                
                while(entityOne.health > 0 || entityTwo.health > 0){
                    Console.WriteLine("Attack | Defend | Heal | Talk");
                    var command = Console.ReadLine();
                    if(((Character)entityOne).player){
                        
                    }else{

                    }
                    if(((CHaracter)enitiyOne).player){

                    }else{

                    }
                }
            }
        }
        static private void CombatQuestion(){

        }
    }
}