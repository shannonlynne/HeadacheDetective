using HeadacheDetective.Domain.enums;

namespace HeadacheDetective.Domain;

public class DailyMood
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.UtcNow);
    public Mood? MoodToday { get; set; }
    public LevelOfStress? StressLevel { get; set; }
}
