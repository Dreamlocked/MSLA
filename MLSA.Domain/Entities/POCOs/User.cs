namespace MLSA.Domain.Entities.POCOs;
public class User
{
    public Guid Id { get; set; }
    public Guid RoleId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public DateTime CreatedAt { get; set; }
}
