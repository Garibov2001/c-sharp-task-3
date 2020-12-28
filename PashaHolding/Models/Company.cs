using System;
using System.Collections.Generic;
using System.Text;

namespace PashaHolding.Models
{
    class Company
    {
        private static int _autoIncrement;
        public int Id { get; private set; }
        public string Name { get; set; }
        public Holding HoldingObj { get; set; }
        public Company()
        {
            _autoIncrement++;
            Id = _autoIncrement;
        }       

       
    }
}
