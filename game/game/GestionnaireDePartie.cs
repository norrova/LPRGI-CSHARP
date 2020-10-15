using System;
using System.Collections.Generic;

using game.Heros;
using game.Heros.Types;
using game.Monstres;
using game.Monstres.Types;

namespace game
{
    public class GestionnaireDePartie
    {
        private Hero m_hero;
        private Random m_rand = new Random();

        private List<Type> m_monsters = new List<Type>()
        {
            typeof(Gobelin),
            typeof(Sorciere),
            typeof(Squelette)
        };

        private List<Type> m_heros = new List<Type>()
        {
            typeof(Chevalier),
            typeof(Archer),
            typeof(Magicien)
        };

        public GestionnaireDePartie(Hero p_hero)
        {
            m_hero = p_hero;
        }

        public void Play()
        {
            var v_monster = (Monstre)RamdomMonsters();
            do
            {
                ShowStat(m_hero);
                ShowStat(v_monster);
                v_monster.LifePoint -= m_hero.Attack;
                ShowAttack(m_hero, v_monster);

                if (v_monster.LifePoint > 0)
                {
                    m_hero.LifePoint -= v_monster.Attack;
                    ShowAttack(v_monster, m_hero);
                }
                else
                {
                    m_hero.MonsterKilled++;
                    FindTreasure();
                    v_monster = (Monstre)RamdomMonsters();
                    CheckHeroEvolution();
                }
            } while (m_hero.LifePoint > 0);
        }

        
        public void ShowAttack(Pnj p_assailant, Pnj p_victim)
        {
            string v_pointPlurial = p_assailant.Attack > 1 ? "points" : "point";
            Console.WriteLine($"Le {p_assailant.GetType().Name} attaque (-{p_assailant.Attack} {v_pointPlurial}): {p_victim}");
        }

        public void ShowScore()
        {
            if (m_hero.LifePoint <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Votre héros est mort");
            }
            if (m_hero.MonsterKilled > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                string v_monsterPlurial = m_hero.MonsterKilled > 1 ? "monstres" : "monstre";
                Console.WriteLine($"Votre héros a assassiné {m_hero.MonsterKilled} {v_monsterPlurial} !");
            }
            Console.ResetColor();
        }

        private void ShowStat(Pnj p_pnj)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"Informations : {p_pnj}");
            Console.ResetColor();
        }


        public void FindTreasure()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Votre héros à battus le monstre !");

            int v_lucky = m_rand.Next(1, 100);
            int v_balance = m_rand.Next(1, 100);
            int v_life = m_rand.Next(1, v_balance);

            string v_pointPlurial = v_life > 1 ? "points" : "point";

            if (v_lucky >= v_balance)
            {
                Console.WriteLine($"Votre héros a gagné {v_life} {v_pointPlurial} de vie.");
                m_hero.LifePoint += v_life;
            }
            else
            {
                Console.WriteLine($"Votre héros est tombé dans un piège il a perdu {v_life} {v_pointPlurial} de vie.");
                m_hero.LifePoint -= v_life;
            }
            Console.ResetColor();
            Console.WriteLine(Environment.NewLine);
        }

        private void CheckHeroEvolution()
        {
            if (5 == m_hero.MonsterKilled)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                m_hero = (Hero)RamdomHerosSpe();
                Console.WriteLine($"Evolution du héros en : {m_hero.GetType().Name}");
            }
            Console.ResetColor();
        }

        private Object RamdomMonsters()
        {
            Type v_type = GetAleatoryType(m_monsters);
            int v_life = 0, v_attack = 0;
            if (v_type == typeof(Gobelin))
            {
                v_life = m_rand.Next(39, 50);
                v_attack = m_rand.Next(50, 100);
            }
            else if (v_type == typeof(Squelette))
            {
                v_life = m_rand.Next(70, 100);
                v_attack = m_rand.Next(5, 25);
            }
            else if (v_type == typeof(Sorciere))
            {
                v_attack = m_rand.Next(5, 25);
                v_life = m_rand.Next(70, 100);
            }
            return Activator.CreateInstance(v_type, v_life, v_attack);
        }

        private Object RamdomHerosSpe()
        {
            return Activator.CreateInstance(GetAleatoryType(m_heros), m_hero.LifePoint, m_hero.Attack, m_hero.MonsterKilled);
        }

        private Type GetAleatoryType(List<Type> p_type)
        {
            int v_index = m_rand.Next(0, m_heros.Count);
            return p_type[v_index];
        }
    }
}
