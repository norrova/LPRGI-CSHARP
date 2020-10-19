﻿using System;
namespace game.Heros
{
    public class Hero : Pnj
    {        
        private int m_monsterKilled; 
        public int MonsterKilled { get => m_monsterKilled; set => m_monsterKilled = value; }

        public Hero(int p_lifePoint, int p_attackValue) : base(p_lifePoint, p_attackValue)
        {
            
        }

        public Hero(int p_lifePoint, int p_attackValue, int p_monsterKilled) : base(p_lifePoint, p_attackValue)
        {
            MonsterKilled = p_monsterKilled >= 0 ? p_monsterKilled : 0;
        }
    }
}
