using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    abstract class PresidentFactory
    {
        public static President Slogan { get; private set; }

        public static President Create(string Character)
        {
            if (Character == "Vénal")
            {
                return new LREM();
            }
            else if (Character == "Indécis")
            {
                return new Centre();
            }
            else if (Character == "Fou")
            {
                return new Extremegauche();
            }
            else if (Character == "Végétarien")
            {
                return new Ecologiste();
            }
            else if (Character == "Profiteur")
            {
                return new Gauche();
            }
            else if (Character == "Psychopathe")
            {
                return new Droite();
            }
            else if (Character == "Xénophobe")
            {
                return new Extremedroite();
            }
            else
            {
                throw new ArgumentException("There is no President with this character, please try again and write a correct one: ");
            }
        }
    }
}
