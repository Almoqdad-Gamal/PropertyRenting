namespace PropertyRenting.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public string Role { get; set; } = "Tenant";
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}