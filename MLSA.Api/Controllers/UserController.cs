using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MLSA.Domain.UseCases.User.Login;

namespace MLSA.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController(IMediator mediator) : ControllerBase
{
    public async Task<IActionResult> Login(LoginCommandInput loginCommandInput)
    {
        var loginCommandOutput = await mediator.Send(loginCommandInput);
        return Ok(loginCommandOutput);
    }

    [Authorize]
    public async Task<IActionResult> DoTask(RegisterCommandInput registerCommandInput)
    {
        var registerCommandOutput = await mediator.Send(registerCommandInput);
        return Ok(registerCommandOutput);
    }
}
