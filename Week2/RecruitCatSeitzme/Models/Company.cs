using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSeitzme.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyPhone { get; set; }
        public int JobId { get; set; }
        public string PositionName { get; set; }
        public string JobLocation { get; set; }
        public DateTime? JobStartDate { get; set; }
        public decimal JobSalaryMax { get; set; }
        public decimal SalaryMin { get; set; }  
        public string Industry { get; set; }
        public List<Candidate>? Candidates { get; set; }
    

    }
}