using System;
using game.Heros;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero v_hero = new Hero(100, 70);
            GestionnaireDePartie v_game = new GestionnaireDePartie(v_hero);
            v_game.Play();
            v_game.ShowScore();
        }
    }
}
