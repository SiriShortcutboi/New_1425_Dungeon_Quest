namespace FinalBattler.Character
{
    public class Creations
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Totals { get; set; }
        public int TotalPower { get; set; }
        public int TotalLuck { get; set; }
    }

    public enum CombatClass
    {
        None = 0,
        Warrior = 1,
        Wizard = 2,
        Rogue = 3, 
        Mage = 4, //added mage because other starter code has it
    }
}
