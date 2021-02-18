using System;
using System.Collections.Generic;

namespace pa2_jnnorred_1Updated
{
    public class CharUtil 
    {
        public Character CreateUser(){
            Menus menu = new Menus();
            Random rnd = new Random();
            string userName = menu.CharacterName(); 
            int maxPower = rnd.Next(1,101); 
            Character userCharacter = new Character(){Name = userName, MaxPower = maxPower, Health = 100}; 
            userCharacter.SetAttackBehavior(menu.CharacterType(userName)); 
            return userCharacter; //final
        }
        public List<Character> CreateCpu(){
            List<Character> cpu = new List<Character>();
            Random rnd = new Random();
            int maxPower = rnd.Next(1,101); 
            cpu.Add(new Character(){Name = "Ozai", MaxPower = maxPower, Health = 100});
            cpu[0].SetAttackBehavior(new Fire());  
            cpu.Add(new Character(){Name = "Zaheer", MaxPower = maxPower, Health = 100}); 
            cpu[1].SetAttackBehavior(new Wind()); 
            cpu.Add(new Character(){Name = "Kuvira", MaxPower = maxPower, Health = 100}); 
            cpu[2].SetAttackBehavior(new Earth()); 
            cpu.Add(new Character(){Name = "Sozun", MaxPower = maxPower, Health = 100}); 
            cpu[3].SetAttackBehavior(new Fire()); 
            cpu.Add(new Character(){Name = "Yakone", MaxPower = maxPower, Health = 100}); 
            cpu[4].SetAttackBehavior(new Wind()); 
            cpu.Add(new Character(){Name = "Ghazan", MaxPower = maxPower, Health = 100}); 
            cpu[5].SetAttackBehavior(new Earth()); 
            return cpu; 
        }
        public Character SelectCpu(){
            List<Character> cpu = CreateCpu(); 
            Random rnd = new Random(); 
            int cpuChoice = rnd.Next(0,6); 
            return cpu[cpuChoice]; 
        }
    }
    
}