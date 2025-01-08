namespace Core.DTOs;

public class ParticipantDto
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}


public class ParticipantLoginDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}