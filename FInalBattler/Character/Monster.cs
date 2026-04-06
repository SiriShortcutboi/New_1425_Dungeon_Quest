using FinalBattler.Interfaces;

namespace FinalBattler.Character
{
    public class Monster : Creations, IDamageCalculator
    {
        public int CalculateDamage(int attackerPower)
        {
            // use attack power and scale it by monster level
            return attackerPower + Math.Max(1, Level);
        }
    }
}