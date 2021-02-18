namespace pa2_jnnorred_1Updated
{
    public interface IAction
    {
        public double Attack(double damage, string oppPower, Character attacker, Character defender); 
        
        public string Type(); 
    }
}