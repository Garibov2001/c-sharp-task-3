using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace PashaHolding.Models
{
    class Vacancy
    {
        private static int _autoIncrement;
        public int Id { get; private set; }
        public VacancyNameEnum VacancyType { get; set; }
        public Department DepartmentObj { get; set; }
        public List<Candidate> CandidateList { get; set; } = new List<Candidate>();
        public List<Candidate> ToInterviewAcceptedList { get; set; } = new List<Candidate>();

        public Vacancy()
        {
            _autoIncrement++;
            Id = _autoIncrement;
        }


        //Namizedler arasindan interview - a kecenleri secmek:
        public void FilterCandidates()
        {
            foreach (Candidate candidate in CandidateList)
            {
                if (candidate.Experience || candidate.Productive)
                {
                    ToInterviewAcceptedList.Add(candidate);
                }
            }
        }

        //Butun interviewlardan kecenler
        public string GetAccepted()
        {
            List<Candidate> acceptedToWork = new List<Candidate>();

            foreach (Candidate candidate in ToInterviewAcceptedList)
            {
                if (candidate.Experience && candidate.Productive)
                {
                    acceptedToWork.Add(candidate);
                }
            }
            if (acceptedToWork.Count > 0)
            {
                Console.WriteLine("Ise qebul edilenler:");
                return JsonSerializer.Serialize(acceptedToWork);
            }

            Console.WriteLine("Ise qebul edilenler:");
            return JsonSerializer.Serialize(acceptedToWork);
        }

        //Ilk interview:
        public void FirstInterview(Candidate candidate, bool isSuccess)
        {
            if (ToInterviewAcceptedList.Contains(candidate))
            {
                candidate.IsSuccessFirstInter = isSuccess;
            }
            else
            {
                Console.WriteLine("Bu namized bizim ehityyaclarimizi odemir, ona gore 1-ci interview buraxilmadi");
            }
        }

        //Ikinci interview interview:
        public void SecondInterview(Candidate candidate, bool isSuccess)
        {
            if (ToInterviewAcceptedList.Contains(candidate) && candidate.IsSuccessFirstInter == true)
            {
                candidate.IsSuccessSecondInter = isSuccess;
            }
            else
            {
                Console.WriteLine("Bu sexs birinci interviewdan kece bilmeyib");
            }

        }
    }

    
}
