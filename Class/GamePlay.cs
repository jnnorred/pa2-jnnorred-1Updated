using System;

namespace pa2_jnnorred_1Updated
{
    public class GamePlay
    {
        public int Play(){ //final
            Menus menu = new Menus();
            CharUtil user = new CharUtil();
            Character player = user.CreateUser(); 
            Character cpu = user.SelectCpu(); 
            double damage = 0; 
            int round = 0; 
            menu.GameInfo(round, cpu, player); 
            Random rnd = new Random(); 
            int playerTurn = rnd.Next(1,3); 

            while(player.Health > 0 && cpu.Health > 0){
            
                if (playerTurn%2 != 0)
                {
                    damage = player.actionBehavior.Attack(damage,cpu.actionBehavior.Type(), player, cpu);
                }
                else
                {
                    damage = cpu.actionBehavior.Attack(damage,player.actionBehavior.Type(), cpu, player);
                }
                round++; 
                if(player.Health > 0 && cpu.Health > 0)
                {
                    menu.RoundInfo(round, damage, playerTurn, cpu, player); 
                    menu.GameInfo(round, cpu, player);
                    playerTurn++; 
                }
            }
            menu.GameOver(round, cpu, player); 
            return menu.RestartMenu(); 
        }
    }

}