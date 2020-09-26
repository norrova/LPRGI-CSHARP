using System;
namespace game
{
    public class Monster
    {
        private string m_name;
        private int m_lifePoint;
        private int m_attackValue;

        public string Name
        {
            get => m_name;
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException();
                m_name = value;
            }
        }
        public int LifePoint { get => m_lifePoint; set => m_lifePoint = value; }
        public int AttackValue { get => m_attackValue; }

        public Monster()
        {
            Random v_rand = new Random();
            LifePoint = v_rand.Next(1, 2000);
            this.m_attackValue = v_rand.Next(1, 1000);
        }

        public int attack()
        {
            return AttackValue;
        }

        public override string ToString() {
            return $"Monstre stats : [vie : {LifePoint}, Attaque : {this.AttackValue}]";
        }
    }
}
