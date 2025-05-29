using HeadacheDetective.Domain.enums;

namespace HeadacheDetective.Domain;

public class DailyActivity
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
    public int Steps { get; set; }
    public int ActiveMinutes { get; set; }
    public int CaloriesBurned { get; set; }
    public string? WorkoutType { get; set; }

    public WorkoutIntensity WorkoutIntensity { get; set; } = WorkoutIntensity.None;
}
