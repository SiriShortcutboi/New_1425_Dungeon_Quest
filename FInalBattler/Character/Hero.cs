using FinalBattler.Character.Upgrades;
using FinalBattler.Interfaces;

namespace FinalBattler.Character
{ //do i expect you to use all the things available to you, no this
  // assignment is about organization -Mr jensen
  // if you want to make some adjustments to this your probably fine
    public class Hero : Creations, IHero
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Skill> Skills { get; set; }
        public List<Spell> Spells { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            //Implement Hero empty constructor:
            //New Heros start with:
            this.Name = "Unkown"; // “Unknown” name, 
            this.Level = 1; 
            // all stats SET TO 1 Health Power Luck mana ExperienceRemaining
            this.Health = 1;
            this.Power = 1;
            this.Luck = 1;
            this.Mana = 1;
            this.ExperienceRemaining = 1;
            this.Items = new List<Item>();
            this.Skills = new List<Skill>();
            this.Spells = new List<Spell>();
            this.Equipment = new List<Equipment>();

        }
        public void LevelUp()
        {
            switch (CombatClass)
            {                          //I found a case of polymorphism in the wild 
                case CombatClass.Mage:      // this style allows both cases to hit:                        
                case CombatClass.Wizard:                       // the same results:
                    Health += Random.Shared.Next(1, 16);// 1-15
                    Power += Random.Shared.Next(3, 6);  // 3-5
                    Luck += Random.Shared.Next(1, 4);   // 1-3
                    break; //I learned that using Shared gives you better random 
                    // results using 1 seed per game, and then changing things 
                    // up next time the program/game runs. Might make it less funny
                    //though

                case CombatClass.Warrior:
                    Health += Random.Shared.Next(10, 21);  // 10-20
                    Power += Random.Shared.Next(1, 4);     // 1-3
                    Luck += Random.Shared.Next(1, 4);      // 1-3
                    break;

                case CombatClass.Rogue:
                    Health += Random.Shared.Next(1, 16);   // 1-15
                    Power += Random.Shared.Next(1, 4);     // 1-3
                    Luck += Random.Shared.Next(3, 6);      // 3-5
                    break;

                default:
                    break;
            }
        }
        //might have to put it up here to declare it
        //string statsToDisplay = showTotalStats ? Hero.GetTotalStats() : Hero.GetNaturalStats();
        public string DisplayStats(bool showTotalStats = false)
        {    //might have to change from string                    //maybe stats^ from calculatetotal
            string statsToDisplay = showTotalStats ? GetTotalStats() : GetNaturalStats();
            return statsToDisplay;
        }                                      //maybe invent Player
        public void CalculateTotals()//what does that mean? The idea is that 
        {                               //your character has certain stats
            var bonuses = GetEquipmentBonuses();
            int totalHealth = Health + bonuses.healthBonus;
            TotalPower = Power + bonuses.powerBonus;
            TotalLuck = Luck + bonuses.luckBonus;
            Totals = totalHealth + TotalPower + TotalLuck;
        }
                                        //just get experience navigating structures 
        public string GetTotalStats() 
        {
            var bonuses = GetEquipmentBonuses();
            int totalHealth = Health + bonuses.healthBonus;
            int totalPower = Power + bonuses.powerBonus;
            int totalLuck = Luck + bonuses.luckBonus;

            TotalPower = totalPower;
            TotalLuck = totalLuck;
            Totals = totalHealth + totalPower + totalLuck;

            return $"Total Stats -> Health: {totalHealth}, Power: {totalPower}, Luck: {totalLuck}, Mana: {Mana}, Equipped Items: {Equipment.Count}";
        }                            
                                      
        public string GetNaturalStats()
        {
            return $"Natural Stats -> Health: {Health}, Power: {Power}, Luck: {Luck}, Mana: {Mana}";
        }

        private (int healthBonus, int powerBonus, int luckBonus) GetEquipmentBonuses()
        {
            int healthBonus = 0;
            int powerBonus = 0;
            int luckBonus = 0;

            foreach (var equippedItem in Equipment)
            {
                switch (equippedItem.StatBoostType)
                {
                    case StatBoostType.Health:
                        healthBonus += equippedItem.BoostValue;
                        break;
                    case StatBoostType.Power:
                        powerBonus += equippedItem.BoostValue;
                        break;
                    case StatBoostType.Luck:
                        luckBonus += equippedItem.BoostValue;
                        break;
                    default:
                        break;
                }
            }

            return (healthBonus, powerBonus, luckBonus);
        }         
    } // end of public class Hero                                   
}//whole end in namespace

