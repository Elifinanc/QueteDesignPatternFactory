using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    class Droite: President
    {
        private string _character = "Psychopathe";
        private readonly string _slogan = "Bientôt Sarkozy, le retour!";
        public override string Character
        {
            get { return _character; }
        }

        public override string Slogan
        {
            get { return _slogan; }
        }
    }
}
