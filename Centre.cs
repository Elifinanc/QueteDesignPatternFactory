using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    class Centre : President
    {
        private string _character = "Indécis";
        private string _slogan = "Venez tous comme vous êtes!...enfin quoi que venez peut être pas tous hein";
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
