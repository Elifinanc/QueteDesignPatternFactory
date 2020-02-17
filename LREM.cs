using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    class LREM : President
    {
        private string _character = "Vénal";
        private string _slogan = "On adore le jaune, surtout en gilet!";
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
