using System;
namespace game
{
    public class Hero : PnjInterface
    {
        private string m_name;
        private int m_lifePoint;
        private int m_attackValue;
        private int m_monsterKilled = 0;

        public string Name { get => m_name;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                m_name = value;
            }
        }
        public int LifePoint { get => m_lifePoint; set => m_lifePoint = value; }
        public int AttackValue { get => m_attackValue; }
        public int MonsterKilled { get => m_monsterKilled; set => m_monsterKilled = isPositive(value); }

        public Hero(string p_name,  int p_lifePoint, int p_attackValue)
        {
            LifePoint = isPositive(p_lifePoint);
            this.m_attackValue = isPositive(p_attackValue);
        }

        public int attack()
        {
            return AttackValue;
        }

        private int isPositive(int p_value)
        {
            if (p_value < 1)
                throw new ArgumentNullException();
            return p_value;
        }

        public override string ToString()
        {
            return $"Héros stats : [vie : {LifePoint}, Attaque : {this.AttackValue}]";
        }
    }
}
