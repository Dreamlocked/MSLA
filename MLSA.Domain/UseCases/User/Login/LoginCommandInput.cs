using MediatR;

namespace MLSA.Domain.UseCases.User.Login;
public class LoginCommandInput : IRequest<LoginCommandOutput>
{
    public string Email { get; set; }
    public string Password { get; set; }
}
