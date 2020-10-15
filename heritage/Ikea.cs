using System;
using System.Collections.Generic;
using System.Text;

namespace heritage
{
    public class Ikea
    {

        private string m_secteur;
        private List<Meuble> m_catalogue;

        public string Secteur { get => m_secteur; set => m_secteur = value; }
        public List<Meuble> Catalogue { get => m_catalogue; set => m_catalogue = value; }

        public Ikea(string p_secteur, List<Meuble> p_meubles)
        {
            Secteur = p_secteur;
            Catalogue = p_meubles;
        }

        public string ListerLesProduits()
        {
            StringBuilder v_sb = new StringBuilder();
            v_sb.AppendLine($"IKEA SECTEUR : {Secteur}");
            m_catalogue.ForEach(meuble =>
            {
                v_sb.AppendLine($"{meuble}");
            });
            return v_sb.ToString();
        }
    }
}
