using System;
using System.Collections.Generic;
using Generic.Sample.Card;

namespace Generic.Sample.Game
{
    public class JeuFrancais {

        HashSet<string> m_colors = new HashSet<string>() {
            "pique",
            "coeur",
            "carreau",
            "trefle"
        };
        HashSet<string> m_types = new HashSet<string>() {
            "Roi",
            "Dame",
            "Valet",
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "As"
        };
        HashSet<CustomCard> m_cards = new HashSet<CustomCard>();

        public JeuFrancais()
        {
        }

        public void Init()
        {
            foreach(var v_color in m_colors)
            {
                foreach(var v_type in m_types)
                {
                    m_cards.Add(new CustomCard(v_color, v_type));
                }
            }
        }

        public void Print()
        {
            Console.WriteLine($"Nombre de carte : {m_cards.Count}");
            foreach(var v_item in m_cards)
            {
                Console.WriteLine(v_item);
            }
        }

    }
}
