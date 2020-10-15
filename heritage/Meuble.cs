using System;
namespace heritage
{
    public abstract class Meuble
    {
        private double m_longueur;
        private double m_largeur;
        private double m_hauteur;

        protected double Longueur { get => m_longueur; }
        protected double Largeur { get => m_largeur; }
        protected double Hauteur { get => m_hauteur; }

        public Meuble(double p_longueur, double p_largeur, double p_hauteur)
        {
            m_longueur = IsPositive(p_longueur);
            m_largeur = IsPositive(p_largeur);
            m_hauteur = IsPositive(p_hauteur);
        }

        private double IsPositive(double p_value)
        {
            return p_value <= 0.00 ? throw new ArgumentException() : p_value;
        }

        public abstract string NoticeDeMontage();

        public override string ToString()
        {
            return $"{this.GetType().Name} [Longueur : {Longueur}, Largeur : {Largeur}, Hauteur : {Hauteur}]";
        }

    }
}
