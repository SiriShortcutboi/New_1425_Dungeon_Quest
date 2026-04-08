using System.ComponentModel;

namespace FinalBattler.Character.Upgrades
{
    public class Item
    {
        public string ItemName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ItemPower { get; set; }

        public Item()
        {
        }

        public Item(string name, string description)
        {
            ItemName = name;
            Description = description;
            //A1 you have to run through the levels, interface says i must calculate damage
            //2 what do you damage people with
            //3 where does that thing get its info
            //B1 how do people do damage to you? polymorphically
        }
    }
}
