using System;
using System.Collections.Generic;
using System.Text;

namespace PashaHolding
{
    class Holding
    {

        private static int _autoIncrement;
        public Holding()
        {
            _autoIncrement++;
            Id = _autoIncrement;
        }

        public int Id { get; private set; }
        public string Name { get; set; }

    }
}
