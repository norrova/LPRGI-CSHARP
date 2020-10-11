using System;
namespace game
{
    public class Game
    {
        private Hero m_hero;

        public Game(Hero p_hero)
        {
            m_hero = p_hero;
        }

        public void Play()
        {
            Monster v_monster = new Monster();
            do
            {
                Console.WriteLine(m_hero);
                Console.WriteLine(v_monster);
                v_monster.LifePoint -= m_hero.attack();
                if (v_monster.LifePoint > 0)
                    m_hero.LifePoint -= v_monster.attack();
                else
                {
                    m_hero.MonsterKilled++;
                    FindTreasure();
                    v_monster = new Monster();
                    Console.WriteLine("");
                }
            } while (m_hero.LifePoint > 0);
        }

        public void FindTreasure()
        {
            int v_lucky = new Random().Next(1, 100);
            int v_balance = new Random().Next(1, 100);
            if (v_lucky >= v_balance)
            {
                int v_bonusLife = new Random().Next(1, 100);
                string v_pointPlurial = v_bonusLife > 1 ? "points" : "point";
                Console.WriteLine($"Votre héros a gagné {v_bonusLife} {v_pointPlurial} de vie.");
                m_hero.LifePoint += v_bonusLife;
            }
            else
            {
                int v_damageLife = new Random().Next(1, 100);
                string v_pointPlurial = v_damageLife > 1 ? "points" : "point";
                Console.WriteLine($"Votre héros est tombé dans un piège il a perdu {v_damageLife} {v_pointPlurial} de vie.");
                m_hero.LifePoint -= v_damageLife;
            }
        }

        public void ShowScore()
        {
            if (m_hero.LifePoint <= 0)
                Console.WriteLine("Votre héros est mort");
            if (m_hero.MonsterKilled > 0)
            {
                string v_monsterPlurial = m_hero.MonsterKilled > 1 ? "monstres" : "monstre";
                Console.WriteLine($"Votre héros a assassiné {m_hero.MonsterKilled} {v_monsterPlurial} !");
            }
        }
    }
}
