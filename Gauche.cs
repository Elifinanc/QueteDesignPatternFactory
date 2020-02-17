using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    class Gauche:President
    {
        private string _character = "Profiteur";
        private string _slogan = "C'est bon les gars, on a déja fait le tour de l'Elysée!";
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
