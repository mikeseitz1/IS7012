namespace RecruitCatSeitzme.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; }
        public required string JobName { get; set; }
        public decimal SalaryMin { get; set; }
        public decimal SalaryMax { get; set; }
        public required string JobDescription { get; set; }
        public List<Candidate>? Candidates { get; set; }

    }
}