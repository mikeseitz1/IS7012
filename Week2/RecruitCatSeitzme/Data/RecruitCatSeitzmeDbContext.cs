using Microsoft.EntityFrameworkCore;

public class RecruitCatSeitzmeDbContext : DbContext
{
    public RecruitCatSeitzmeDbContext(DbContextOptions<RecruitCatSeitzmeDbContext> options)
        : base(options)
    {
    }

    public DbSet<RecruitCatSeitzme.Models.Company> Company { get; set; } = default!;

    public DbSet<RecruitCatSeitzme.Models.Candidate> Candidate { get; set; } = default!;

    public DbSet<RecruitCatSeitzme.Models.Industry> Industry { get; set; } = default!;

    public DbSet<RecruitCatSeitzme.Models.JobTitle> JobTitle { get; set; } = default!;
}
