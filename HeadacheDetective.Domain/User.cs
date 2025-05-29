namespace HeadacheDetective.Domain;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? TimeZone { get; set; }
    public string? Language { get; set; }
    public string? Country { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public void SetPasswordHash(string password)
    {
        // Here you would typically use a hashing algorithm to hash the password
        // For simplicity, we are just assigning the password directly
        PasswordHash = password; // Replace with actual hashing logic
    }
}
