using FinalBattler.Interfaces;

namespace FinalBattler.Character.Upgrades
{
    public class Spell :IDamageCalculator
    {
        public string SpellName { get; set; }
        public int ManaCost { get; set; }
        public int BaseDamage { get; set; }

        public Spell(string name, int manaCost, int baseDamage)
        {
            SpellName = name;
            ManaCost = manaCost;
            BaseDamage = baseDamage;
        }

        public int CalculateDamage(int attackerPower)
        {
            return BaseDamage + (attackerPower / 2);
        }

        public void CastSpell(Hero hero)
        {
        }
    }
}
