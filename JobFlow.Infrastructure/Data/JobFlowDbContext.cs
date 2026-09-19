using JobFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobFlow.Infrastructure.Data;

public class JobFlowDbContext : DbContext
{
    public JobFlowDbContext(DbContextOptions<JobFlowDbContext> options)
        : base(options)
    {
    }

    public DbSet<Company> Companies => Set<Company>();
    public DbSet<JobApplication> JobApplications => Set<JobApplication>();
    public DbSet<Interview> Interviews => Set<Interview>();
    public DbSet<Note> Notes => Set<Note>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(JobFlowDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}