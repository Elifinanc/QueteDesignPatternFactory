using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    class Ecologiste:President
    {
        private string _character = "Végétarien";
        private string _slogan = "Le prochain qui touche à une vache on l'envoi en Inde!";
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
