using MediatR;
using MLSA.Domain.Entities.Exceptions;
using MLSA.Domain.Entities.Interfaces;

namespace MLSA.Domain.UseCases.User.Login;
public class LoginHandler(IUnitOfWork unitOfWork) : IRequestHandler<LoginCommandInput, LoginCommandOutput>
{
    public async Task<LoginCommandOutput> Handle(LoginCommandInput request, CancellationToken cancellationToken)
    {
        var result = await unitOfWork.UserRepository.Login(request.Email, request.Password)
             ?? throw new UnauthorizedException("Correo o contraseña incorrecta");

        return new LoginCommandOutput()
        {
            Id = result.Id,
            RoleId = result.RoleId,
            Email = result.Email
        };
    }
}
