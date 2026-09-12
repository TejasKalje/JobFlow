using JobFlow.Domain.Enums;

namespace JobFlow.Domain.Entities;

public class JobApplication
{
    public Guid Id { get; set; }

    public Guid CompanyId { get; set; }

    public Company Company { get; set; } = null!;

    public string JobTitle { get; set; } = string.Empty;

    public string? Location { get; set; }

    public decimal? Salary { get; set; }

    public string? JobUrl { get; set; }

    public DateTime AppliedDate { get; set; }

    public ApplicationStatus Status { get; set; }

    public string? Description { get; set; }

    public ICollection<Interview> Interviews { get; set; } = [];

    public ICollection<Note> Notes { get; set; } = [];
}