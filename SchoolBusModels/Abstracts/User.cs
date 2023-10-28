namespace SchoolBusModels.Abstracts;

public abstract class User : BaseEntity
{
    public string Username { get; set; }
    public string Password { get; set; }
}
