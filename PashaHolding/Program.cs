using System;
using PashaHolding.Models;

namespace PashaHolding
{
    class Program
    {
        static void Main(string[] args)
        {
            Holding pashHold = new Holding()
            {
                Name = "Pasha",
            };

            Company pashSig = new Company()
            {
                Name = "Pasha Sigorta",
                HoldingObj = pashHold,
            };

            // Departmenler
            Department it = new Department()
            {
                Name = "Information Tech",
                CompanyObj = pashSig
            };

            Department marketing = new Department()
            {
                Name = "Marketing",
                CompanyObj = pashSig
            };

            Department finance = new Department()
            {
                Name = "Finance",
                CompanyObj = pashSig
            };

            // Vakansiya elani
            pashHold.Declaration(DeclarationEnum.Vacancy, pashSig, it, marketing, finance);

            // Namizedler
            Candidate cand1 = new Candidate()
            {
                FullName = "Qedir Memmedov",
                Experience = false,
                Productive = true,
            };

            Candidate cand2 = new Candidate()
            {
                FullName = "Zaur Memmedov",
                Experience = true,
                Productive = true,
            };

            Candidate cand3 = new Candidate()
            {
                FullName = "Aydin Memmedov",
                Experience = false,
                Productive = false,
            };

            Candidate cand4 = new Candidate()
            {
                FullName = "Araz Memmedov",
                Experience = false,
                Productive = true,
            };

            Vacancy programmer = new Vacancy()
            {
                VacancyType = VacancyNameEnum.SoftwareDeveloper,
                DepartmentObj = it
            };

            Vacancy financeSpec = new Vacancy()
            {
                VacancyType = VacancyNameEnum.FinanceSpecialist,
                DepartmentObj = finance
            };

            Vacancy marketingSpec = new Vacancy()
            {
                VacancyType = VacancyNameEnum.MarketingSpecialist,
                DepartmentObj = marketing
            };

            //PRogramlasdirmaya apply eden namizedler
            programmer.CandidateList.Add(cand1);

            //Ilkin telebleri qarsilayan namizedlerin filterlenmesi
            programmer.FilterCandidates();

            // Interviewlar ve onlarin neticeleri
            programmer.FirstInterview(cand1, true);

            programmer.SecondInterview(cand1, true);


            // Ise qebul olan Namizedler
            programmer.GetAccepted();





        }
    }
}
