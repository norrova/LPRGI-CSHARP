using System;
namespace game.Heros.Types
{
    public class Magicien : Hero
    {
        private double m_bonusLife = 1.10;
        private double m_bonusAttack = 1.20;

        protected override void SetAttackValue(int p_value)
        {
            this.m_attackValue = (int)(p_value * m_bonusAttack);
        }

        public Magicien(int p_lifePoint, int p_attackValue, int p_monsterKilled) : base(p_lifePoint, p_attackValue, p_monsterKilled)
        {
            LifePoint = (int)(p_lifePoint * m_bonusLife);
        }
    }
}
