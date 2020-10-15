using System;
namespace game.Heros.Types
{
    public class Archer : Hero
    {
        private double m_bonusLife = 1.15;
        private double m_bonusAttack = 1.15;

        protected override void SetAttackValue(int p_value)
        {
            this.m_attackValue = (int)(p_value * m_bonusAttack);
        }

        public Archer(int p_lifePoint, int p_attackValue, int p_monsterKilled) : base(p_lifePoint, p_attackValue, p_monsterKilled)
        {
            LifePoint = (int)(p_lifePoint * m_bonusLife);
        }
    }
}
