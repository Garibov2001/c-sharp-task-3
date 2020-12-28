using System;
using System.Collections.Generic;
using System.Text;

namespace PashaHolding.Models
{
    class Department
    {
        private static int _autoIncrement;
        public int Id { get; private set; }
        public string Name { get    ; set; }
        public Company CompanyObj { get; set; }
        public Department()
        {
            _autoIncrement++;
            Id = _autoIncrement;
        }
    }
}
