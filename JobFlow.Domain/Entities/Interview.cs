namespace JobFlow.Domain.Entities;

public class Interview
{
    public Guid Id { get; set; }

    public Guid JobApplicationId { get; set; }

    public JobApplication JobApplication { get; set; } = null!;

    public DateTime ScheduledAt { get; set; }

    public string? InterviewType { get; set; }

    public string? Interviewer { get; set; }

    public string? Feedback { get; set; }

    public bool IsCompleted { get; set; }
}