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
            Random randInt = new Random();
            //action2 = int.Parse(Console.ReadLine());
                        //need to make this an if statement to run a choice isntead of all 3
            
            switch(CombatClass)
            {
                case CombatClass.Warrior:                  
                    Health = Health + randInt.Next(1,15); // health 1-15 
                    Power = Power + randInt.Next(3, 5);
                    Luck = Luck + randInt.Next(1,3);
                    break;      
                
                case CombatClass.Wizard: //added wizard because creations.cs
                             //starter code has it                  
                    Health = Health + randInt.Next(10,20); // health 1-15 
                    Power = Power + randInt.Next(1, 3);
                    Luck = Luck + randInt.Next(1,3);
                    break;      

                case CombatClass.Rogue:
                     Health = Health + randInt.Next(1,15); // health 1-15 
                    Power = Power + randInt.Next(1, 3);
                    Luck = Luck + randInt.Next(3,5);
                    break;

                case CombatClass.Mage://add values to stats player already has             
                        //Health randInt.Next(1,15)
                        //power 1-3
                        //Luck 3-5
                    break;      
            }
        }
        //might have to put it up here to declare it
        //string statsToDisplay = showTotalStats ? Hero.GetTotalStats() : Hero.GetNaturalStats();
        public void DisplayStats(bool showTotalStats = false, string GetTotalStats, string GetNaturalStats)
        {    //might have to change from string                    //maybe stats^ from calculatetotal
           string statsToDisplay = showTotalStats ? Hero.GetTotalStats() : Hero.GetNaturalStats();
        }                                      //maybe invent Player
        public void CalculateTotals()//what does that mean? The idea is that 
        {                               //your character has certain stats
            //GetNatural                //and your equipment stats to that 
            //GetTotal                  //if you want to make some adjustments
                                        //to that your probably fine               
        }

        public string GetTotalStats(Enum Equipment)
        {
            return "you're weak but kinda stacked tho";
            /* //implementation idea
            if (has Equipment = true) add 30
            Slot; ???????
            StatBoostType; add boost value
            BoostValue; add that much
             */
        }                            
                                      
        public string GetNaturalStats(Enum Equipment)
        {
            return "You're Strong!";
            //more code
        }         
    } // end of public class Hero                                   
}//whole end in namespace

