namespace RecruitCatSeitzme.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        public required string IndustryName { get; set; }
        public List<Candidate>? Candidates { get; set; }
        public List<Company>? Companies { get; set; }


    }
}