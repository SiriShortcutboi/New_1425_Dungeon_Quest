namespace FinalBattler.Interfaces
{
    public interface IHero
    {//this adds to your squiggle errors menu, it tells your list system 
    // this thing does not have these requirements  
        void DisplayStats(bool showTotalStats = false);
        void LevelUp();
        void CalculateTotals();
    }
}
