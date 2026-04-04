
using FinalBattler.Character;
using FinalBattler.Character.Upgrades;

public class Program
{ //do i expect you to use all the things available to you, no this
  // assignment is about organization -Mr jensen
    static void Main()
    {
        var hero = new Hero
        {
            Name = "Kara",
            CombatClass = CombatClass.Rogue,
            Health = 12,
            Power = 8,
            Luck = 6,
            Mana = 4
        };

        hero.Equipment.Add(new Equipment("Lucky Boots", EquipmentSlot.Boots, StatBoostType.Luck, 3));
        hero.Equipment.Add(new Equipment("War Band", EquipmentSlot.LeftArm, StatBoostType.Power, 2));
        hero.Equipment.Add(new Equipment("Steel Chestplate", EquipmentSlot.Chest, StatBoostType.Health, 5));

        Console.WriteLine("=== Hero Stats ===");
        Console.WriteLine(hero.DisplayStats(false));
        Console.WriteLine(hero.DisplayStats(true));
    }
}

