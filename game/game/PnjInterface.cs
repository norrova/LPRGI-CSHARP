using System;
namespace game
{
    public interface PnjInterface
    {
        string Name { get; }
        int LifePoint { get; set; }
        int AttackValue { get; }

        int attack();
    }
}
