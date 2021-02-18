using System;

namespace pa2_jnnorred_1Updated
{
    public class Menus
    {
        IAction actionBehavior; 
        public int Instructions(){
            Console.WriteLine("\t Welcome to Battle of the Ages"); 
            Console.WriteLine("\t\tInstructions:");
            Console.WriteLine("After you make your character you will fight the enemy! \n First person's health that falls to 0 loses");
            Console.WriteLine("\nPress Enter to Begin");
            Console.ReadKey(); 
            return 1; 
        }
        public string CharacterName(){
            Console.Clear();
            Console.WriteLine("Enter your Characters Username: "); 
            Console.WriteLine(); 
            Console.Write(": "); 
            return Console.ReadLine(); 
        }
        public IAction CharacterType(string characterName){
            Console.Clear(); 
            Console.WriteLine($"Choose {characterName} power type:  "); 
            Console.WriteLine("1) Earth"); 
            Console.WriteLine("2) Air"); 
            Console.WriteLine("3) Fire");
            Console.WriteLine();
            Console.Write(": "); 
            int userInput = int.Parse(Console.ReadLine()); 
            if (userInput == 1 )
            {
                return actionBehavior = new Earth(); 
            }
            else if (userInput == 2)
            {
                return actionBehavior = new Wind();  
            }
            else
            {
                return actionBehavior = new Fire(); 
            }
        }
        public void RoundInfo(int round, double damage, int playerTurn, Character cpu, Character player){
            Console.Clear(); 
            if (playerTurn%2 != 0)
            {
                Console.WriteLine($"\n\n\t ROUND {round} SUMMARY:");
                Console.WriteLine($"{player.Name} used a {player.actionBehavior.Type()} attack, {cpu.Name} defended with {cpu.actionBehavior.Type()} defense");
                Console.WriteLine($"Damage Dealt to {cpu.Name} : {Math.Round(damage)} damage\n"); 
            }
            else
            {
                Console.WriteLine($"\n\n\t ROUND {round} SUMMARY:");
                Console.WriteLine($"{cpu.Name} used a {cpu.actionBehavior.Type()} attack, {player.Name} defended with {player.actionBehavior.Type()} defense");
                Console.WriteLine($"Damage Dealt to {player.Name} : {Math.Round(damage)} damage\n"); 
            }
            
        }
        public void GameInfo(int round, Character cpu, Character player){
            if (round == 0)
            {
                Console.Clear(); 
            }
            Console.WriteLine("\tPlayer Summary\n"); 
            Console.WriteLine(player.Name + "\t\t" + cpu.Name);
            Console.WriteLine("Power: " + player.actionBehavior.Type() + "\t" + "Power: " + cpu.actionBehavior.Type());
            Console.WriteLine("Health: " + Math.Round(player.Health) + "\t" + "Health: " + Math.Round(cpu.Health));
            Console.WriteLine("\nROUNDS: " + round); 
            Console.WriteLine("\n");
            if (round == 0)
            {
                Console.WriteLine("Press Enter to Start Game"); 
            }else{

                Console.WriteLine($"Press Enter to move to Continue to Round {round +1} ");
            }
            Console.ReadKey(); 
        }
        public int RestartMenu(){
            Console.WriteLine("Enter choice: ");
            Console.WriteLine("1) New Game");
            Console.WriteLine("2) Exit");
            Console.WriteLine(); 
            Console.Write(": "); 
            return int.Parse(Console.ReadLine()); 
        }
        public void GameOver(int round, Character cpu, Character player){
            Console.Clear(); 
            Console.WriteLine("GAMEOVER\n");
            if (cpu.Health <= 0)
            {
                Console.WriteLine($"{player.Name} WINS\n"); 
                Console.WriteLine($"{cpu.Name} LOST\n\n"); 

                
            }else{
                Console.WriteLine($"{cpu.Name} WINS\n"); 
                Console.WriteLine($"{player.Name} LOST\n\n"); 
            }
            Console.WriteLine("Press Enter to Continue"); 
            Console.ReadKey(); 


        }
    }
} //final