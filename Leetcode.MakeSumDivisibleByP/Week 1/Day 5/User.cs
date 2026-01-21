namespace Studying.Day_5
{
    public class User
    {
        public string Name { get; set; }
        public string? Email { get; set; }

        public User(string name, string? email)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email;
        }
    }
}
