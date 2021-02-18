namespace pa2_jnnorred_1Updated
{
    public class Character
    {
        public string Name { get; set; }
        public int MaxPower { get; set; }
        public double Health { get; set; }
       
        public IAction actionBehavior;  

        public void SetAttackBehavior(IAction attack){
            actionBehavior = attack; 
        }
    }
}