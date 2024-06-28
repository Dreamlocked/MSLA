namespace MLSA.Domain.UseCases.User.Login;
public class LoginCommandOutput
{
    public Guid Id { get; set; }
    public Guid RoleId { get; set; }
    public string Email { get; set; }

}
