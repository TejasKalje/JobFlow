namespace JobFlow.Domain.Entities;

public class Company
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Website { get; set; }

    public string? Location { get; set; }

    public ICollection<JobApplication> JobApplications { get; set; } = [];
}