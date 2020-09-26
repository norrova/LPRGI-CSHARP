using System;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero v_hero = new Hero("Luke Skywalker", 2400, 300);
            Game v_game = new Game(v_hero);
            v_game.Play();
            v_game.ShowScore();
        }
    }
}
