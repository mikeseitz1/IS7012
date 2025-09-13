using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitCatSeitzme.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string ResumeUrl { get; set; }
        public string CoverLetter { get; set; }
        public DateTime ApplicationDate { get; set; }
        public DateTime? TargetStart { get; set; }
        public string Status { get; set; }
        public int JobId { get; set; }
        public JobTitle JobTitle { get; set; }
        public string? CompanyName { get; set; }
        public string Industry { get; set; }



    }
}