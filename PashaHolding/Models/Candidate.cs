using System;
using System.Collections.Generic;
using System.Text;

namespace PashaHolding.Models
{
    class Candidate
    {
        private static int _autoIncrement;
        public int Id { get; private set; }
        public string FullName { get; set; }
        public bool Experience { get; set; }
        public bool Productive { get; set; }

        public bool? IsSuccessFirstInter { get; set; }
        public bool? IsSuccessSecondInter { get; set; }

        public Candidate()
        {
            _autoIncrement++;
            Id = _autoIncrement;
        }
    }
}
