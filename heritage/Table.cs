using System;
namespace heritage
{
    public class Table : Meuble
    {
        public Table(double p_hauteur, double p_largeur, double p_longueur) : base(p_hauteur, p_largeur, p_longueur)
        {
        }

        public override string NoticeDeMontage()
        {
            return $"Ne pas utiliser un tournevis erratique !";
        }
    }
}
