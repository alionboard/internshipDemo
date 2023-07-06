namespace InternshipDemo;
public class RegisterDto
{
    public required string UserName { get; set; }
    public required string Password { get; set; }
    public required string Email { get; set; }
    public string? Role { get; set; }
}
