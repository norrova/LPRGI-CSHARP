using System;
namespace heritage
{
    public class Buffet : Meuble
    {
        public Buffet(double p_hauteur, double p_largeur, double p_longueur) : base(p_hauteur, p_largeur, p_longueur)
        {
        }

        public override string NoticeDeMontage()
        {
            return $"Ne pas utiliser le chat comme soutien de porte !";
        }
    }
}
