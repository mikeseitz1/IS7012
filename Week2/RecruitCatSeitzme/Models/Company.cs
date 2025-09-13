namespace RecruitCatSeitzme.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public required string CompanyName { get; set; }
        public required string CompanyAddress { get; set; }
        public required string CompanyPhone { get; set; }
        public int JobId { get; set; }
        public required string PositionName { get; set; }
        public required string JobLocation { get; set; }
        public DateTime? JobStartDate { get; set; }
        public decimal JobSalaryMax { get; set; }
        public decimal SalaryMin { get; set; }
        public string IndustryName { get; set; }
        public Industry Industry { get; set; }
        public List<Candidate>? Candidates { get; set; }


    }
}