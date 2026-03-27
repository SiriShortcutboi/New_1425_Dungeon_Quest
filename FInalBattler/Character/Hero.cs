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
            // “Unknown” name, 
            // level 0, 
            // all stats SET TO 1


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
        public void DisplayStats(bool showTotalStats = false)
        {    //might have to change from string                    //maybe stats^ from calculatetotal
           string statsToDisplay = showTotalStats ? GetTotalStats() : GetNaturalStats();
        }                                      //maybe invent Player
        public void CalculateTotals()//what does that mean? The idea is that 
        {                               //your character has certain stats
            //GetNatural                //and your equipment stats to that 
            //GetTotal                  //if you want to make some adjustments
                                        //to that your probably fine               
        }

        public string GetTotalStats() //just get experience navigating
        {
            //go and actually make stats
            return "you're weak but kinda stacked tho";
            /* //implementation idea
            if (has Equipment = true) add 30
            Slot; ???????
            StatBoostType; add boost value
            BoostValue; add that much
             */
        }                            
                                      
        public string GetNaturalStats()
        {
            return "You're Strong!";
            //more code
        }         
    } // end of public class Hero                                   
}//whole end in namespace

