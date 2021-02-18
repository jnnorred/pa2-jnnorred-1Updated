using System;

namespace pa2_jnnorred_1Updated
{
    public class Wind : IAction //final
    {
        public double Attack(double damage, string oppPower, Character attacker, Character defender)
        {
            Random rnd = new Random(); 
            int attackPower = rnd.Next(1, attacker.MaxPower); 
            int defendPower = rnd.Next(1, defender.MaxPower);
            if (oppPower == "Earth")
            {
                damage = Math.Abs((attackPower - defendPower)*(1)); 
                defender.Health -= damage; 
            }
            else if (oppPower == "Wind")
            {
                damage = Math.Abs((attackPower - defendPower)*(1)); 
                defender.Health -= damage; 
            }
            else if (oppPower == "Fire")
            {
                damage = Math.Abs((attackPower - defendPower)*(1.2)); 
                defender.Health -= damage; 
            }
            if (defender.Health <= 0)
            {
                defender.Health = 0; 
            }
            return damage;

        }
        public string Type()
        {
            return "Wind"; 
        }
        
    }
}


        //Earth beats air
        //Air beats fire
        //fire beats earth
        //Damage Dealt = (Attacker’s Attack Power – Defender’s Defense Power) * (Type Bonus)