using System;
using System.Collections.Generic;
using System.Text;

namespace PashaHolding.Models
{
    class Holding
    {

        private static int _autoIncrement;
        public int Id { get; private set; }
        public string Name { get; set; }
        public Holding()
        {
            _autoIncrement++;
            Id = _autoIncrement;
        }

        public void Declaration(DeclarationEnum declarationForm, Company companyObj , params Department[] departments)
        {            
            if(declarationForm  == DeclarationEnum.Vacancy)
            {
                
                foreach (Department department in departments)
                {
                    Console.WriteLine($"\"{companyObj.Name}\" şirketinin \"{department.Name}\" şobesinde vakansiyalar elan oldundu.");
                }
            }
            else
            {
                Console.WriteLine("Bu elan sistemde yoxdur.");
            }
        }
    }

    enum DeclarationEnum
    {
        Vacancy,
        SalaryIncreasing,
        SalaryDecreasing,
        GeneralMeeting,
    }

}
