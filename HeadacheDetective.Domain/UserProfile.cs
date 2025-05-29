using HeadacheDetective.Domain.enums;

namespace HeadacheDetective.Domain;

public class UserProfile
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public User? User { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public DateTime DateOfBirth { get; set; } = DateTime.UtcNow.AddYears(-30);
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime LastUpdated { get; set; } = DateTime.UtcNow;
    public string? Notes { get; set; }
    public bool IsActive { get; set; } = true;

    public HeadacheFrequency HeadacheFrequencyValue { get; set; } = HeadacheFrequency.None;
    public Diet DietValue { get; set; } = Diet.None;
    public ExerciseLevel ExerciseLevelValue { get; set; } = ExerciseLevel.None;
    public EatingHabits EatingHabitsValue { get; set; } = EatingHabits.None;
    public SleepQuality SleepQualityValue { get; set; } = SleepQuality.None;
}
