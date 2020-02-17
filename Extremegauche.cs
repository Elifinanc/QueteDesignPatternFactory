using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    class Extremegauche:President
    {
        private string _character = "Fou";
        private string _slogan = "Mettons tout ce que nous avons en commun...Quand on dit tout c'est vraiment tout!";
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
