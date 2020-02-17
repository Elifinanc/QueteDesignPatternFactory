using System;
using System.Collections.Generic;
using System.Text;

namespace QueteDesignPatternFactory
{
    class Extremedroite:President
    {
        private string _character = "Xénophobe";
        private string _slogan = "Das ist Frankreich!!!";
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
