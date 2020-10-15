using System;

namespace game
{
    public abstract class Pnj
    {
        protected int m_lifePoint;
        protected int m_attackValue;

        public int LifePoint
        {
            get => m_lifePoint;
            set
            {
                m_lifePoint = value > 0 ? value : 0;
            }
        }
        public int Attack { get => m_attackValue; }

        protected virtual void SetAttackValue(int p_value)
        {
            this.m_attackValue = p_value;
        }

        public Pnj(int p_lifePoint, int p_attackValue)
        {
            LifePoint = IsPositive(p_lifePoint);
            SetAttackValue(IsPositive(p_attackValue));
        }

        protected int IsPositive(int p_value)
        {
            if (p_value < 1)
                throw new ArgumentNullException();
            return p_value;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} : [vie : {LifePoint}, Attaque : {this.Attack}]";
        }
    }
}
